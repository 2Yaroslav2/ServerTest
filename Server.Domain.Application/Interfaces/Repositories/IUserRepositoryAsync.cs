using Microsoft.AspNetCore.Identity;
using Server.Domain.Core.Entities;
using System.Threading.Tasks;

namespace Server.Domain.Application.Interfaces.Repositories
{
    public interface IUserRepositoryAsync
    {
        Task<User> GetByNameAsync(string name);
        Task<User> GetByEmailAsync(string email);
        Task<User> GetByIdAsync(string id);
        Task<User> SignInAsync(User user, string password);
        Task<IdentityResult> CreateAsync(User user, string password);
        Task<IdentityResult> DeleteAsync(string email);
        Task<User> ChangeEmailAsync(User user, string newEmail);
        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);
        Task<IdentityResult> ChangePhoneNumberAsync(User user, string newPhoneNumber);
        Task<string> GetRole(User user);
        Task<IdentityResult> UpdateAsync(User user);
    }
}
