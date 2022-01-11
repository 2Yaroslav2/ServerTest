using MediatR;
using Microsoft.AspNetCore.Mvc;
using Server.Domain.Application.CQRS.Commands.OrderCommands.CreateOrder;
using Server.Domain.Application.CQRS.Commands.OrderCommands.DeleteOrder;
using Server.Domain.Application.CQRS.Commands.OrderCommands.UpdateOrder;
using Server.Domain.Application.CQRS.Queries.OrderQueries.GetAllOrder;
using Server.Domain.Application.CQRS.Queries.OrderQueries.GetByIdOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    // TO DO: 
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IMediator mediator;

        public OrderController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<IActionResult> GetAll(int limit)
        {
            GetAllOrderQueryRequest request = new GetAllOrderQueryRequest();
            request.Limit = limit;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpGet]
        [Route("getById")]
        public async Task<IActionResult> GetById(int id)
        {
            GetByIdOrderQueryRequest request = new GetByIdOrderQueryRequest();
            request.Id = id;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpPost]
        [Route("create")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(CreateOrderCommandRequest request)
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
            DeleteOrderCommandRequest request = new DeleteOrderCommandRequest();
            request.Id = id;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpPut]
        [Route("update")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(UpdateOrderCommandRequest request)
        {
            ;
            var res = await mediator.Send(request);
            return new JsonResult(res);
        }
    }
}
