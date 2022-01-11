using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Queries.CloseOrderQueries.GetByIdCloseOrder
{
    public class GetByIdCloseOrderQueryRequest : IRequest<GetByIdCloseOrderQueryResponse>
    {
        public int Id { get; set; }
    }
}
