using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Queries.GoodsDescriptionQueries.GetByIdGoodsDescription
{
    public class GetByIdGoodsDescriptionQueryHandler : IRequestHandler<GetByIdGoodsDescriptionQueryRequest, GetByIdGoodsDescriptionQueryResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public GetByIdGoodsDescriptionQueryHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<GetByIdGoodsDescriptionQueryResponse> Handle(GetByIdGoodsDescriptionQueryRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.GoodsDescriptionServiceAsync.GetByIdAsync(request.Id);
            return mapper.Map<GetByIdGoodsDescriptionQueryResponse>(res);
        }
    }
}
