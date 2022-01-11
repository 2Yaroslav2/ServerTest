using Microsoft.AspNetCore.Identity;
using Server.Domain.Application.Dto.UserDTO;
using Server.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Server.Domain.Application.Interfaces.Servies
{
    public interface IUserServiceAsync
    {
        Task<User> GetByNameAsync(string name);
        Task<User> GetByEmailAsync(string email);
        Task<User> GetByIdAsync(string id);
        Task<UserViewDTO> SignInAsync(UserSignInDTO userSignInDTO);
        Task<IdentityResult> CreateAsync(UserCreateDTO user, string password);
        Task<IdentityResult> DeleteAsync(string id);
        Task<IdentityResult> ChangePasswordAsync(UserUpdatePasswordDTO updatePassword);
        Task<IdentityResult> ChangePhoneNumberAsync(string name, string newPhoneNumber);
        Task<string> GetRole(User user);
        Task<IdentityResult> UpdateLoginAsync(UserUpdateLoginDTO user);
        Task<IdentityResult> UpdateContactsAsync(UserUpdateContactsDTO user);
        Task<IdentityResult> UpdatePersonalDataAsync(UserUpdatePersonalDataDTO user);
    }
}
