using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Queries.GoodsDescriptionQueries.GetAllGoodsDescription
{
    public class GetAllGoodsDescriptionQueryHandler : IRequestHandler<GetAllGoodsDescriptionQueryRequest, List<GetAllGoodsDescriptionQueryResponse>>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public GetAllGoodsDescriptionQueryHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<List<GetAllGoodsDescriptionQueryResponse>> Handle(GetAllGoodsDescriptionQueryRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.GoodsDescriptionServiceAsync.GetAllAsync();
            return mapper.Map<List<GetAllGoodsDescriptionQueryResponse>>(res);
        }
    }
}
