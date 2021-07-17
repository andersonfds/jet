using System;

namespace Commerce.CrossCutting.Core.Interface
{
    public interface ICurrentUser
    {
        Guid? UserId { get; }
    }
}
