using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Connection.Models;
using Connection.Models.Services;

namespace Connection.Controllers
{
    public class HomeController : Controller
    {
        private UserService _userService;

        public HomeController(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            var vm = new UsersListViewModel
            {
                Users = _userService.GetAll()
            };

            return View(vm);
        }

        public IActionResult Remove(int id)
        {
            _userService.Remove(id);

            return RedirectToAction("Index");
        }
    }
}
