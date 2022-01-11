using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdatePersonalData
{
    public class UpdatePersonalDataCommandRequest : IRequest<UpdatePersonalDataCommandResponse>
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
