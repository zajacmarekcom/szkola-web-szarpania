using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Connection.Models;
using Connection.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Connection.Controllers
{
    public class UserController : Controller
    {
        private UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var vm = _userService.GetToEdit(id);

            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(EditUserViewModel data)
        {
            if (!ModelState.IsValid)
            {
                return View(data);
            }

            _userService.Update(data);

            return RedirectToAction("Index", "Home");
        }
    }
}