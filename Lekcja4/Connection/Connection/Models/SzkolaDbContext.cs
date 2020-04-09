using Connection.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Connection.Models
{
    public class SzkolaDbContext : DbContext
    {
        public SzkolaDbContext(DbContextOptions options): base(options) { }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ProjectEntity> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProjectEntity>()
                .HasKey(up => new { up.UserId, up.ProjectId });
            modelBuilder.Entity<UserProjectEntity>()
                .HasOne(up => up.User)
                .WithMany(up => up.Projects)
                .HasForeignKey(up => up.ProjectId);
            modelBuilder.Entity<UserProjectEntity>()
                .HasOne(up => up.Project)
                .WithMany(up => up.Users)
                .HasForeignKey(up => up.UserId);
        }
    }
}
