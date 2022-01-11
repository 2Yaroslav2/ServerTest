using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.OrderStatusCommands.DeleteOrderStatus
{
    public class DeleteOrderStatusCommandRequest: IRequest<DeleteOrderStatusCommandResponse>
    {
        public int Id { get; set; }
    }
}
