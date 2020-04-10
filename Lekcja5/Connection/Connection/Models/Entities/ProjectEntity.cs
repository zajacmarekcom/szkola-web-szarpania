using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Connection.Models.Entities
{
    public class ProjectEntity
    {
        public ProjectEntity()
        {
            UserProject = new Collection<UserProjectEntity>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<UserProjectEntity> UserProject { get; set; }
    }
}
