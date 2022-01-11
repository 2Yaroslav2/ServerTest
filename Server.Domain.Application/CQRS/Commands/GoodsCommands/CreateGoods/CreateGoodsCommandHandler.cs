using AutoMapper;
using MediatR;
using Server.Domain.Application.Dto.GoodsDTO;
using Server.Domain.Application.Interfaces.Servies;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.GoodsCommands.CreateGoods
{
    public class CreateGoodsCommandHandler : IRequestHandler<CreateGoodsCommandRequest, CreateGoodsCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;
        public CreateGoodsCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }
        // TO DO:
        public async Task<CreateGoodsCommandResponse> Handle(CreateGoodsCommandRequest request, CancellationToken cancellationToken)
        {
            ;
            var goodsCreateDTO = mapper.Map<GoodsCreateDTO>(request);
            ;
            var res = await serviceManagerAsync.GoodsServiceAsync.CreateAsync(goodsCreateDTO);
            ;
            return mapper.Map<CreateGoodsCommandResponse>(res);
        }
    }
}
