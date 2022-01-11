using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Queries.CloseOrderQueries.GetAllCloseOrder
{
    public class GetAllCLoseOrderQueryHandler : IRequestHandler<GetAllCloseOrderQueryRequest, List<GetAllCloseOrderQueryResponse>>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public GetAllCLoseOrderQueryHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<List<GetAllCloseOrderQueryResponse>> Handle(GetAllCloseOrderQueryRequest request, CancellationToken cancellationToken)
        {
            var closeOrderViewDTO = await serviceManagerAsync.CloseOrderServiceAsync.GetAllAsync();
            return mapper.Map<List<GetAllCloseOrderQueryResponse>>(closeOrderViewDTO);
        }
    }
}
