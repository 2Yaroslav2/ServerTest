using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Queries.CloseOrderQueries.GetByIdCloseOrder
{
    public class GetByIdCloseOrderQueryHandler : IRequestHandler<GetByIdCloseOrderQueryRequest, GetByIdCloseOrderQueryResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public GetByIdCloseOrderQueryHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<GetByIdCloseOrderQueryResponse> Handle(GetByIdCloseOrderQueryRequest request, CancellationToken cancellationToken)
        {
            var purchasedGoodsViewDTO = await serviceManagerAsync.CloseOrderServiceAsync.GetByIdAsync(request.Id);
            return mapper.Map<GetByIdCloseOrderQueryResponse>(purchasedGoodsViewDTO);
        }
    }
}
