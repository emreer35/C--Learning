using System;
using System.Data;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation;

public class ProductValidator : AbstractValidator<Product>
{
    public ProductValidator()
    {
        RuleFor(p => p.ProductName).MinimumLength(2);
        RuleFor(p => p.ProductName).NotEmpty();
        RuleFor(p => p.UnitPrice).GreaterThan(0);
        //icecekler kategorisinde  unit price min 10 olsun 
        RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
        RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("urunler A harfi ile baslamalidir");

    }

    private bool StartWithA(string arg)
    {
        return arg.StartsWith("A");
    }
}
