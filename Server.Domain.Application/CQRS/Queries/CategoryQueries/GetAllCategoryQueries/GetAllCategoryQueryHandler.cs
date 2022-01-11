using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Queries.CategoryQueries.GetAllCategoryQueries
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQueryRequest, List<GetAllCategoryQueryResponse>>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public GetAllCategoryQueryHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<List<GetAllCategoryQueryResponse>> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var categories = await serviceManagerAsync.CategoryServiceAsync.GetAllAsync();
            return mapper.Map<List<GetAllCategoryQueryResponse>>(categories);
        }
    }
}
