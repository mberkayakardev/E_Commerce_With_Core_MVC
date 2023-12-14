using TrendMusic.ECommerce.Core.Utilities.Results.BaseResult;
using TrendMusic.ECommerce.Core.Utilities.Results.ComplexTypes;

namespace TrendMusic.ECommerce.Core.Utilities.Results.CostumeResult
{
    internal class ErrorResult<T> : DataResult<T>
    {
        public ErrorResult(string Message) : base(default,  ResultStatus.Error, Message)
        {
            
        }
    }
}
