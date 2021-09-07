using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;
using PostLand.Domain;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Commands.UpdatePost
{
    public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public UpdatePostCommandHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            UpdatePostCommandValidator validations = new UpdatePostCommandValidator();
            var result = await validations.ValidateAsync(request);
            if (result.Errors.Any())
            {
                throw new Exception("post is not Valid");
            }
            var postForUpdate = _mapper.Map<Post>(request);
            await _postRepository.UpdateAsync(postForUpdate);
            return Unit.Value;

        }
    }
}
