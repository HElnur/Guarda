using FluentValidation;
using Guarda.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guarda.Business.DTOs.Authentication
{
    public class SignUpDto
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
    }

    public class SignUpDtoValidator : AbstractValidator<SignUpDto>
    {
        public SignUpDtoValidator()
        {
            RuleFor(x => x.FullName).NotNull().MaximumLength(50).MinimumLength(3);
            RuleFor(x => x.UserName).NotNull().MaximumLength(20).MinimumLength(3);
            RuleFor(x => x.Email).NotNull().MaximumLength(100);
            RuleFor(x => x.Password).NotNull().MaximumLength(25).MinimumLength(8);
            RuleFor(x => x.RepeatPassword).NotNull().MaximumLength(25).MinimumLength(8).Equal(x => x.Password);
        }
    }
}
