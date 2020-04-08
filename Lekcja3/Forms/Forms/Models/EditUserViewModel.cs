using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class EditUserViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Imię jest wymagane")]
        [Display(Name ="Imię")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        [MinLength(5, ErrorMessage ="Hasło musi mieć co najmniej 5 znaków")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Text)]
        public int Age { get; set; }
        public string Description { get; set; }

        [Required]
        public IFormFile MyFile { get; set; }
    }
}
