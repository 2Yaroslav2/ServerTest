using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.OrderStatusCommands.DeleteOrderStatus
{
    public class DeleteOrderStatusCommandHandler : IRequestHandler<DeleteOrderStatusCommandRequest, DeleteOrderStatusCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;

        public DeleteOrderStatusCommandHandler(IServiceManagerAsync serviceManagerAsync)
        {
            this.serviceManagerAsync = serviceManagerAsync;
        }

        public async Task<DeleteOrderStatusCommandResponse> Handle(DeleteOrderStatusCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.OrderStatusServiceAsync.DeleteAsync(request.Id);
            if (res != null)
            {
                return new DeleteOrderStatusCommandResponse
                {
                    Succeed = true
                };
            }
            else
            {
                return new DeleteOrderStatusCommandResponse
                {
                    Succeed = false
                };
            }
        }
    }
}
