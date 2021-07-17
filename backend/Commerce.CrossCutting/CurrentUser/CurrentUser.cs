using Commerce.CrossCutting.Core.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Security.Claims;

namespace Commerce.CrossCutting.CurrentUser
{
    public class CurrentUser : ICurrentUser
    {
        public Guid? UserId { get; set; }

        public CurrentUser(IHttpContextAccessor context)
        {
            if (context != null)
            {
                var identity = context.HttpContext.User.Identity as ClaimsIdentity;

                // Current User Id Claim
                Guid.TryParse(identity.FindFirst("UserId")?.Value, out var userId);
                UserId = userId;
            }
        }

    }
}
