using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Forms.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Forms.Controllers
{
    public class UserController : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;

        public UserController(IWebHostEnvironment webHostEnvironment)
        {
            _hostingEnvironment = webHostEnvironment;
        }

        [Route("", Name = "Test")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            var vm = new EditUserViewModel
            {
                FirstName = "Marek",
                LastName = "Zając",
                Age = 28,
                Description = "DESCRIPTION",
                Id = 11
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(EditUserViewModel data)
        {
            if (!ModelState.IsValid)
            {
                return View(data);
            }

            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");

            if (!Directory.Exists(uploads))
            {
                Directory.CreateDirectory(uploads);
            }

            var filePath = Path.Combine(uploads, data.MyFile.FileName);

            data.MyFile.CopyTo(new FileStream(filePath, FileMode.Create));

            return RedirectToRoute("Test");
        }
    }
}