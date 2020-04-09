using Connection.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Connection.Models.Services
{
    public class UserService
    {
        private SzkolaDbContext _context;

        public UserService(SzkolaDbContext context)
        {
            _context = context;
        }

        public void CreateUser(string firstName, string lastName, string login, string password, string aboutMe)
        {
            var entity = new UserEntity
            {
                FirstName = firstName,
                LastName = lastName,
                Login = login,
                Password = password,
                AboutMe = aboutMe,
                Address = new AddressEntity
                {
                    City = "Kraków",
                    Street = "Kwiatowa 111",
                    PostCode = "30-000"
                },
                Hobby = new List<HobbyEntity>
                {
                    new HobbyEntity { Name = "Pływanie" },
                    new HobbyEntity { Name = "Książki" },
                    new HobbyEntity { Name = "TV" },
                }
            };

            _context.Users.Add(entity);

            _context.SaveChanges();
        }

        public IEnumerable<UserListItemViewModel> GetAll()
        {
            var users = _context.Users.Select(x => new UserListItemViewModel
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Login = x.Login
            }).ToList();

            return users;
        }

        public void Remove(int id)
        {
            var user = _context.Users.Find(id);

            _context.Users.Remove(user);

            _context.SaveChanges();
        }

        public EditUserViewModel GetToEdit(int id)
        {
            var user = _context.Users.Find(id);

            var vm = new EditUserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                AboutMe = user.AboutMe
            };

            return vm;
        }

        public void Update(EditUserViewModel updated)
        {
            var user = _context.Users.Find(updated.Id);

            user.FirstName = updated.FirstName;
            user.LastName = updated.LastName;
            user.AboutMe = updated.AboutMe;

            _context.Update(user);

            _context.SaveChanges();
        }
    }
}
