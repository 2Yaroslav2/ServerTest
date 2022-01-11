using MediatR;
using Microsoft.AspNetCore.Mvc;
using Server.Domain.Application.CQRS.Commands.GoodsDescriptionCommands.CreateGoodsDescription;
using Server.Domain.Application.CQRS.Commands.GoodsDescriptionCommands.DeleteGoodsDescription;
using Server.Domain.Application.CQRS.Commands.GoodsDescriptionCommands.UpdateGoodsDescription;
using Server.Domain.Application.CQRS.Queries.GoodsDescriptionQueries.GetAllGoodsDescription;
using Server.Domain.Application.CQRS.Queries.GoodsDescriptionQueries.GetByIdGoodsDescription;
using Server.Domain.Application.CQRS.Queries.GoodsDescriptionQueries.GetWhereGoodsDescription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsDescriptionController : ControllerBase
    {
        private IMediator mediator;

        public GoodsDescriptionController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet]
        [Route("getAll")]
        public async Task<IActionResult> GetAll(int limit)
        {
            ;
            GetAllGoodsDescriptionQueryRequest request = new GetAllGoodsDescriptionQueryRequest();
            request.Limit = limit;

            var res = await mediator.Send(request);
            ;
            return new JsonResult(res);
        }

        [HttpGet]
        [Route("getById")]
        public async Task<IActionResult> GetById(int id)
        {
            GetByIdGoodsDescriptionQueryRequest request = new GetByIdGoodsDescriptionQueryRequest();
            request.Id = id;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpGet]
        [Route("getWhere")]
        public async Task<IActionResult> GetWhere(int goodsId, int languageId)
        {
            GetWhereGoodsDescriptionQueryRequest request = new GetWhereGoodsDescriptionQueryRequest();
            request.GoodsId = goodsId;
            request.LanguageId = languageId;

            var res = await mediator.Send(request);
            ;
            return new JsonResult(res.Value);
        }

        [HttpPost]
        [Route("create")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(CreateGoodsDescriptionCommandRequest request)
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
            DeleteGoodsDescriptionCommandRequest request = new DeleteGoodsDescriptionCommandRequest();
            request.Id = id;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpPut]
        [Route("update")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(UpdateGoodsDescriptionCommandRequest request)
        {
            ;
            var res = await mediator.Send(request);
            return new JsonResult(res);
        }
    }
}
