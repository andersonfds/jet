using Commerce.CrossCutting.Consts;
using Commerce.CrossCutting.Core.Interface;
using Commerce.Domain.Entity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Commerce.CrossCutting.Token
{
    public class ServiceToken : IServiceToken
    {
        private string AudienceId { get => SystemConsts.TokenAudienceId; }
        private string Issuer { get => SystemConsts.TokenIssuer; }
        private string Secret { get => SystemConsts.TokenSecurityValue; }

        public Domain.Entity.Token BakeOne(User user)
        {
            var tokenSecurity = Convert.FromBase64String(Secret);
            var tokenHandler = new JwtSecurityTokenHandler();
            var expirationDate = DateTime.UtcNow.AddMinutes(360);
            var claims = new List<Claim>
            {
                new Claim("UserId", user.Id.ToString()),
                new Claim("UserEmail", user.Email)
            };

            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Issuer = Issuer,
                Expires = expirationDate,
                Audience = AudienceId,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenSecurity), SecurityAlgorithms.HmacSha256Signature),
            };

            var accessToken = tokenHandler.CreateToken(tokenDescription);

            return new Domain.Entity.Token
            {
                UserId = user.Id,
                AccessToken = tokenHandler.WriteToken(accessToken),
            };
        }
    }
}
