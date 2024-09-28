using CleanArchi.Application.Commands;
using CleanArchi.Application.Queries;
using CleanArchi.Core.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController(ISender mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddCategory ([FromBody] CategoryDto categoryDto)
        {
            var res  = await mediator.Send(new AddCategoryCommand(categoryDto));
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = await mediator.Send(new GetAllCategoriesQuery());
            return Ok(res);
        }

        [HttpGet("External")]
        public async Task<IActionResult> GetCoins()
        {
            var res = await mediator.Send(new GetExternalApi());
            return Ok(res);
        }
    }
}
