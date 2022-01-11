using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Queries.GoodsDescriptionQueries.GetWhereGoodsDescription
{
    public class GetWhereGoodsDescriptionQueryHandler : IRequestHandler<GetWhereGoodsDescriptionQueryRequest, GetWhereGoodsDescriptionQueryResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public GetWhereGoodsDescriptionQueryHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<GetWhereGoodsDescriptionQueryResponse> Handle(GetWhereGoodsDescriptionQueryRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.GoodsDescriptionServiceAsync.GetWhereAsync(request.GoodsId, request.LanguageId);
            if (res != null)
            {
                return new GetWhereGoodsDescriptionQueryResponse { Value = res.Description };
            }
            else
            {
                return new GetWhereGoodsDescriptionQueryResponse { Value = "No description found for current products" };
            }
        }
    }
}
