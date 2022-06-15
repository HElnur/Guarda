using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guarda.Business.DTOs.Comment
{
    public class CommentPostDto
    {
        public string Text { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public bool Status { get; set; }
        public int Rate { get; set; }
    }

    public class CommentPostDtoValidator : AbstractValidator<CommentPostDto>
    {
        public CommentPostDtoValidator()
        {
            RuleFor(x => x.Text)
                .NotEmpty();

            RuleFor(x => x.Rate)
                .GreaterThanOrEqualTo(1)
                .LessThanOrEqualTo(5);
        }
    }
}
