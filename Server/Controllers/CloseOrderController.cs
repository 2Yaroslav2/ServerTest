using MediatR;
using Microsoft.AspNetCore.Mvc;
using Server.Domain.Application.CQRS.Commands.CloseOrderCommands.CreateCloseOrder;
using Server.Domain.Application.CQRS.Commands.CloseOrderCommands.DeleteCloseOrder;
using Server.Domain.Application.CQRS.Commands.CloseOrderCommands.UpdateCloseOrder;
using Server.Domain.Application.CQRS.Queries.CloseOrderQueries.GetAllCloseOrder;
using Server.Domain.Application.CQRS.Queries.CloseOrderQueries.GetByIdCloseOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CloseOrderController : ControllerBase
    {
        private IMediator mediator;

        public CloseOrderController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<IActionResult> GetAll(int limit)
        {
            GetAllCloseOrderQueryRequest request = new GetAllCloseOrderQueryRequest();
            request.Limit = limit;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpGet]
        [Route("getById")]
        public async Task<IActionResult> GetById(int id)
        {
            GetByIdCloseOrderQueryRequest request = new GetByIdCloseOrderQueryRequest();
            request.Id = id;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create(CreateCloseOrderCommandRequest request)
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
            DeleteCloseOrderCommandRequest request = new DeleteCloseOrderCommandRequest();
            request.Id = id;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpPut]
        [Route("update")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(UpdateCloseOrderCommandRequest request)
        {
            ;
            var res = await mediator.Send(request);
            return new JsonResult(res);
        }
    }
}
