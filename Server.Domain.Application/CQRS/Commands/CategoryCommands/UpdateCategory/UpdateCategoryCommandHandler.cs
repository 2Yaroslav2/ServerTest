using AutoMapper;
using MediatR;
using Server.Domain.Application.Dto.CategoryDTO;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.CategoryCommands.UpdateCategory
{
    public class UpdateCategoryCommandHandler: IRequestHandler<UpdateCategoryCommandRequest, UpdateCategoryCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public UpdateCategoryCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<UpdateCategoryCommandResponse> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.CategoryServiceAsync.UpdateAsync(mapper.Map<CategoryUpdateDTO>(request));
            return mapper.Map<UpdateCategoryCommandResponse>(res);
        }
    }
}
