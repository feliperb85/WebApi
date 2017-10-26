using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using FluentValidation;

namespace WebApi.Models
{
    public class User
    {
        
        public string id { get; set; }
        
        public string name { get; set; }

        public string email { get; set; }

    }

    public class UserValidator : AbstractValidator<User>
    {

        public UserValidator()
        {

            RuleFor(n => n.name)
                .NotEmpty().WithMessage("Favor preencher o campo nome!")
                .Length(3, 50).WithMessage("O nome de usuário deve conter no mínimo 3 letras!");

            RuleFor(n => n.email)
                .NotEmpty().WithMessage("Favor preencher o campo email!")
                .EmailAddress().WithMessage("Favor inserir um email válido!");

        }

    }
}
