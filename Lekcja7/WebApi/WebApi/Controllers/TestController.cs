using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("data/{x}/{id}")]
        public LoginModel Get(int x, int id)
        {
            return new LoginModel
            {
                Login = "Test",
                Password = "Passsword"
            };
        }
    }
}