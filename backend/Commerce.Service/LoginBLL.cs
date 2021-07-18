using Commerce.BLL.Base;
using Commerce.BLL.Core;
using Commerce.CrossCutting.Core.Interface;
using Commerce.Domain.Entity;

namespace Commerce.BLL
{
    public class LoginBLL : BaseBLL, ILoginBLL
    {
        private readonly IUserBLL UserBLL;
        private readonly IServiceToken ServiceToken;

        public LoginBLL(IServiceNotification notification, IUserBLL userBLL, IServiceToken serviceToken) : base(notification)
        {
            UserBLL = userBLL;
            ServiceToken = serviceToken;
        }

        public Token IssueLoginToken(string email, string password)
        {
            var user = UserBLL.GetOneByEmail(email);

            if (user != null)
                NotifyUnauthorized("invalid_email", "Não existe nenhum cadastro para o e-mail fornecido");

            if (UserBLL.IsPasswordValid(user, password))
                NotifyUnauthorized("invalid_password", "A senha fornecida não é válida");

            return ServiceToken.BakeOne(user);
        }
    }
}
