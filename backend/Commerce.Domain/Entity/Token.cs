using System;

namespace Commerce.Domain.Entity
{
    public class Token
    {
        public Guid UserId { get; set; }

        public string AccessToken { get; set; }
    }
}
