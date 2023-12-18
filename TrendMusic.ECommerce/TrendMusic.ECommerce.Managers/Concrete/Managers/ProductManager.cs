using AutoMapper;
using FluentValidation;
using TrendMusic.ECommerce.Core.Extentions.Concrete;
using TrendMusic.ECommerce.Core.Utilities.Results.BaseResult;
using TrendMusic.ECommerce.Core.Utilities.Results.ComplexTypes;
using TrendMusic.ECommerce.Core.Utilities.Results.CostumeResult;
using TrendMusic.ECommerce.DataAccess.EntityFramework.Abstract;
using TrendMusic.ECommerce.Dtos.Concrete.Product;
using TrendMusic.ECommerce.Entities.Concrete;
using TrendMusic.ECommerce.Managers.Abstract;
using TrendMusic.ECommerce.Managers.Abstract.Managers;
using TrendMusic.ECommerce.Managers.Concrete.ConstVerables;

namespace TrendMusic.ECommerce.Managers.Concrete.Managers
{
    public class ProductManager : BaseManager,  IProductService
    {
        private readonly IValidator<ProductAddDto> _AddProductValidator;
        public ProductManager(IMapper mapper, IUnitOfWork UnitOfWork, IValidator<ProductAddDto> AddProductValidator) : base (UnitOfWork,mapper)
        {
            _AddProductValidator = AddProductValidator;
        }
        public async Task<IDataResult<ProductAddDto>> AddProduct(ProductAddDto dto)
        {
            var ModelState= _AddProductValidator.Validate(dto);
            if (ModelState.IsValid)
            {
                var model = _Mapper.Map<Product>(dto);
                if (model == null)
                    return new ErrorResult<ProductAddDto>(Messages.Errors.MappingError);

                else
                {
                    var repository = _UnitOfWork.GetGenericRepostiory<Product>();
                    var result = await repository.CreateAsync(model);
                    return new DataResult<ProductAddDto>(dto,ResultStatus.Success, Messages.CRUD.Added);
                }
            }
            return new ValidationErrorResult<ProductAddDto>(ModelState.GetErrrors());
        }
    }
}
