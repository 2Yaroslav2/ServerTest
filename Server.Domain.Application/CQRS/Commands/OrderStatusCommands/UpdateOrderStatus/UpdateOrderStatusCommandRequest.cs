using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.OrderStatusCommands.UpdateOrderStatus
{
    public class UpdateOrderStatusCommandRequest: IRequest<UpdateOrderStatusCommandResponse>
    {
        public string Name { get; set; }
        public int LanguageId { get; set; }
    }
}
