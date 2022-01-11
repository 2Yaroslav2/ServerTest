using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.Dto.UserDTO
{
    public class UserUpdateDTO
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
