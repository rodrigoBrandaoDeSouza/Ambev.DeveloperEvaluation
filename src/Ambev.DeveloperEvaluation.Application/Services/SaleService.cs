using Ambev.DeveloperEvaluation.Domain.Services;

namespace Ambev.DeveloperEvaluation.Application.Services
{
    public class SaleService : ISaleService
    {
        public Task<Domain.Entities.Sale> CreateAsync(Domain.Entities.Sale sale, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid saleId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Domain.Entities.Sale>> FetchAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.Sale?> GetByIdAsync(Guid saleId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.Sale> UpdateAsync(Domain.Entities.Sale sale, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
