using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.GoodsDescriptionCommands.UpdateGoodsDescription
{
    public class UpdateGoodsDescriptionCommandRequest : IRequest<UpdateGoodsDescriptionCommandResponse>
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }
    }
}
