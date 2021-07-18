using Commerce.Domain.Entity;

namespace Commerce.BLL.Core
{
    public interface ILoginBLL
    {
        Token IssueLoginToken(string email, string password);
    }
}
