using Microsoft.AspNetCore.Identity;

namespace Server.Domain.Application.CQRS.Commands.UserCommands.CreateUser
{
    public class CreateUserCommandResponse
    {
        //public string Id { get; set; }
        //public string UserName { get; set; }
        //public string Email { get; set; }
        //public string Phone { get; set; }

        public IdentityResult IdentityResult { get; set; }
    }
}
