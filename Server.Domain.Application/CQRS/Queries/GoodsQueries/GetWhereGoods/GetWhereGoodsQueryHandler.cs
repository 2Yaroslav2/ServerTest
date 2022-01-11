using AutoMapper;
using MediatR;
using Server.Domain.Application.Dto.GoodsDTO;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Queries.GoodsQueries.GetWhereGoods
{
    public class GetWhereGoodsQueryHandler : IRequestHandler<GetWhereGoodsQueryRequest, List<GetWhereGoodsQueryResponse>>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public GetWhereGoodsQueryHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<List<GetWhereGoodsQueryResponse>> Handle(GetWhereGoodsQueryRequest request, CancellationToken cancellationToken)
        {
            var listGoods = await serviceManagerAsync.GoodsServiceAsync.GetAllAsync();

            var list = mapper.Map<List<GetWhereGoodsQueryResponse>>(listGoods);

            list.Sort((x, y) => -x.CountPurchased.CompareTo(y.CountPurchased));

            List<GetWhereGoodsQueryResponse> res = new List<GetWhereGoodsQueryResponse>();
            res.AddRange(new List<GetWhereGoodsQueryResponse> { list[0], list[1], list[2] });
           
            return res;
        }
    }
}
