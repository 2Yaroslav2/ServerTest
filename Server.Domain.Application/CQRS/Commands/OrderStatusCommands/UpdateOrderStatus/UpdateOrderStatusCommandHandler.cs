using AutoMapper;
using MediatR;
using Server.Domain.Application.Dto.OrderStatusDTO;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.OrderStatusCommands.UpdateOrderStatus
{
    public class UpdateOrderStatusCommandHandler: IRequestHandler<UpdateOrderStatusCommandRequest, UpdateOrderStatusCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public UpdateOrderStatusCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<UpdateOrderStatusCommandResponse> Handle(UpdateOrderStatusCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.OrderStatusServiceAsync.UpdateAsync(mapper.Map<OrderStatusUpdateDTO>(request));
            return mapper.Map<UpdateOrderStatusCommandResponse>(res);
        }
    }
}
