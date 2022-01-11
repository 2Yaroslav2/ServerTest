using AutoMapper;
using MediatR;
using Server.Domain.Application.Dto.GoodsDescriptionDTO;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.GoodsDescriptionCommands.CreateGoodsDescription
{
    public class CreateGoodsDescriptionCommandHandler : IRequestHandler<CreateGoodsDescriptionCommandRequest, CreateGoodsDescriptionCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public CreateGoodsDescriptionCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<CreateGoodsDescriptionCommandResponse> Handle(CreateGoodsDescriptionCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.GoodsDescriptionServiceAsync.CreateAsync(mapper.Map<GoodsDescriptionCreateDTO>(request));
            return mapper.Map<CreateGoodsDescriptionCommandResponse>(res);
        }
    }
}
