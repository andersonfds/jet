using Commerce.CrossCutting.Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.CrossCutting.Controller
{
    public class BaseController : ControllerBase
    {
        public readonly IServiceNotification Notification;

        public BaseController(IServiceNotification notification)
        {
            Notification = notification;
        }
    }
}
