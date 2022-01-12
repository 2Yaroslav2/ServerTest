using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Server.Domain.Application.CQRS.Queries.UserQueries.SignIn;
using Server.Domain.Core.Entities;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private UserManager<User> userManager;
        private SignInManager<User> signInManager;
        private RoleManager<IdentityRole> roleManager;
        //private SignInManager

        private IMediator mediator;

        public AuthController(UserManager<User> userManager, 
            SignInManager<User> signInManager, 
            IMediator mediator, 
            RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.mediator = mediator;
            this.roleManager = roleManager;
        }



        // TO DO:
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(SignInQueryRequest request)
        {

            //var res = await roleManager.CreateAsync(new IdentityRole("user"));
            //var res1 = await  roleManager.CreateAsync(new IdentityRole("admin"));
            //var user = await userManager.FindByEmailAsync("user02@gmail.com");
            //var res = await userManager.AddToRoleAsync(user, "user");
            //var res = await userManager.GetRolesAsync(user);
            //var res2 = res[0].ToString();
            ;
            //var user = userManager.FindByNameAsync(request.Name);
            //var res = await signInManager.PasswordSignInAsync(request.UserName, request.Password, false, false);
            //if (res.Succeeded)
            //{
            //    ;
            //}
            //var res2 = await signInManager.SignInAsync()


            ;
            var res = await mediator.Send(request);

            if (res != null)
            {
                return new JsonResult(res);
            }
            else
            {
                return BadRequest(new { errorText = "Invalid login or password." });
            }
            //return null;
        }

 
        [HttpPost]
        [Route("logout")]
        public async Task Logout()
        {
            ;
            await signInManager.SignOutAsync();
        }
    }
}
