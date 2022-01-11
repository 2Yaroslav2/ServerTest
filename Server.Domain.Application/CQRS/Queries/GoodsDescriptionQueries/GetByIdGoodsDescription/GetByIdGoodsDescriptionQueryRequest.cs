using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Queries.GoodsDescriptionQueries.GetByIdGoodsDescription
{
    public class GetByIdGoodsDescriptionQueryRequest : IRequest<GetByIdGoodsDescriptionQueryResponse>
    {
        public int Id { get; set; }
    }
}
