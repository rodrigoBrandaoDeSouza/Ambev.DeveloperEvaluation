using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sale.CreateSale
{
    public class CreateSaleValidator : AbstractValidator<CreateSaleCommand>
    {
        public CreateSaleValidator()
        {
            RuleFor(x => x.Customer)
                .NotEmpty().WithMessage("Customer is required")
                .MaximumLength(100);

            RuleFor(x => x.Branch)
                .NotEmpty().WithMessage("Branch is required")
                .MaximumLength(100);

            RuleFor(x => x.Items)
                .NotEmpty().WithMessage("At least one sale item is required");

            RuleForEach(x => x.Items).ChildRules(item =>
            {
                item.RuleFor(i => i.ProductName)
                    .NotEmpty().WithMessage("Product name is required")
                    .MaximumLength(100);

                item.RuleFor(i => i.Quantity)
                    .GreaterThan(0).WithMessage("Quantity must be greater than zero")
                    .LessThanOrEqualTo(20).WithMessage("Quantity cannot exceed 20");

                item.RuleFor(i => i.UnitPrice)
                    .GreaterThan(0).WithMessage("Unit price must be greater than zero");
            });
        }
    }
}
