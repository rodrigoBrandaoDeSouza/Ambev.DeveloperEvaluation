using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Services;
using Ambev.DeveloperEvaluation.Messaging.Events;
using Ambev.DeveloperEvaluation.Messaging.Interfaces;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Services
{
    /// <summary>
    /// Implements the application-level service responsible for managing sales.
    /// It persists sales to the database and publishes domain events to the messaging layer.
    /// </summary>
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository _repository;
        private readonly IMessagePublisher _publisher;

        public SaleService(ISaleRepository repository, IMessagePublisher publisher)
        {
            _repository = repository;
            _publisher = publisher;
        }

        /// <inheritdoc/>
        public async Task<Domain.Entities.Sale> CreateAsync(Domain.Entities.Sale sale, CancellationToken cancellationToken = default)
        {
            ApplyDiscountRules(sale);

            // Persist in database
            var createdSale = await _repository.CreateAsync(sale, cancellationToken);

            // Publish domain event
            var saleEvent = new SaleCreatedEvent
            {
                SaleId = createdSale.Id,
                Customer = createdSale.Customer,
                Branch = createdSale.Branch,
                OccurredAt = DateTime.UtcNow,
                Items = createdSale.Items.Select(i => new SaleCreatedItem
                {
                    ProductName = i.ProductName,
                    Quantity = i.Quantity,
                    UnitPrice = i.UnitPrice
                }).ToList()
            };

            await _publisher.PublishAsync(saleEvent, cancellationToken);
            return createdSale;
        }

        public async Task<bool> DeleteAsync(Guid saleId, CancellationToken cancellationToken = default)
        {
            var deleted = await _repository.DeleteAsync(saleId, cancellationToken);
            if (deleted)
            {
                var @event = new SaleDeletedEvent
                {
                    SaleId = saleId,
                    OccurredAt = DateTime.UtcNow
                };

                await _publisher.PublishAsync(@event, cancellationToken);
            }
            return deleted;
        }

        public async Task<IEnumerable<Domain.Entities.Sale>> FetchAsync(int page, int pageSize, CancellationToken cancellationToken = default)
        {
            return await _repository.FetchSales(page, pageSize);
        }

        public async Task<Domain.Entities.Sale?> GetByIdAsync(Guid saleId, CancellationToken cancellationToken = default)
        {
            return await _repository.GetByIdAsync(saleId, cancellationToken);
        }

        public async Task<Domain.Entities.Sale> UpdateAsync(Domain.Entities.Sale sale, CancellationToken cancellationToken = default)
        {
            var existingSale = await _repository.GetByIdAsync(sale.Id);

            if(existingSale is null)
                throw new KeyNotFoundException($"Sale with ID {sale.Id} not found");

            ApplyDiscountRules(sale);

            var updated = await _repository.UpdateAsync(sale, cancellationToken);

            var @event = new SaleUpdatedEvent
            {
                SaleId = updated.Id,
                Customer = updated.Customer,
                Branch = updated.Branch,
                OccurredAt = DateTime.UtcNow,
                Items = updated.Items.Select(i => new SaleUpdatedItem
                {
                    ProductName = i.ProductName,
                    Quantity = i.Quantity,
                    UnitPrice = i.UnitPrice
                }).ToList()
            };

            await _publisher.PublishAsync(@event, cancellationToken);
            return updated;
        }

        private void ApplyDiscountRules(Domain.Entities.Sale sale)
        {
            var grouped = sale.Items
                .GroupBy(i => i.ProductName.ToLower().Trim());

            foreach (var group in grouped)
            {
                var totalQuantity = group.Sum(i => i.Quantity);

                decimal discountPercent = 0;
                if (totalQuantity >= 4 && totalQuantity < 10)
                    discountPercent = 10;
                else if (totalQuantity >= 10 && totalQuantity <= 20)
                    discountPercent = 20;

                foreach (var item in group)
                {
                    item.DiscountPercent = discountPercent;

                    var discountFactor = (100 - discountPercent) / 100m;
                    item.TotalPrice = item.UnitPrice * item.Quantity * discountFactor;
                }
            }

            sale.TotalAmount = sale.Items.Sum(i => i.TotalPrice);
        }
    }
}
