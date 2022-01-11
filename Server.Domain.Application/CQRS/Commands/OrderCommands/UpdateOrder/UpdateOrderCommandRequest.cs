using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.OrderCommands.UpdateOrder
{
    public class UpdateOrderCommandRequest : IRequest<UpdateOrderCommandResponse>
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public int GoodsId { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool Cloce { get; set; }
    }
}
