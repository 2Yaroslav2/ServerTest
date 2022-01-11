using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Queries.OrderStatusQueries.GetByIdOrderStatusQueries
{
    public class GetByIdOrderStatusQueryRequest: IRequest<GetByIdOrderStatusQueryResponse>
    {
        public int Id { get; set; }
    }
}
