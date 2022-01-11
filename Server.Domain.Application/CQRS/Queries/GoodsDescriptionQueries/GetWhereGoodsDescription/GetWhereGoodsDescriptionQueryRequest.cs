using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Queries.GoodsDescriptionQueries.GetWhereGoodsDescription
{
    public class GetWhereGoodsDescriptionQueryRequest : IRequest<GetWhereGoodsDescriptionQueryResponse>
    {
        public int GoodsId { get; set; }
        public int LanguageId { get; set; }
    }
}
