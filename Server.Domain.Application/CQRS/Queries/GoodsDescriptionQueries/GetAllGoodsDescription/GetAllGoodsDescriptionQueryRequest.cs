using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Queries.GoodsDescriptionQueries.GetAllGoodsDescription
{
    public class GetAllGoodsDescriptionQueryRequest : IRequest<List<GetAllGoodsDescriptionQueryResponse>>
    {
        public int Limit { get; set; }
    }
}
