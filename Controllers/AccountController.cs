using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using register.Models;
using register.Models.ViewModel;

namespace register.Controllers
{

    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
                                 SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }


        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("login", "Account");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(" ", error.Description);
                }

            }


            return View(model);
        }


        [HttpGet]
        public IActionResult login()
        {


            return View();
        }


        [HttpPost]
        public async Task<IActionResult> login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {

              
                    var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe,false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Resume", "CreateResume");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
                    }
              


            }
            return View(model);
        }


    }
}
