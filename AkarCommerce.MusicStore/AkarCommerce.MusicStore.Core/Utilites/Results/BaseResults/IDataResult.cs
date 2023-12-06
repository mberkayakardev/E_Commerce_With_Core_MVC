namespace AkarCommerce.MusicStore.Core.Utilites.Results.BaseResults
{
    public interface IDataResult<T> : IResult
    {
        public T Data { get; }
    }
}
