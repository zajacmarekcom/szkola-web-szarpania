using Connection.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Connection.Models.Services
{
    public class ProjectService
    {
        private SzkolaDbContext _context;

        public ProjectService(SzkolaDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            var entity = new ProjectEntity()
            {
                Name = "Project1"
            };

            _context.Projects.Add(entity);
            _context.SaveChanges();
        }
    }
}
