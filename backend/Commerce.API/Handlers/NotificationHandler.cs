using Commerce.CrossCutting.Core.Interface;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.API.Handlers
{
    public class NotificationHandler
    {

        private readonly RequestDelegate Next;

        public NotificationHandler(RequestDelegate next)
        {
            Next = next;
        }

        public async Task Invoke(HttpContext context, IServiceNotification notification)
        {
            await Next(context);
            if (notification.HasNotification())
                await HandleNotification(context, notification);
        }

        private async Task HandleNotification(HttpContext context, IServiceNotification notification)
        {
            var responseBody = notification.GetNotifications();
            var response = context.Response;
            response.StatusCode = responseBody.Code;
            try
            {
                await response.WriteAsJsonAsync(responseBody);
            }
            catch (Exception e)
            {
                Trace.WriteLine(e, "Error");
                await response.Body.FlushAsync();
            }
        }
    }
}
