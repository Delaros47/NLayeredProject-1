using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {

        public ProductValidator()
        {
            RuleFor(p=>p.ProductName).NotEmpty().WithMessage("Product name cannot be empty");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Unit price cannot be empty");
            RuleFor(p => p.QuantityPerUnit).NotEmpty().WithMessage("Quantity per unit cannot be empty");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Category name cannot be empty");
            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage("Units In Stock cannot be empty");
        }

    }
}
