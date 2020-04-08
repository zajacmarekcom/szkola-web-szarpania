using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Views.Models
{
    public class DetailsViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public IEnumerable<string> Projects { get; set; }
    }
}
