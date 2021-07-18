using Commerce.Domain.Entity;
using System.Collections.Generic;

namespace Commerce.CrossCutting.Core.Interface
{
    public interface IServiceToken
    {
        Token BakeOne(User user);
    }
}
