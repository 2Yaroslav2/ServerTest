using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdatePassword
{
    public class UpdatePasswordCommandResponse
    {
        public bool Error { get; set; } = false;
        public JsonResult Result { get; set; }
    }
}
