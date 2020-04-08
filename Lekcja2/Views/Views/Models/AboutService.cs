using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Views.Models
{
    public class AboutService
    {
        public AboutViewModel Create(string firstName, string lastName)
        {
            var details = new DetailsViewModel()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = new Random().Next(1, 100),
                Projects = new List<string>
                {
                    "Projekt 1",
                    "Fajny projekt",
                    "Inny projekt"
                }
            };

            var user = new UserViewModel()
            {
                Login = "marek"
            };

            var about = new AboutViewModel()
            {
                User = user,
                Details = details
            };

            return about;
        }
    }
}
