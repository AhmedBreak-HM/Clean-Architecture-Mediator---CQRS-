using MediatR;
using Microsoft.AspNetCore.Mvc;
using PostLand.Application.Features.Categories.Command.CreateCategory;
using System.Threading.Tasks;

namespace PostLand.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //[HttpGet]
        //public async Task<IActionResult> GetAllCategory()
        //{

        //}
        [HttpPost]
        public async Task<IActionResult> CreateCategory (CreateCategoryCommand createCategoryCommand)
        {
            var id = await _mediator.Send(createCategoryCommand);
            return Ok(id);
        }
    }
}
