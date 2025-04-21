using eStore.Application.common.Interfaces;
using eStore.Application.Utilities;
using eStore.Domain.Entity;
using eStore.Web.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eStore.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUnitOfWork _unitOfWork;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Register(string retrunUrl)
        {
            retrunUrl ??= Url.Content("~/");
            if (!_roleManager.RoleExistsAsync(StaticDetails.ApplicationUserRoles.Role_Seller).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(StaticDetails.ApplicationUserRoles.Role_Seller)).Wait();
                _roleManager.CreateAsync(new IdentityRole(StaticDetails.ApplicationUserRoles.Role_Customer)).Wait();
            }

            RegisterVM registerVM = new RegisterVM()
            {
                Rolelist = _roleManager.Roles.Select(r => new SelectListItem
                {
                    Text = r.Name,
                    Value = r.Name
                }).ToList(),
                RedirectURL = retrunUrl
            };


            return View(registerVM);
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            ApplicationUser user = new ApplicationUser()
            {
                Name = registerVM.Name,
                CreatedAt = DateTime.Now,
                Email = registerVM.Email,
                EmailConfirmed = true,
                NormalizedEmail = registerVM.Email.ToUpper(),
                PhoneNumber = registerVM.PhoneNumber,
                UserName = registerVM.Email
            };
            var result = await _userManager.CreateAsync(user, registerVM.Password);
            if (result.Succeeded)
            {
                if (!string.IsNullOrEmpty(registerVM.Role))
                    await _userManager.AddToRoleAsync(user, registerVM.Role);
                else
                    await _userManager.AddToRoleAsync(user, StaticDetails.ApplicationUserRoles.Role_Customer);
                await _signInManager.SignInAsync(user, isPersistent: false);
                return string.IsNullOrEmpty(registerVM.RedirectURL) ? RedirectToAction("Index", "Home") : LocalRedirect(registerVM.RedirectURL);

            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            registerVM.Rolelist = _roleManager.Roles.Select(r => new SelectListItem()
            {
                Text = r.Name,
                Value = r.Name
            });
            return View(registerVM);
        }

        [HttpGet]
        public IActionResult Login(string returnURL = null)
        {
            returnURL ??= Url.Content("~/");
            LoginVM loginVM = new LoginVM()
            {
                RedirectURL = returnURL
            };
            return View(loginVM);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginVM.Email, loginVM.Password, isPersistent: loginVM.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return (string.IsNullOrEmpty(loginVM.RedirectURL)) ?
                        RedirectToAction("Index", "Home") :
                        LocalRedirect(loginVM.RedirectURL);



                }
            }

            ModelState.AddModelError("", "Invalid Login Attempt.");

            return View(loginVM);
        }
        public IActionResult Logout()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }


    }
}
