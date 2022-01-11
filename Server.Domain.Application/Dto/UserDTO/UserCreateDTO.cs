using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.Dto.UserDTO
{
    public class UserCreateDTO
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        //public string Phone { get; set; }
    }
}
