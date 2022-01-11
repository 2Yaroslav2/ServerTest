using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Queries.GoodsQueries.GetAllGoods
{
    public class GetAllGoodsQueryHandler : IRequestHandler<GetAllGoodsQueryRequest, List<GetAllGoodsQueryResponse>>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;
        public GetAllGoodsQueryHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<List<GetAllGoodsQueryResponse>> Handle(GetAllGoodsQueryRequest request, CancellationToken cancellationToken)
        {
            var goodsViewDTO = await serviceManagerAsync.GoodsServiceAsync.GetAllAsync();
            ;
            return mapper.Map<List<GetAllGoodsQueryResponse>>(goodsViewDTO);
        }
    }
}
