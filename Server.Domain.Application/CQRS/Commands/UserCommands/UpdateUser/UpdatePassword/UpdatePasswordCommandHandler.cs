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

namespace Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdatePassword
{
    public class UpdatePasswordCommandHandler : IRequestHandler<UpdatePasswordCommandRequest, UpdatePasswordCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public UpdatePasswordCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<UpdatePasswordCommandResponse> Handle(UpdatePasswordCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.UserServiceAsync.ChangePasswordAsync(mapper.Map<UserUpdatePasswordDTO>(request));
            if (res.Succeeded)
            {
                return new UpdatePasswordCommandResponse {
                    Error = false,
                    Result = new Microsoft.AspNetCore.Mvc.JsonResult(true)
                };
            }
            else
            {
                return new UpdatePasswordCommandResponse { 
                    Error = true,
                    Result = new Microsoft.AspNetCore.Mvc.JsonResult(res.Errors.ToList())
                };
            }
        }
    }
}
