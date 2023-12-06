using AkarCommerce.MusicStore.Core.Extentions.FluentValidation.ComplexTypes;
using FluentValidation.Results;

namespace AkarCommerce.MusicStore.Core.Extentions.FluentValidation.Concrete
{
    public static class FluentApiExtentions
    {
        public static List<ErrorModel> GetErrors(this ValidationResult result )
        {
            List<ErrorModel> errors = new List<ErrorModel>();
            foreach (var item in result.Errors)
            {
                errors.Add(new ErrorModel() { Property = item.PropertyName, ErrorDescription = item.ErrorMessage });
            }
            return errors; 
        }

    }
}
