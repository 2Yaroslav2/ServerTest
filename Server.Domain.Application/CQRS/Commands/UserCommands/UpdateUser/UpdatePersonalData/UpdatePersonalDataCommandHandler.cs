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

namespace Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdatePersonalData
{
    public class UpdatePersonalDataCommandHandler : IRequestHandler<UpdatePersonalDataCommandRequest, UpdatePersonalDataCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public UpdatePersonalDataCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<UpdatePersonalDataCommandResponse> Handle(UpdatePersonalDataCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.UserServiceAsync.UpdatePersonalDataAsync(mapper.Map<UserUpdatePersonalDataDTO>(request));
            if (res.Succeeded)
            {
                return new UpdatePersonalDataCommandResponse
                {
                    Error = false,
                    Result = new Microsoft.AspNetCore.Mvc.JsonResult(request)
                };
            }
            else
            {
                return new UpdatePersonalDataCommandResponse
                {
                    Error = true,
                    Result = new Microsoft.AspNetCore.Mvc.JsonResult(res.Errors.ToList())
                };
            }
        }
    }
}
