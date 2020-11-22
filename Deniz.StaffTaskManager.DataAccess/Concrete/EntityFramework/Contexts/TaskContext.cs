using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Deniz.StaffTaskManager.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Mapping;

namespace Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Contexts

{
   public class TaskContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=StaffTaskManager;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TaskMap());
            builder.ApplyConfiguration(new UrgencyMap());
            builder.ApplyConfiguration(new ReportMap());
            builder.ApplyConfiguration(new AppUserMap());
            base.OnModelCreating(builder);
        }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Urgency> Urgencies { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}
