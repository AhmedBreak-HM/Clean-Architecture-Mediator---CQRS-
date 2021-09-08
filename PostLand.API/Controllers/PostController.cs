using MediatR;
using Microsoft.AspNetCore.Mvc;
using PostLand.Application.Features.Posts.Commands.CreatePost;
using PostLand.Application.Features.Posts.Commands.DeletePost;
using PostLand.Application.Features.Posts.Commands.UpdatePost;
using PostLand.Application.Features.Posts.Queries.GetPostDetail;
using PostLand.Application.Features.Posts.Queries.GetPostsList;
using System;
using System.Threading.Tasks;

namespace PostLand.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPosts()
        {
            var posts = await _mediator.Send(new GetPostListQuery());
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPostById(Guid id)
        {
            var post = await _mediator.Send(new GetPostDetailQuery() { PostId = id });
            return Ok(post);

        }
        [HttpPost]
        public async Task<IActionResult> CreatePost(CreatePostCommand postCommand)
        {
            var id = await _mediator.Send(postCommand);
            return Ok(id);
        }
        [HttpPost("UpdatePost")]
        public async Task<IActionResult> UpdatePost(UpdatePostCommand postCommand)
        {
            await _mediator.Send(postCommand);
            return Ok("the post is update");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(Guid id)
        {
            var postDelete = new DeletePostCommand() { PostId = id };
            await _mediator.Send(postDelete);
            return Ok("the post is Deleted");
        }
    }
}
