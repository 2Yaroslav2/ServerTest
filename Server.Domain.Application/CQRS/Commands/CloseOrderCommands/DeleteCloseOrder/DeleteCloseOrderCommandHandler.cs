using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.CloseOrderCommands.DeleteCloseOrder
{
    public class DeleteCloseOrderCommandHandler : IRequestHandler<DeleteCloseOrderCommandRequest, DeleteCloseOrderCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public DeleteCloseOrderCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<DeleteCloseOrderCommandResponse> Handle(DeleteCloseOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.CloseOrderServiceAsync.DeleteAsync(request.Id);
            ;
            if (res != null)
            {
                return new DeleteCloseOrderCommandResponse
                {
                    Succeed = true
                };
            }
            else
            {
                return new DeleteCloseOrderCommandResponse
                {
                    Succeed = false
                };
            }
        }
    }
}
