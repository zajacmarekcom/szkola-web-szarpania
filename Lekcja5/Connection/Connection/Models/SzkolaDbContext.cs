using Connection.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Connection.Models
{
    public class SzkolaDbContext : IdentityDbContext<CustomUser>
    {
        public SzkolaDbContext(DbContextOptions options): base(options) { }

        public DbSet<UserEntity> UsersCustom { get; set; }
        public DbSet<ProjectEntity> Projects { get; set; }
        public DbSet<UserProjectEntity> UserProject { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserProjectEntity>()
                .HasKey(up => new { up.UserId, up.ProjectId });
            modelBuilder.Entity<UserProjectEntity>()
                .HasOne(up => up.User)
                .WithMany(up => up.UserProject)
                .HasForeignKey(up => up.UserId);
            modelBuilder.Entity<UserProjectEntity>()
                .HasOne(up => up.Project)
                .WithMany(up => up.UserProject)
                .HasForeignKey(up => up.ProjectId);
        }
    }
}
