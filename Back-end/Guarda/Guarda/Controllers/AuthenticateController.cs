using Guarda.Business.DTOs.Authentication;
using Guarda.Core.Entities;
using Guarda.Data.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Guarda.Controllers
{
    public class AuthenticateController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthenticateController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult SignUp()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index" , "home");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(SignUpDto signupdto)
        {

            var userExistEmail = await _userManager.FindByEmailAsync(signupdto.Email);
            if (userExistEmail != null)
            {
                ModelState.AddModelError("Email", "Email is Already");
            }

            var userExistUsername = await _userManager.FindByNameAsync(signupdto.UserName);
            if(userExistUsername != null)
            {
                ModelState.AddModelError("UserName", "Username is already");
            }

            if(!ModelState.IsValid)
            {
                return View();
            }

            AppUser newUser = new AppUser
            {
                UserName = signupdto.UserName,
                Email = signupdto.Email,
                IsAdmin = false,
                FullName = signupdto.FullName
            };

            var result = await _userManager.CreateAsync(newUser, signupdto.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            await _userManager.AddToRoleAsync(newUser, "Member");
            await _signInManager.PasswordSignInAsync(newUser, signupdto.Password, false, false);

            return RedirectToAction("index", "home");
        }

        //public async Task<IActionResult> CreateRole()
        //{
        //    var role1 = await _roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
        //    var role2 = await _roleManager.CreateAsync(new IdentityRole("Admin"));
        //    var role3 = await _roleManager.CreateAsync(new IdentityRole("Member"));

        //    //AppUser SuperAdmin = new AppUser { FullName = "Super Admin", UserName = "SuperAdmin" };
        //    //var admin = await _userManager.CreateAsync(SuperAdmin, "Admin123");
        //    //var resultRole = await _userManager.AddToRoleAsync(SuperAdmin, "SuperAdmin");

        //    return Ok();
        //}
    }
}
