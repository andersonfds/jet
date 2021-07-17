using Commerce.CrossCutting.Core.Interface;

namespace Commerce.CrossCutting.Notification
{
    public class ServiceNotification : IServiceNotification
    {
        public bool HasNotification()
        {
            return false;
        }
    }
}
