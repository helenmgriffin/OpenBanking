﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc;

namespace OpenBanking.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
                return Challenge(OpenIdConnectDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            return new SignOutResult(new[]
            {
                OpenIdConnectDefaults.AuthenticationScheme,
                CookieAuthenticationDefaults.AuthenticationScheme
              });
        }

        public ActionResult PostLogout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}