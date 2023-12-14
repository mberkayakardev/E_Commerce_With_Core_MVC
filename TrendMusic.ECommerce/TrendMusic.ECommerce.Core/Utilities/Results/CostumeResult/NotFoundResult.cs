using TrendMusic.ECommerce.Core.Utilities.Results.BaseResult;
using TrendMusic.ECommerce.Core.Utilities.Results.ComplexTypes;

namespace TrendMusic.ECommerce.Core.Utilities.Results.CostumeResult
{
    public class NotFoundResult<T> : DataResult<T> 
    {
        public NotFoundResult(string Message) : base(default, ResultStatus.NotFound, Message)
        {
            
        }
        public NotFoundResult() : base(default, ResultStatus.NotFound)
        {

        }
    }
}
