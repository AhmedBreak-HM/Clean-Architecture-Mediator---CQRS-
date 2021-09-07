using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Commands.CreatePost
{
   public class CreatePostCommandValidator:AbstractValidator<CreatePostCommand>
    {
        public CreatePostCommandValidator()
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
