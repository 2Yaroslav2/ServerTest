using AutoMapper;
using MediatR;
using Server.Domain.Application.Dto.GoodsDTO;
using Server.Domain.Application.Interfaces.Servies;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.GoodsCommands.UpdateGoods
{
    public class UpdateGoodsCommandHandler : IRequestHandler<UpdateGoodsCommandRequest, UpdateGoodsCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public UpdateGoodsCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }
        // TO DO:
        public async Task<UpdateGoodsCommandResponse> Handle(UpdateGoodsCommandRequest request, CancellationToken cancellationToken)
        {
            var goodsUpdateDTO = mapper.Map<GoodsUpdateDTO>(request);
            var res = await serviceManagerAsync.GoodsServiceAsync.UpdateAsync(goodsUpdateDTO);
            ;
            return mapper.Map<UpdateGoodsCommandResponse>(res);
        }
    }
}
