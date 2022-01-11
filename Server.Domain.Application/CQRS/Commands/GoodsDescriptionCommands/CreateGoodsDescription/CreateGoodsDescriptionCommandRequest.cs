using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.GoodsDescriptionCommands.CreateGoodsDescription
{
    public class CreateGoodsDescriptionCommandRequest : IRequest<CreateGoodsDescriptionCommandResponse>
    {
        public int GoodsId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }
    }
}
