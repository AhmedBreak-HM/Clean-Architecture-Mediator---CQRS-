using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;
using PostLand.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Categories.Command.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, Guid>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository,IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            CreateCategoryCommandValidator validations = new CreateCategoryCommandValidator();
            var result = await validations.ValidateAsync(request);
            if (result.Errors.Any())
            {
                 throw new Exception("Category is not valid");
            }
            var category = _mapper.Map<Category>(request);
            await _categoryRepository.AddAsync(category);
            return category.Id;
        }
    }
}
