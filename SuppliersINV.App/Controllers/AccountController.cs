using Azure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Suppliers.DataModel;
using SuppliersINV.App.Models;

namespace SuppliersINV.App.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager,
                SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View(new RegisterVM());
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            //Add a new user
            if (ModelState.IsValid == true) {
                IdentityUser user = new IdentityUser();
                user.UserName = model.Email;
                user.Email = model.Email;
                await userManager.CreateAsync(user, model.Password);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult SignIn(string? returnUrl)
        {
            SignInVM vm = new SignInVM();
            if(!string.IsNullOrEmpty(returnUrl))
            vm.ReturnUrl = returnUrl;
            return View(vm);  
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(SignInVM model, string? returnUrl) 
        {

            //Codes to sign in
            IdentityUser user = await userManager.FindByNameAsync(model.Username);
            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                        return LocalRedirect(returnUrl);
                    else
                        return LocalRedirect("/Home/Index");
                }
                else
                {
                    ModelState.AddModelError("Login Error", "Invalid Credentials");
                    return View(model);

                }
                
            }
            else
            {
                ModelState.AddModelError("Login Error", "Invalid Credentials");
                return View(model);
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
