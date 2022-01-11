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

namespace Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdateContacts
{
    public class UpdateContactsCommandHandler : IRequestHandler<UpdateContactsCommandRequest, UpdateContactsCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public UpdateContactsCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<UpdateContactsCommandResponse> Handle(UpdateContactsCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.UserServiceAsync.UpdateContactsAsync(mapper.Map<UserUpdateContactsDTO>(request));
            if (res.Succeeded)
            {
                return new UpdateContactsCommandResponse
                {
                    Error = false,
                    Result = new Microsoft.AspNetCore.Mvc.JsonResult(request)
                };
            }
            else
            {
                return new UpdateContactsCommandResponse
                {
                    Error = true,
                    Result = new Microsoft.AspNetCore.Mvc.JsonResult(res.Errors.ToList())
                };
            }
           
        }
    }
}
