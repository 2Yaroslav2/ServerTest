using MediatR;

namespace Server.Domain.Application.CQRS.Commands.GoodsCommands.DeleteGoods
{
    public class DeleteGoodsCommandRequest : IRequest<DeleteGoodsCommandResponse>
    {
        public int Id { get; set; }
    }
}
