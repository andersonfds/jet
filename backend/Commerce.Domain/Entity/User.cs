using Commerce.Domain.Interfaces;
using System.Collections.Generic;

namespace Commerce.Domain.Entity
{
    public class User : IEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<UserCart> UserCart { get; set; }
    }
}
