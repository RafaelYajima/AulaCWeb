using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Moveis1Prj.Models;
using Moveis1Prj.ViewsModel;

namespace Moveis1Prj.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;

        public AccountController(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel
            {
                ReturnUrl = returnUrl
            }); 

        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            if(!ModelState.IsValid)
            {
                return View(loginVM);
            }
            var user = await _userManager.FindByNameAsync(loginVM.UserName);

            if (user != null) {
                var result = await _signInManager.PasswordSignInAsync(user.UserName, loginVM.Password, false, false);

                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(loginVM.ReturnUrl))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return RedirectToAction(loginVM.ReturnUrl);
                    }
                }
            }
            ModelState.AddModelError("", "Usuario invalido!");
            return View(loginVM);
        }

        public IActionResult Register() { return View(); }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegistroViewModel registroVM)
        {
            if (ModelState.IsValid) {
                var user = new Usuario
                {
                    UserName = registroVM.UserName,
                    Nome = registroVM.Nome,
                    Telefone = registroVM.Telefone
                };
                var result = await _userManager.CreateAsync(user, registroVM.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Usuario");
                }
                else
                {
                    this.ModelState.AddModelError("Registro", "Erro ao cadsatrar usuario");
                }
            }
            return View(registroVM);
        }
       
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.User = null;
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
