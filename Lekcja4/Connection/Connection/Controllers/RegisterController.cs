using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Connection.Models;
using Connection.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Connection.Controllers
{
    public class RegisterController : Controller
    {
        private UserService _userService;

        public RegisterController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RegisterViewModel data)
        {
            if (!data.PasswordConfirmed())
            {
                ModelState.AddModelError("ConfirmPassword", "Hasła nie są takie same");
            }

            if (!ModelState.IsValid)
            {
                return View(data);
            }

            _userService.CreateUser(data.FirstName, data.LastName, data.Login, data.Password, data.AboutMe);

            return RedirectToAction("Index", "Home");
        }
    }
}