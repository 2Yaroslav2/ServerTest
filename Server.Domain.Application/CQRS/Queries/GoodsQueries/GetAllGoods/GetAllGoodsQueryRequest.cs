using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Queries.GoodsQueries.GetAllGoods
{
    public class GetAllGoodsQueryRequest : IRequest<List<GetAllGoodsQueryResponse>>
    {
        public int Limit { get; set; }
    }
}
