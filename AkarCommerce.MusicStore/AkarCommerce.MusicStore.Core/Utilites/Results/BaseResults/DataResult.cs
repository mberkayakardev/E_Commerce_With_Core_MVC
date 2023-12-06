using AkarCommerce.MusicStore.Core.Utilites.Results.ComplexTypes;

namespace AkarCommerce.MusicStore.Core.Utilites.Results.BaseResults
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
