using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Queries.CategoryQueries.GetWhereCategoryQueries
{
    public class GetWhereCategoryQueryRequest : IRequest<List<GetWhereCategoryQueryResponse>>
    {
        public int LanguageId { get; set; }
    }
}
