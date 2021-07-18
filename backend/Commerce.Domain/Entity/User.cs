using Commerce.Domain.Interfaces;
using FluentValidation;
using System.Collections.Generic;

namespace Commerce.Domain.Entity
{
    public class User : IEntity<User>
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public virtual ICollection<UserCart> UserCart { get; set; }

        #region Validation
        public override bool IsValid()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Nome é obrigatório");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Senha é obrigatória")
                .MinimumLength(6).WithMessage("O tamanho mínimo da senha é 6 caracteres");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Telefone é obrigatório");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("O E-mail é obrigatório");

            return Validate(this).IsValid;
        }
        #endregion Validation
    }
}
