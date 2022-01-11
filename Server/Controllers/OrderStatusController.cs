using MediatR;
using Microsoft.AspNetCore.Mvc;
using Server.Domain.Application.CQRS.Commands.OrderStatusCommands.CreateOrderStatus;
using Server.Domain.Application.CQRS.Commands.OrderStatusCommands.DeleteOrderStatus;
using Server.Domain.Application.CQRS.Commands.OrderStatusCommands.UpdateOrderStatus;
using Server.Domain.Application.CQRS.Queries.OrderStatusQueries.GetAllOrderStatusQueries;
using Server.Domain.Application.CQRS.Queries.OrderStatusQueries.GetByIdOrderStatusQueries;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderStatusController : ControllerBase
    {
        private IMediator mediator;

        public OrderStatusController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<IActionResult> GetAll(int limit)
        {
            GetAllOrderStatusQueryRequest request = new GetAllOrderStatusQueryRequest();
            request.Limit = limit;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpGet]
        [Route("getById")]
        public async Task<IActionResult> GetById(int id)
        {
            GetByIdOrderStatusQueryRequest request = new GetByIdOrderStatusQueryRequest();
            request.Id = id;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpPost]
        [Route("create")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(CreateOrderStatusCommandRequest request)
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
            DeleteOrderStatusCommandRequest request = new DeleteOrderStatusCommandRequest();
            request.Id = id;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpPut]
        [Route("update")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(UpdateOrderStatusCommandRequest request)
        {
            ;
            var res = await mediator.Send(request);
            return new JsonResult(res);
        }
    }
}
