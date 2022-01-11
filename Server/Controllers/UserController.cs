using MediatR;
using Microsoft.AspNetCore.Mvc;
using Server.Domain.Application.CQRS.Commands.UserCommands.DeleteUser;
using Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdateContacts;
using Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdateLogin;
using Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdatePassword;
using Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdatePersonalData;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpPut]
        [Route("updateContacts")]
        public async Task<IActionResult> UpdateContacts(UpdateContactsCommandRequest request)
        {
            ;
            var res = await mediator.Send(request);
            if (!res.Error)
            {
                return new JsonResult(res.Result.Value);
            }
            else
            {
                return BadRequest(res.Result.Value);
            }
           
        }

        [HttpPut]
        [Route("updateLogin")]
        public async Task<IActionResult> UpdateLogin(UpdateLoginCommandRequest request)
        {
            var res = await mediator.Send(request);
            if (!res.Error)
            {
                return new JsonResult(res.Result.Value);
            }
            else
            {
                return BadRequest(res.Result.Value);
            }
        }

        [HttpPut]
        [Route("updatePesonalData")]
        public async Task<IActionResult> UpdatePersonalData(UpdatePersonalDataCommandRequest request)
        {
            var res = await mediator.Send(request);
            if (!res.Error)
            {
                return new JsonResult(res.Result.Value);
            }
            else
            {
                return BadRequest(res.Result.Value);
            }
        }

        [HttpPut]
        [Route("updatePassword")]
        public async Task<IActionResult> UpdatePassword(UpdatePasswordCommandRequest request)
        {
            ;
            var res = await mediator.Send(request);
            if (!res.Error)
            {
                ;
                return new JsonResult(res.Result.Value);
            }
            else
            {
                return BadRequest(res.Result.Value);
            }
        }


        //TO DO:
        //[HttpDelete]
        //[Route("delete")]
        //public async Task<IActionResult> Delete(DeleteUserCommandRequest request)
        //{
        //    var res = await mediator.Send(request);
        //    return new JsonResult(res);
        //}

    }
}
