using Commerce.CrossCutting.Core.Interface;
using Commerce.Data.Core.DbContexts;
using Commerce.Domain.Interfaces;

namespace Commerce.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly IServiceNotification Notification;
        protected readonly IAppDbContext Context;

        public UnitOfWork(IServiceNotification notification, IAppDbContext context)
        {
            Notification = notification;
            Context = context;
        }

        public void Save()
        {
            if (!Notification.HasNotification())
                if (Context?.ChangeTracker?.HasChanges() == true)
                    Context?.SaveChanges();
        }
    }
}
