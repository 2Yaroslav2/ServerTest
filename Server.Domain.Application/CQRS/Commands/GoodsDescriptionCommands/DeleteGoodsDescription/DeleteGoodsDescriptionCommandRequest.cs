using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.GoodsDescriptionCommands.DeleteGoodsDescription
{
    public class DeleteGoodsDescriptionCommandRequest : IRequest<DeleteGoodsDescriptionCommandResponse>
    {
        public int Id { get; set; }
    }
}
