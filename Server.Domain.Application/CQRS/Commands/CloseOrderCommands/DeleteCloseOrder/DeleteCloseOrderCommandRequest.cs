using MediatR;

namespace Server.Domain.Application.CQRS.Commands.CloseOrderCommands.DeleteCloseOrder
{
    public class DeleteCloseOrderCommandRequest : IRequest<DeleteCloseOrderCommandResponse>
    {
        public int Id { get; set; }
    }
}
