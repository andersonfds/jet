using System.Collections.Generic;
using System.Linq;

namespace Commerce.CrossCutting.Core.Interface
{
    public class Notification
    {
        public string Property { get; set; }

        public string Message { get; set; }
    }

    public class BodyNotification
    {
        public int Code { get; set; }

        public IList<Notification> Errors { get; set; } = new List<Notification>();

        public bool HasErrors { get => Errors.Count() > 0; }

        public void Add(Notification notification) => Errors.Add(notification);
    }

    public interface IServiceNotification
    {
        BodyNotification GetNotifications();

        bool HasNotification();

        void Add(string property, string message);

        void AddWithCode(int code, string property, string message);
    }
}
