using AutoMapper;
using TrendMusic.ECommerce.Core.Utilities.Results.BaseResult;
using TrendMusic.ECommerce.Core.Utilities.Results.ComplexTypes;
using TrendMusic.ECommerce.Core.Utilities.Results.CostumeResult;
using TrendMusic.ECommerce.DataAccess.EntityFramework.Abstract;
using TrendMusic.ECommerce.Dtos.Concrete.Category;
using TrendMusic.ECommerce.Entities.Concrete;
using TrendMusic.ECommerce.Managers.Abstract;
using TrendMusic.ECommerce.Managers.Abstract.Managers;
using TrendMusic.ECommerce.Managers.Concrete.ConstVerables;

namespace TrendMusic.ECommerce.Managers.Concrete.Managers
{
    public class CategoryManager : BaseManager, ICategoryService
    {
        public CategoryManager(IMapper mapper, IUnitOfWork unitOfWork) : base (unitOfWork, mapper)
        {
            
        }

        public async Task<IDataResult<List<CategoryListDto>>> GetAllCategories()
        {
            var repository = _UnitOfWork.GetGenericRepostiory<Product>();
            var models = await repository.GetAllAsync();
            if (models.Count == 0 )
                return new NotFoundResult<List<CategoryListDto>>(Messages.Errors.NotFoundError);
            else
            {
                var Dtos = _Mapper.Map<List<CategoryListDto>>(models);
                if (Dtos == null)
                    return new MappingError<List<CategoryListDto>>(Messages.Errors.NotFoundError);
                else
                    return new DataResult<List<CategoryListDto>>(Dtos, ResultStatus.Success);
            }
        }



    }
}
