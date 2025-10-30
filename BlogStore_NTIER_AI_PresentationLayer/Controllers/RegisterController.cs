using BlogStore_NTIER_AI_EntityLayer.Entities;
using BlogStore_NTIER_AI_PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogStore_NTIER_AI_PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserRegisterViewModel userRegisterViewModel)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    ImageUrl = "/images/default-user.png",
                    Description = "New user",
                    UserName = userRegisterViewModel.Username,
                    Email = userRegisterViewModel.Email,
                    Name = userRegisterViewModel.Name,
                    Surname = userRegisterViewModel.Surname
                };

                var result = await _userManager.CreateAsync(appUser, userRegisterViewModel.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(appUser, "Author");
                    return RedirectToAction("UserLogin", "Login");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(userRegisterViewModel);
        }
    }
}