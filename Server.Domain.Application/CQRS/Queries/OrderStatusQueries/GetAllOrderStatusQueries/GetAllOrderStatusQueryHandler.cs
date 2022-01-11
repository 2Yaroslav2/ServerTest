using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Queries.OrderStatusQueries.GetAllOrderStatusQueries
{
    public class GetAllOrderStatusQueryHandler : IRequestHandler<GetAllOrderStatusQueryRequest, List<GetAllOrderStatusQueryResponse>>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public GetAllOrderStatusQueryHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<List<GetAllOrderStatusQueryResponse>> Handle(GetAllOrderStatusQueryRequest request, CancellationToken cancellationToken)
        {
            var orderStatus = await serviceManagerAsync.OrderStatusServiceAsync.GetAllAsync();
            return mapper.Map<List<GetAllOrderStatusQueryResponse>>(orderStatus);
        }
    }
}
