using AkarCommerce.MusicStore.Core.Extentions.FluentValidation.ComplexTypes;
using AkarCommerce.MusicStore.Core.Utilites.Results.ComplexTypes;

namespace AkarCommerce.MusicStore.Core.Utilites.Results.BaseResults
{
    public interface IResult
    {
        public ResultStatus Status { get; }
        public string Messages { get; }
        public IEnumerable<ErrorModel> ValidationErrors { get; }
    }
}
