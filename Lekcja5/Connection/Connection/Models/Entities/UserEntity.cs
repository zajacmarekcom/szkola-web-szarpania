using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Connection.Models.Entities
{
    public class UserEntity
    {
        public UserEntity()
        {
            UserProject = new Collection<UserProjectEntity>();
        }

        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public string AboutMe { get; set; }
        public virtual AddressEntity Address { get; set; }

        public virtual ICollection<HobbyEntity> Hobby { get; set; }
        public virtual ICollection<UserProjectEntity> UserProject { get; set; }
    }
}
