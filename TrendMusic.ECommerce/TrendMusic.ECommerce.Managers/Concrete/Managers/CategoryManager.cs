using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
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
        private readonly IMemoryCache _memoryCache;
        public CategoryManager(IMapper mapper, IUnitOfWork unitOfWork, IMemoryCache memoryCache) : base(unitOfWork, mapper)
        {
            _memoryCache = memoryCache;
        }

        public async Task<IDataResult<List<CategoryListDto>>> GetAllCategories()
        {
            var repository = _UnitOfWork.GetGenericRepository<Category>();
            var models = await repository.GetAllAsync(x=> x.IsActive == true);
            if (models.Count == 0)
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


        public async Task<IDataResult<List<CategoryListDto>>> GetAllCategoriesWithCache()
        {
            List<CategoryListDto> CachedData = new List<CategoryListDto>(); // Data
            if (!_memoryCache.TryGetValue("Categories", out CachedData)) // Cache içerisinde data mevcut değilse 
            {
                var result = await GetAllCategories();
                if (result.Status == ResultStatus.Success) // Datalar Düzgün alınabildiyse bu sebeple burada veri tekrar cachelenir. 
                {
                    var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(1)) // 1 dakikdan önce silinmeyecek 
                    .SetPriority(CacheItemPriority.Low);           // Silinmesi gerekirse öncelik düşük bu sayede direk silinecek

                    _memoryCache.Set<List<CategoryListDto>>("Categories", result.Data, cacheEntryOptions);
                }
                return result;
            }
            return new DataResult<List<CategoryListDto>>(CachedData, ResultStatus.Success); // Cache içerisinde data mevcutsa 
        }



    }
}
