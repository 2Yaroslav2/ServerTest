using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Queries.CategoryQueries.GetWhereCategoryQueries
{
    public class GetWhereCategoryQueryHandler : IRequestHandler<GetWhereCategoryQueryRequest, List<GetWhereCategoryQueryResponse>>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public GetWhereCategoryQueryHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<List<GetWhereCategoryQueryResponse>> Handle(GetWhereCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.CategoryServiceAsync.GetWhereAsync(request.LanguageId);
            return mapper.Map<List<GetWhereCategoryQueryResponse>>(res);
        }
    }
}
