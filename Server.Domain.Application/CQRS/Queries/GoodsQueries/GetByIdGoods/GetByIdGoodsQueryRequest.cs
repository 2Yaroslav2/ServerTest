using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Queries.GoodsQueries.GetByIdGoods
{
    public class GetByIdGoodsQueryRequest : IRequest<GetByIdGoodsQueryResponse>
    {
        public int Id { get; set; }
    }
}
