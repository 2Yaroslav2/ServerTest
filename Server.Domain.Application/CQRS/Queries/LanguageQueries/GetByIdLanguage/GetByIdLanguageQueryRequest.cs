using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Queries.LanguageQueries.GetByIdLanguage
{
    public class GetByIdLanguageQueryRequest: IRequest<GetByIdLanguageQueryResponse>
    {
        public int Id { get; set; }
    }
}
