using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Server.Domain.Application.Dto.UserDTO;
using Server.Domain.Application.Interfaces.Repositories;
using Server.Domain.Application.Interfaces.Servies;
using Server.Domain.Core.Entities;
using System;
using System.Threading.Tasks;

namespace Server.Infrastucture.Servies.Servies
{
    public class UserServiceAsync : IUserServiceAsync
    {
        private readonly IUserRepositoryAsync userRepositoryAsync;
        private readonly IMapper mapper;
        public UserServiceAsync(IUserRepositoryAsync userRepositoryAsync, IMapper mapper)
        {
            this.userRepositoryAsync = userRepositoryAsync;
            this.mapper = mapper;
        }

        public async Task<IdentityResult> ChangePasswordAsync(UserUpdatePasswordDTO updatePassword)
        {
            var user = await GetByIdAsync(updatePassword.Id);
            var res = await userRepositoryAsync.ChangePasswordAsync(user, updatePassword.OldPassword, updatePassword.NewPassword);
            return res;
        }

        public Task<IdentityResult> ChangePhoneNumberAsync(string name, string newPhoneNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityResult> CreateAsync(UserCreateDTO userCreateDTO, string password)
        {
            var user = mapper.Map<User>(userCreateDTO);
            return await userRepositoryAsync.CreateAsync(user, password);
        }

        public async Task<IdentityResult> DeleteAsync(string id)
        {
            return await userRepositoryAsync.DeleteAsync(id);
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await userRepositoryAsync.GetByEmailAsync(email);
        }

        public async Task<User> GetByIdAsync(string id)
        {
            return await userRepositoryAsync.GetByIdAsync(id);
        }

        public async Task<User> GetByNameAsync(string name)
        {
            return await userRepositoryAsync.GetByNameAsync(name);
        }

        public async Task<string> GetRole(User user)
        {
            return await userRepositoryAsync.GetRole(user);
        }

        public async Task<UserViewDTO> SignInAsync(UserSignInDTO userSignInDTO)
        {
            var user = await GetByEmailAsync(userSignInDTO.Login);
            var res = mapper.Map<UserViewDTO>(await userRepositoryAsync.SignInAsync(user, userSignInDTO.Password));
            if (res != null)
            {
                res.Role = await userRepositoryAsync.GetRole(user);
            }
            return res;
        }

        public async Task<IdentityResult> UpdateContactsAsync(UserUpdateContactsDTO user)
        {
            var userData = await GetByIdAsync(user.Id);
            userData.Email = user.Email;

            //var res = await userRepositoryAsync.UpdateAsync(userData);
            //var res = await userRepositoryAsync.ChangeEmailAsync(userData, user.Email);
            return await userRepositoryAsync.UpdateAsync(userData);
        }

        public async Task<IdentityResult> UpdateLoginAsync(UserUpdateLoginDTO user)
        {
            var userData = await GetByIdAsync(user.Id);
            userData.Email = user.Email;

            //var res = await userRepositoryAsync.UpdateAsync(userData);
            //var res = await userRepositoryAsync.ChangeEmailAsync(userData, user.Email);
            return await userRepositoryAsync.UpdateAsync(userData);
        }

        public async Task<IdentityResult> UpdatePersonalDataAsync(UserUpdatePersonalDataDTO user)
        {
            var userData = await GetByIdAsync(user.Id);
            userData.UserName = user.UserName;

            //var res = await userRepositoryAsync.UpdateAsync(userData);
            return await userRepositoryAsync.UpdateAsync(userData);
        }
    }
}
