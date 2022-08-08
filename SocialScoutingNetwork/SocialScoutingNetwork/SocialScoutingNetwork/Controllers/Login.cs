using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SocialScoutingNetwork.Controllers
{
    public class Login : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer p)
        {
            LoginValidator lv = new LoginValidator();
            ValidationResult results = lv.Validate(p);

            var c = new Context();
            var datavalue = c.Writers.FirstOrDefault(x => x.WriterUserName == p.WriterUserName && x.WriterPassword == p.WriterPassword);

            if (results.IsValid)
            {
                if (datavalue != null)
                {
                    //HttpContext.Session.SetString("WriterUserName",p.WriterUserName);

                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.WriterUserName)

                };

                    var useridentity = new ClaimsIdentity(claims, "a");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "WriterProfile");
                }
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            
            return View();
        }

        public async Task<IActionResult> Logout()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }

    }
}
