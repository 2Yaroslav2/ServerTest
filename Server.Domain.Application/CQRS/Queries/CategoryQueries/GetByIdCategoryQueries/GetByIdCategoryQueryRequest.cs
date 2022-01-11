using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Queries.CategoryQueries.GetByIdCategoryQueries
{
    public class GetByIdCategoryQueryRequest: IRequest<GetByIdCategoryQueryResponse>
    {
        public int Id { get; set; }
    }
}
