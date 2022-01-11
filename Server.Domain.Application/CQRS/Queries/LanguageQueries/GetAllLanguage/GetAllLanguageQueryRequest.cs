using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Queries.LanguageQueries.GetAllLanguage
{
    public class GetAllLanguageQueryRequest : IRequest<List<GetAllLanguageQueryResponse>>
    {
        public int Limit { get; set; }
    }
}
