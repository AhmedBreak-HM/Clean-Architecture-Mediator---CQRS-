using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Commands.UpdatePost
{
    public class UpdatePostCommandValidator : AbstractValidator<UpdatePostCommand>
    {
        public UpdatePostCommandValidator()
        {
            RuleFor(p => p.Tital)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);
            RuleFor(p => p.Content)
                .NotEmpty()
                .NotNull();
        }
    }
}
