using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Queries.LanguageQueries.GetAllLanguage
{
    public class GetAllLanguageQueryHandler : IRequestHandler<GetAllLanguageQueryRequest, List<GetAllLanguageQueryResponse>>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public GetAllLanguageQueryHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<List<GetAllLanguageQueryResponse>> Handle(GetAllLanguageQueryRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.LanguageServiceAsync.GetAllAsync();
            return mapper.Map<List<GetAllLanguageQueryResponse>>(res);
        }
    }
}
