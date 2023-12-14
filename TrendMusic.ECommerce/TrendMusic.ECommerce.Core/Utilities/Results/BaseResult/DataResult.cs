using TrendMusic.ECommerce.Core.Utilities.Results.ComplexTypes;

namespace TrendMusic.ECommerce.Core.Utilities.Results.BaseResult
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, ResultStatus status, string Messages) : base(status, Messages)
        {
        }
        public DataResult(T data, ResultStatus status) : base(status)
        {
        }
        public T Data { get; }
    }
}
