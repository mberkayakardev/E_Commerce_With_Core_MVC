using TrendMusic.ECommerce.Core.Utilities.Results.BaseResult;

namespace TrendMusic.ECommerce.Core.Utilities.Results.CostumeResult
{
    public class MappingError<T> : DataResult<T>
    {
        public MappingError() : base(default, ComplexTypes.ResultStatus.MappingError, string.Empty)
        {
            
        }
        public MappingError(string Message) : base(default, ComplexTypes.ResultStatus.MappingError, Message)
        {

        }
    }
}
