using AutoMapper;
using TrendMusic.ECommerce.DataAccess.EntityFramework.Abstract;

namespace TrendMusic.ECommerce.Managers.Abstract.Managers
{
    public class BaseManager // Tüm Managerlarım buradan kalıtım alacak uzun uzun injectionlar ile uğraşmamak için
    {
        protected readonly IUnitOfWork _UnitOfWork;
        protected readonly IMapper _Mapper;
        public BaseManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UnitOfWork = unitOfWork;
            _Mapper = mapper;
        }
    }
}
