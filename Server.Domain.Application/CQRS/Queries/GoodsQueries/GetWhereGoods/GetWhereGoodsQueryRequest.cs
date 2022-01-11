using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Queries.GoodsQueries.GetWhereGoods
{
    public class GetWhereGoodsQueryRequest : IRequest<List<GetWhereGoodsQueryResponse>>
    {
       public int Limit { get; set; }
    }
}
