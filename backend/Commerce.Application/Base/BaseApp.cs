using AutoMapper;
using Commerce.CrossCutting.Core.Interface;
using Commerce.Domain.Interfaces;

namespace Commerce.Application.Base
{
    public class BaseApp
    {
        protected readonly IUnitOfWork UnitOfWork;
        protected readonly IMapper Mapper;

        public BaseApp(IUnitOfWork uow)
        {
            UnitOfWork = uow;
        }

        public BaseApp(IUnitOfWork uow, IMapper mapper)
        {
            UnitOfWork = uow;
            Mapper = mapper;
        }

        public DTO Done<DTO>(dynamic obj)
        {
            return Mapper.Map<DTO>(obj);
        }
    }
}
