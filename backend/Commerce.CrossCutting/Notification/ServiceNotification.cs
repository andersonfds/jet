using Commerce.CrossCutting.Core.Interface;
using System.Collections.Generic;

namespace Commerce.CrossCutting.Notification
{
    public class ServiceNotification : IServiceNotification
    {
        private readonly BodyNotification Notifications;

        public ServiceNotification()
        {
            Notifications = new BodyNotification { };
        }

        public void Add(string property, string message)
        {
            AddWithCode(409, property, message);
        }

        public void AddWithCode(int code, string property, string message)
        {
            Notifications.Code = code;
            Notifications.Add(new Core.Interface.Notification
            {
                Property = property,
                Message = message,
            });
        }

        public bool HasNotification()
        {
            return Notifications.HasErrors;
        }

        public BodyNotification GetNotifications()
        {
            return Notifications;
        }
    }
}
