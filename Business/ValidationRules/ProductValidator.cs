using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules;

public class ProductValidator : AbstractValidator<Product>
{
    public ProductValidator()
    {
        RuleFor(p => p.ProductName).NotEmpty();
        RuleFor(p => p.ProductName).MinimumLength(2);
        RuleFor(p => p.UnitPrice).NotEmpty();
        RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(0);
        RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 1);
        RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Product name have to start a or A.");
    }

    private bool StartWithA(string arg)
    {
        return arg.StartsWith("A");
    }
}