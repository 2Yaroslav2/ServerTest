using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Queries.LanguageQueries.GetByIdLanguage
{
    public class GetByIdLanguageQueryHandler : IRequestHandler<GetByIdLanguageQueryRequest, GetByIdLanguageQueryResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public GetByIdLanguageQueryHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<GetByIdLanguageQueryResponse> Handle(GetByIdLanguageQueryRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.LanguageServiceAsync.GetByIdAsync(request.Id);
            return mapper.Map<GetByIdLanguageQueryResponse>(res);
        }
    }
}
