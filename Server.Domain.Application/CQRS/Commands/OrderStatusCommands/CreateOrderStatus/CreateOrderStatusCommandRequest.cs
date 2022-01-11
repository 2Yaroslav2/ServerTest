using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.OrderStatusCommands.CreateOrderStatus
{
    public class CreateOrderStatusCommandRequest: IRequest<CreateOrderStatusCommandResponse>
    {
        public string Name { get; set; }
        public int LanguageId { get; set; }
    }
}
