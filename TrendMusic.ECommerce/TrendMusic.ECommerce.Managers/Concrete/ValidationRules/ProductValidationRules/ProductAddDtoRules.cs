using FluentValidation;
using System.ComponentModel.DataAnnotations;
using TrendMusic.ECommerce.Dtos.Concrete.Product;

namespace TrendMusic.ECommerce.Managers.Concrete.ValidationRules.ProductValidationRules
{
    public class ProductAddDtoRules : AbstractValidator<ProductAddDto>
    {
        public ProductAddDtoRules()
        {
            RuleFor(x => x.Property1).NotEmpty().WithMessage("PRoperty 1 boş olamaz ");
        }
    }
}
