using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.UserCommands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommandRequest, DeleteUserCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public DeleteUserCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<DeleteUserCommandResponse> Handle(DeleteUserCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.UserServiceAsync.DeleteAsync(request.Id);
            ;
            if (res.Succeeded)
            {
                return new DeleteUserCommandResponse
                {
                    Succeed = true
                };
            }
            else
            {
                return new DeleteUserCommandResponse
                {
                    Succeed = false
                };
            }
        }
    }
}
