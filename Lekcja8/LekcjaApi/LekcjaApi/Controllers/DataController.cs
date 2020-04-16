using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LekcjaApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LekcjaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet("text")]
        public TextViewModel GetText()
        {
            return new TextViewModel()
            {
                Text = "To jest tekst z API"
            };
        }

        [HttpPost]
        public TextViewModel Post(string text)
        {
            return new TextViewModel
            {
                Text = text
            };
        }
    }
}