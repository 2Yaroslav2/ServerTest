using AutoMapper;
using MediatR;
using Server.Domain.Application.Dto.GoodsDescriptionDTO;
using Server.Domain.Application.Interfaces.Servies;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.GoodsDescriptionCommands.UpdateGoodsDescription
{
    public class UpdateGoodsDescriptionCommandHandler : IRequestHandler<UpdateGoodsDescriptionCommandRequest, UpdateGoodsDescriptionCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public UpdateGoodsDescriptionCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<UpdateGoodsDescriptionCommandResponse> Handle(UpdateGoodsDescriptionCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.GoodsDescriptionServiceAsync.UpdateAsync(mapper.Map<GoodsDescriptionUpdateDTO>(request));
            return mapper.Map<UpdateGoodsDescriptionCommandResponse>(res);
        }
    }
}
