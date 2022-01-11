using MediatR;
using Microsoft.AspNetCore.Mvc;
using Server.Domain.Application.CQRS.Commands.GoodsCommands.CreateGoods;
using Server.Domain.Application.CQRS.Commands.GoodsCommands.DeleteGoods;
using Server.Domain.Application.CQRS.Commands.GoodsCommands.UpdateGoods;
using Server.Domain.Application.CQRS.Queries.GoodsQueries.GetAllGoods;
using Server.Domain.Application.CQRS.Queries.GoodsQueries.GetByIdGoods;
using Server.Domain.Application.CQRS.Queries.GoodsQueries.GetWhereGoods;
using System.Threading.Tasks;

namespace Server.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        private IMediator mediator;

        public GoodsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<IActionResult> GetAll(int limit)
        {
            GetAllGoodsQueryRequest request = new GetAllGoodsQueryRequest();
            request.Limit = limit;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpGet]
        [Route("getById")]
        public async Task<IActionResult> GetById(int id)
        {
            GetByIdGoodsQueryRequest request = new GetByIdGoodsQueryRequest();
            request.Id = id;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpGet]
        [Route("getWhere")]
        public async Task<IActionResult> GetWhere(int limit)
        {
            ;
            GetWhereGoodsQueryRequest request = new GetWhereGoodsQueryRequest();
            request.Limit = limit;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpPost]
        [Route("create")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(CreateGoodsCommandRequest request)
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
            DeleteGoodsCommandRequest request = new DeleteGoodsCommandRequest();
            request.Id = id;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpPut]
        [Route("update")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(UpdateGoodsCommandRequest request)
        {
            ;
            var res = await mediator.Send(request);
            return new JsonResult(res);
        }
    }
}
