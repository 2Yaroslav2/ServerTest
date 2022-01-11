using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Queries.CloseOrderQueries.GetAllCloseOrder
{
    public class GetAllCloseOrderQueryRequest : IRequest<List<GetAllCloseOrderQueryResponse>>
    {
        public int Limit { get; set; }
    }
}
