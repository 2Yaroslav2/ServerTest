using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.Dto.UserDTO
{
    public class UserSignInDTO
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
