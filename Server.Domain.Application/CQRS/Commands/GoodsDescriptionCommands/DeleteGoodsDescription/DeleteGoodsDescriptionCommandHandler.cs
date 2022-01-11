using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.GoodsDescriptionCommands.DeleteGoodsDescription
{
    public class DeleteGoodsDescriptionCommandHandler : IRequestHandler<DeleteGoodsDescriptionCommandRequest, DeleteGoodsDescriptionCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public DeleteGoodsDescriptionCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<DeleteGoodsDescriptionCommandResponse> Handle(DeleteGoodsDescriptionCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.GoodsDescriptionServiceAsync.DeleteAsync(request.Id);
            if (res != null)
            {
                return new DeleteGoodsDescriptionCommandResponse
                {
                    Succeed = true
                };
            }
            else
            {
                return new DeleteGoodsDescriptionCommandResponse
                {
                    Succeed = false
                };
            }
        }
    }
}
