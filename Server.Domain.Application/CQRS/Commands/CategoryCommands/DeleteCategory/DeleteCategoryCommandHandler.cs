using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.CategoryCommands.DeleteCategory
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest, DeleteCategoryCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public DeleteCategoryCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<DeleteCategoryCommandResponse> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {

            var res = await serviceManagerAsync.CategoryServiceAsync.DeleteAsync(request.Id);
            if (res != null)
            {
                return new DeleteCategoryCommandResponse
                {
                    Succeed = true
                };
            }
            else
            {
                return new DeleteCategoryCommandResponse
                {
                    Succeed = false
                };
            }
        }
    }
}
