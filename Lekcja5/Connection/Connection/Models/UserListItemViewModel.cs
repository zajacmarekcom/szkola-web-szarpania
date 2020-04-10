using System.Collections.Generic;

namespace Connection.Models
{
    public class UserListItemViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public IEnumerable<string> Projects { get; set; }
    }
}