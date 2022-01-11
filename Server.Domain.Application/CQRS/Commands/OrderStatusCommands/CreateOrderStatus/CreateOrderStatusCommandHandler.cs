using AutoMapper;
using MediatR;
using Server.Domain.Application.Dto.OrderStatusDTO;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.OrderStatusCommands.CreateOrderStatus
{
    public class CreateOrderStatusCommandHandler: IRequestHandler<CreateOrderStatusCommandRequest, CreateOrderStatusCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public CreateOrderStatusCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<CreateOrderStatusCommandResponse> Handle(CreateOrderStatusCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.OrderStatusServiceAsync.CreateAsync(mapper.Map<OrderStatusCreateDTO>(request));
            return mapper.Map<CreateOrderStatusCommandResponse>(res);
        }
    }
}
