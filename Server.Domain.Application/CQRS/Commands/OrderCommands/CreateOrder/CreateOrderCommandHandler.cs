using AutoMapper;
using MediatR;
using Server.Domain.Application.Dto.OrderDTO;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.OrderCommands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public CreateOrderCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var orderCreateDTO = mapper.Map<OrderCreateDTO>(request);
            var res = await serviceManagerAsync.OrderServiceAsync.CreateAsync(orderCreateDTO);

            return mapper.Map<CreateOrderCommandResponse>(res);
        }
    }
}
