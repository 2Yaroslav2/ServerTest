using Microsoft.AspNetCore.Identity;
using Server.Domain.Application.Interfaces.Repositories;
using Server.Domain.Core.Entities;
using System.Threading.Tasks;

namespace Server.Infrastucture.Persistence.Repository
{
    public class UserRepositoryAsync : IUserRepositoryAsync
    {
        private readonly UserManager<User> userManager;
        private SignInManager<User> signInManager;

        public UserRepositoryAsync(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<User> ChangeEmailAsync(User user, string newEmail)
        {
            var token = await userManager.GenerateChangeEmailTokenAsync(user, newEmail);
            ;
            var res = await userManager.ChangeEmailAsync(user, newEmail, token);
            if (res.Succeeded)
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        public async Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword)
        {
            return await userManager.ChangePasswordAsync(user, oldPassword, newPassword);
        }

        public async Task<IdentityResult> ChangePhoneNumberAsync(User user, string newPhoneNumber)
        {
            var token = await userManager.GenerateChangePhoneNumberTokenAsync(user, newPhoneNumber);
            var flag = await userManager.VerifyChangePhoneNumberTokenAsync(user, token, newPhoneNumber);
            if (flag)
            {
                return await userManager.ChangePhoneNumberAsync(user, newPhoneNumber, token);
            }
            else
            {
                return IdentityResult.Failed();
            }
        }

        public async Task<IdentityResult> CreateAsync(User user, string password)
        {
            var res = await userManager.CreateAsync(user, password);
            if (res.Succeeded && user.UserName != "admin")
            {
                await userManager.AddToRoleAsync(user, "user");
                return res;
            }
            else
            {
                return res;
            }
        }

        public async Task<IdentityResult> DeleteAsync(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            return await userManager.DeleteAsync(user);
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await userManager.FindByEmailAsync(email);
        }

        public async Task<User> GetByIdAsync(string id)
        {
            return await userManager.FindByIdAsync(id);
        }

        public async Task<User> GetByNameAsync(string name)
        {
            return await userManager.FindByNameAsync(name);
        }

        public async Task<string> GetRole(User user)
        {
            var res = await userManager.GetRolesAsync(user);
            return res[0].ToString();
        }

        // TO DO:
        public async Task<User> SignInAsync(User user, string password)
        {
            //var tmp = await userManager.GetRolesAsync(user);

            ;
            if (user != null)
            {
                var res = await signInManager.PasswordSignInAsync(user.UserName, password, false, false);
                if (res.Succeeded)
                {
                    //await signInManager.SignInAsync(user, false);
                    return user;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }

        public async Task<IdentityResult> UpdateAsync(User user)
        {
            return await userManager.UpdateAsync(user);
        }
    }
}
