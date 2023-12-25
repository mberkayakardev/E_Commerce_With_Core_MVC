using AutoMapper;
using FluentValidation;
using System.Linq.Expressions;
using TrendMusic.ECommerce.Core.Extentions.Concrete;
using TrendMusic.ECommerce.Core.Utilities.Pagination.ComplexTypes;
using TrendMusic.ECommerce.Core.Utilities.Results.BaseResult;
using TrendMusic.ECommerce.Core.Utilities.Results.ComplexTypes;
using TrendMusic.ECommerce.Core.Utilities.Results.CostumeResult;
using TrendMusic.ECommerce.DataAccess.EntityFramework.Abstract;
using TrendMusic.ECommerce.Dtos.Concrete.Product;
using TrendMusic.ECommerce.Entities.Concrete;
using TrendMusic.ECommerce.Managers.Abstract;
using TrendMusic.ECommerce.Managers.Abstract.Managers;
using TrendMusic.ECommerce.Managers.Concrete.ComplexTypes.Product;
using TrendMusic.ECommerce.Managers.Concrete.ConstVerables;

namespace TrendMusic.ECommerce.Managers.Concrete.Managers
{
    public class ProductManager : BaseManager, IProductService
    {
        private readonly IValidator<ProductAddDto> _AddProductValidator;
        public ProductManager(IMapper mapper, IUnitOfWork UnitOfWork, IValidator<ProductAddDto> AddProductValidator) : base(UnitOfWork, mapper)
        {
            _AddProductValidator = AddProductValidator;
        }

        /// <summary>
        /// EKleme
        /// </summary>
        public async Task<IDataResult<ProductAddDto>> AddProduct(ProductAddDto dto)
        {
            var ModelState = _AddProductValidator.Validate(dto);
            if (ModelState.IsValid)
            {
                var model = _Mapper.Map<Product>(dto);
                if (model == null)
                    return new ErrorResult<ProductAddDto>(Messages.Errors.MappingError);

                else
                {
                    var repository = _UnitOfWork.GetGenericRepository<Product>();
                    var result = await repository.CreateAsync(model);
                    return new DataResult<ProductAddDto>(dto, ResultStatus.Success, Messages.CRUD.Added);
                }
            }
            return new ValidationErrorResult<ProductAddDto>(ModelState.GetErrrors());
        }

        /// <summary>
        /// Hepsini getireceksin
        /// </summary>
        public async Task<IDataResult<List<ProductListDto>>> GetAllProduct()
        {
            var repository = _UnitOfWork.GetGenericRepository<Product>();
            var model = await repository.GetAllAsync(x => x.IsActive == true);
            if (model.Count == 0)
                return new NotFoundResult<List<ProductListDto>>();

            var DtoModel = _Mapper.Map<List<ProductListDto>>(model);
            if (model.Count == 0)
                return new MappingError<List<ProductListDto>>();

            return new DataResult<List<ProductListDto>>(DtoModel, ResultStatus.Success);

        }

        /// <summary>
        /// Silinenler ile birlikte hepsini getireceksin
        /// </summary>
        public async Task<IDataResult<List<ProductListDto>>> GetAllProductWithDeleted()
        {
            var repository = _UnitOfWork.GetGenericRepository<Product>();
            var model = await repository.GetAllAsync();
            if (model.Count == 0)
                return new NotFoundResult<List<ProductListDto>>();

            var DtoModel = _Mapper.Map<List<ProductListDto>>(model);
            if (model.Count == 0)
                return new MappingError<List<ProductListDto>>();

            return new DataResult<List<ProductListDto>>(DtoModel, ResultStatus.Success);
        }

        /// <summary>
        /// Arama öğeleri ile birlikte hepsini getireceksin
        /// </summary>
        /// <param name="productSearchModel"></param>
        /// <returns></returns>
        public async Task<IDataResult<List<ProductListDto>>> GetAllProductWithSearchModel(ProductSearchModel productSearchModel)
        {
            #region Validaton
            List<Expression<Func<Product, bool>>> predicates = new List<Expression<Func<Product, bool>>>();

            if (productSearchModel.CategoryId.HasValue)
                predicates.Add(c => c.ProductCategories.Any(x => x.CategoryId == productSearchModel.CategoryId));

            if (!string.IsNullOrEmpty(productSearchModel.ProductName))
                predicates.Add(c => c.ProductName.Trim().ToUpper().Contains(productSearchModel.ProductName.Trim().ToUpper()));

            if (productSearchModel.CikisYili.HasValue)
                predicates.Add(c => c.CreatedDate > productSearchModel.CikisYili || c.CreatedDate < productSearchModel.CikisYili);

            predicates.Add(x => x.IsActive == true);
            #endregion

            var repository = _UnitOfWork.GetGenericRepository<Product>();
            var model = await repository.GetAllAsyncWithListExpression(predicates);

            if (model.Count == 0)
                return new NotFoundResult<List<ProductListDto>>();

            var DtoModel = _Mapper.Map<List<ProductListDto>>(model);
            if (model.Count == 0)
                return new MappingError<List<ProductListDto>>();

            return new DataResult<List<ProductListDto>>(DtoModel, ResultStatus.Success);
        }

        public async Task<(MetaData MetaData, IDataResult<List<ProductListDto>>)> GetAllProductWithSearchModelAndPaging(ProductSearchModel productSearchModel)
        {
            #region Validaton
            List<Expression<Func<Product, bool>>> predicates = new List<Expression<Func<Product, bool>>>();

            if (productSearchModel.CategoryId.HasValue)
                predicates.Add(c => c.ProductCategories.Any(x => x.CategoryId == productSearchModel.CategoryId));

            if (!string.IsNullOrEmpty(productSearchModel.ProductName))
                predicates.Add(c => c.ProductName.Trim().ToUpper().Contains(productSearchModel.ProductName.Trim().ToUpper()));

            if (productSearchModel.CikisYili.HasValue)
                predicates.Add(c => c.CreatedDate > productSearchModel.CikisYili || c.CreatedDate < productSearchModel.CikisYili);

            predicates.Add(x => x.IsActive == true);
            #endregion

            var repository = _UnitOfWork.GetGenericRepository<Product>();
            var model = await repository.GetAllWithPagingAsync(productSearchModel, predicates);

            if (model.MetaData.TotalCount == 0)
            {
                return (model.MetaData, new NotFoundResult<List<ProductListDto>>());
            }

            var dtos = _Mapper.Map<List<ProductListDto>>(model);
            if (dtos.Count == 0 )
            {
                return (model.MetaData, new MappingError<List<ProductListDto>>());
            }
            return (model.MetaData, new DataResult<List<ProductListDto>>(dtos, ResultStatus.Success));

        }
    }
}
