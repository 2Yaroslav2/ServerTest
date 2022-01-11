using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Queries.OrderStatusQueries.GetAllOrderStatusQueries
{
    public class GetAllOrderStatusQueryRequest: IRequest<List<GetAllOrderStatusQueryResponse>>
    {
        public int Limit { get; set; }
    }
}
