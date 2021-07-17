using System;

namespace Commerce.Domain.Entity
{
    public class UserCart
    {
        public Guid UserId { get; set; }

        public Guid ProductId { get; set; }

        public virtual User User { get; set; }

        public virtual Product Product { get; set; }
    }
}
