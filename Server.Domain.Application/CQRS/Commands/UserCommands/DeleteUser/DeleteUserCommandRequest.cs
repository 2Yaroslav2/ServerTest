using MediatR;

namespace Server.Domain.Application.CQRS.Commands.UserCommands.DeleteUser
{
    public class DeleteUserCommandRequest : IRequest<DeleteUserCommandResponse>
    {
        public string Id { get; set; }
    }
}
