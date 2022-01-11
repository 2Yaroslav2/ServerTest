using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Queries.OrderQueries.GetAllOrder
{
    public class GetAllOrderQueryRequest : IRequest<List<GetAllOrderQueryResponse>>
    {
        public int Limit { get; set; }
    }
}
