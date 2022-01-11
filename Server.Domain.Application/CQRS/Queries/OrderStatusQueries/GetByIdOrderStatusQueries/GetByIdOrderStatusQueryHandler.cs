using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Queries.OrderStatusQueries.GetByIdOrderStatusQueries
{
    public class GetByIdOrderStatusQueryHandler : IRequestHandler<GetByIdOrderStatusQueryRequest, GetByIdOrderStatusQueryResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public GetByIdOrderStatusQueryHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<GetByIdOrderStatusQueryResponse> Handle(GetByIdOrderStatusQueryRequest request, CancellationToken cancellationToken)
        {
            var orderStatus = await serviceManagerAsync.OrderStatusServiceAsync.GetByIdAsync(request.Id);
            return mapper.Map<GetByIdOrderStatusQueryResponse>(orderStatus);
        }
    }
}
