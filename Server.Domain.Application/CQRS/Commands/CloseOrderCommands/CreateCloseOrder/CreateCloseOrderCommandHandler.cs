using AutoMapper;
using MediatR;
using Server.Domain.Application.Dto.CloseOrderDTO;
using Server.Domain.Application.Interfaces.Servies;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.CloseOrderCommands.CreateCloseOrder
{
    public class CreateCloseOrderCommandHandler : IRequestHandler<CreateCloseOrderCommandRequest, CreateCloseOrderCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public CreateCloseOrderCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<CreateCloseOrderCommandResponse> Handle(CreateCloseOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var closeOrderCreateDTO = mapper.Map<CloseOrderCreateDTO>(request);
            var res = serviceManagerAsync.CloseOrderServiceAsync.CreateAsync(closeOrderCreateDTO);

            return mapper.Map<CreateCloseOrderCommandResponse>(res);
        }
    }
}
