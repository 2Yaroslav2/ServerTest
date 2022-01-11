using AutoMapper;
using MediatR;
using Server.Domain.Application.Dto.UserDTO;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdateLogin
{
    public class UpdateLoginCommandHandler : IRequestHandler<UpdateLoginCommandRequest, UpdateLoginCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public UpdateLoginCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<UpdateLoginCommandResponse> Handle(UpdateLoginCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.UserServiceAsync.UpdateLoginAsync(mapper.Map<UserUpdateLoginDTO>(request));
            if (res.Succeeded)
            {
                return new UpdateLoginCommandResponse
                {
                    Error = false,
                    Result = new Microsoft.AspNetCore.Mvc.JsonResult(request)
                };
            }
            else
            {
                return new UpdateLoginCommandResponse
                {
                    Error = true,
                    Result = new Microsoft.AspNetCore.Mvc.JsonResult(res.Errors.ToList())
                };
            }
        }
    }
}
