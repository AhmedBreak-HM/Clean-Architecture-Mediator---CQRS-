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

namespace PostLand.Application.Features.Posts.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, Guid>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public CreatePostCommandHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            CreatePostCommandValidator validations = new CreatePostCommandValidator();
            var result = await validations.ValidateAsync(request);
            if (result.Errors.Any())
            {
                throw new Exception("post is not Valid");
            }
            var postForCreate = _mapper.Map<Post>(request);

            var postCreated = await _postRepository.AddAsync(postForCreate);
            return postCreated.Id;
        }
    }
}
