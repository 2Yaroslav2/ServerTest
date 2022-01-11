using AutoMapper;
using MediatR;
using Server.Domain.Application.Dto.CloseOrderDTO;
using Server.Domain.Application.Interfaces.Servies;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.CloseOrderCommands.UpdateCloseOrder
{
    public class UpdateCloseOrderCommandHandler : IRequestHandler<UpdateCloseOrderCommandRequest, UpdateCloseOrderCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public UpdateCloseOrderCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<UpdateCloseOrderCommandResponse> Handle(UpdateCloseOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var closeOrderUpdateDTO = mapper.Map<CloseOrderUpdateDTO>(request);
            var res = await serviceManagerAsync.CloseOrderServiceAsync.UpdateAsync(closeOrderUpdateDTO);


            return mapper.Map<UpdateCloseOrderCommandResponse>(res);
        }
    }
}
