using Commerce.CrossCutting.Core.Interface;
using System;

namespace Commerce.BLL.Base
{
    public class BaseBLL
    {
        protected IServiceNotification Notification;

        public BaseBLL(IServiceNotification notification)
        {
            Notification = notification;
        }

        public void Notify(string property, string message)
        {
            Notification.Add(property, message);
        }

        public void NotifyUnauthorized(string property, string message)
        {
            Notification.AddWithCode(401, property, message);
        }
    }
}
