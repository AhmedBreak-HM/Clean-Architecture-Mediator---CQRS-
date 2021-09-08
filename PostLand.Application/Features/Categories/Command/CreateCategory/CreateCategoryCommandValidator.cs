using FluentValidation;

namespace PostLand.Application.Features.Categories.Command.CreateCategory
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(c => c.Id).NotEmpty().NotNull();
            RuleFor(c => c.Name).NotEmpty().NotNull().MaximumLength(100);
        }
    }
}
