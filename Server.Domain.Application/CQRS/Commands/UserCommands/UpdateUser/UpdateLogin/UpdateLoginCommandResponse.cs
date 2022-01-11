using Microsoft.AspNetCore.Mvc;
using Server.Domain.Application.Dto.UserDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdateLogin
{
    public class UpdateLoginCommandResponse
    {
        public bool Error { get; set; } = false;
        public JsonResult Result { get; set; }
    }
}
