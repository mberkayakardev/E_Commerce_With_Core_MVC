using TrendMusic.ECommerce.Core.Extentions.ComplexTypes;
using TrendMusic.ECommerce.Core.Utilities.Results.BaseResult;
using TrendMusic.ECommerce.Core.Utilities.Results.ComplexTypes;

namespace TrendMusic.ECommerce.Core.Utilities.Results.CostumeResult
{
    public class ValidationErrorResult<T> : DataResult<T>
    {
        public ValidationErrorResult(IEnumerable<ErrorModel> Errors) : base(default, ResultStatus.ValidationError, Errors)
        {

        }
    }
}
