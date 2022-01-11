using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.GoodsCommands.DeleteGoods
{
    public class DeleteGoodsCommandHandler : IRequestHandler<DeleteGoodsCommandRequest, DeleteGoodsCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public DeleteGoodsCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }
        // TO DO:
        public async Task<DeleteGoodsCommandResponse> Handle(DeleteGoodsCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.GoodsServiceAsync.DeleteAsync(request.Id);
            ;
            if (res != null)
            {
                return new DeleteGoodsCommandResponse
                {
                    Succeed = true
                };
            }
            else
            {
                return new DeleteGoodsCommandResponse
                {
                    Succeed = false
                };
            }

        }
    }
}
