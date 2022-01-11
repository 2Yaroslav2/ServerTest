using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Queries.CategoryQueries.GetAllCategoryQueries
{
    public class GetAllCategoryQueryRequest: IRequest<List<GetAllCategoryQueryResponse>>
    {
        public int Limit { get; set; }
    }
}
