using MediatR;
using Microsoft.AspNetCore.Mvc;
using Server.Domain.Application.CQRS.Commands.CategoryCommands.CreateCategory;
using Server.Domain.Application.CQRS.Commands.CategoryCommands.DeleteCategory;
using Server.Domain.Application.CQRS.Commands.CategoryCommands.UpdateCategory;
using Server.Domain.Application.CQRS.Queries.CategoryQueries.GetAllCategoryQueries;
using Server.Domain.Application.CQRS.Queries.CategoryQueries.GetByIdCategoryQueries;
using Server.Domain.Application.CQRS.Queries.CategoryQueries.GetWhereCategoryQueries;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private IMediator mediator;

        public CategoryController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<IActionResult> GetAll(int limit)
        {
            GetAllCategoryQueryRequest request = new GetAllCategoryQueryRequest();
            request.Limit = limit;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpGet]
        [Route("getWhere")]
        public async Task<IActionResult> GetWhere(int languageId)
        {
            ;
            GetWhereCategoryQueryRequest request = new GetWhereCategoryQueryRequest();
            request.LanguageId = languageId;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }


        [HttpGet]
        [Route("getById")]
        public async Task<IActionResult> GetById(int id)
        {
            GetByIdCategoryQueryRequest request = new GetByIdCategoryQueryRequest();
            request.Id = id;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpPost]
        [Route("create")]
        //[Authorize(Roles = "admin")]
        public async Task<IActionResult> Create(CreateCategoryCommandRequest request)
        {
            ;
            var res = await mediator.Send(request);
            return new JsonResult(res);
        }



        [HttpDelete]
        [Route("delete")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            DeleteCategoryCommandRequest request = new DeleteCategoryCommandRequest();
            request.Id = id;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpPut]
        [Route("update")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(UpdateCategoryCommandRequest request)
        {
            ;
            var res = await mediator.Send(request);
            return new JsonResult(res);
        }
    }
}
