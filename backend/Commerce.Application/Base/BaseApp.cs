using AutoMapper;
using Commerce.Domain.Interfaces;

namespace Commerce.Application.Base
{
    public class BaseApp
    {
        protected readonly IUnitOfWork UnitOfWork;
        protected readonly IMapper Mapper;

        public BaseApp(IUnitOfWork uow)
        {
            Uow = uow;
        }

        public BaseApp(IUnitOfWork uow, IMapper mapper)
        {
            UnitOfWork = uow;
            Mapper = mapper;
        }

        public IUnitOfWork Uow { get; }

        public DTO Done<DTO>(dynamic obj)
        {
            return Mapper.Map<DTO>(obj);
        }
    }
}
