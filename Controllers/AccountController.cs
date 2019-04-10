using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;

namespace MyApp.Controllers
{
    public class AccountController : Controller
    {
        ApplicationDbContext ctx;

        public AccountController(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        }

        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult AcctSettings()
        {
            return View();
        }

        public IActionResult LogOut()
        {
            Response.Cookies.Delete("UName");
            Response.Cookies.Delete("SessionState");
            return RedirectToAction("Index", "Home");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult SignIn(SignInModel user)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            foreach (var u in ctx.Users)
            {
                if(user.Username == u.UserName)
                {
                    if (BCrypt.Net.BCrypt.Verify(user.Password + "yentis|", u.PasswordHash))
                    {
                        Response.Cookies.Append("UName", user.Username, new CookieOptions() { IsEssential = true });
                        Response.Cookies.Append("SessionState", "signedin", new CookieOptions() { IsEssential = true, Expires = DateTimeOffset.Now.AddMinutes(30) });
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View();
        }


        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Register(RegisterModel user)
        {
            if(!ModelState.IsValid)
            {
                return View(user);
            }

            var appuser = new User()
            {
                UserName = user.Username,
                Email = user.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.Password + "yentis|", BCrypt.Net.BCrypt.GenerateSalt()),
                Address = user.Address
            };
        
        
            if (!ctx.Users.Any(m => m.UserName == appuser.UserName))
            {
                ctx.Users.Add(appuser);
                ctx.Addresses.Add(user.Address);
                ctx.SaveChanges();

                return RedirectToAction("SignIn");
            }
            else
            {
                ViewBag.Warning = "Username already exists!";
                return View(user);
            }
        }
    }
}