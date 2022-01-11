using AutoMapper;
using MediatR;
using Server.Domain.Application.Dto.OrderDTO;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.OrderCommands.UpdateOrder
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommandRequest, UpdateOrderCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public UpdateOrderCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<UpdateOrderCommandResponse> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var orderUpdateDTO = mapper.Map<OrderUpdateDTO>(request);
            var res = await serviceManagerAsync.OrderServiceAsync.UpdateAsync(orderUpdateDTO);

            return mapper.Map<UpdateOrderCommandResponse>(res);
        }
    }
}
