using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.OrderCommands.DeleteOrder
{
    public class DeleteOrderCommandResponse
    {
        public bool Succeed { get; set; }
    }
}
