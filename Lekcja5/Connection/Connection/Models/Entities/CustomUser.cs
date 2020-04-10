using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Connection.Models.Entities
{
    public class CustomUser : IdentityUser
    {
        public string AboutMe { get; set; }
    }
}
