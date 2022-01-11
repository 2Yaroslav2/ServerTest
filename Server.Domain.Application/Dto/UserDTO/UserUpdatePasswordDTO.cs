using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.Dto.UserDTO
{
    public class UserUpdatePasswordDTO
    {
        public string Id { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
