using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Server.Domain.Application.CQRS.Commands.UserCommands.CreateUser;
using Server.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private UserManager<User> userManager;
        private IMediator mediator;

        public RegistrationController(UserManager<User> userManager, IMediator mediator)
        {
            this.userManager = userManager;
            this.mediator = mediator;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Registration(CreateUserCommandRequest request)
        {
            ;
            var res = await mediator.Send(request);
            if (res.IdentityResult.Succeeded)
            {
                return Ok();
            }
            else
            {
                var error = res.IdentityResult.Errors.ToList();
                return BadRequest(error);
            }

        }
    }
}
