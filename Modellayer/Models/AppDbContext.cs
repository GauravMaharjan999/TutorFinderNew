
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore; //Db context
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modellayer.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<StudentRecord> StudentRecord { get; set; }
        public DbSet<StudentAcademic> StudentAcademic { get; set; }
        public DbSet<Class> Class { get; set; }
		public DbSet<TrainingCourse> TrainingCourse { get; set; }
		public DbSet<TrainingTutor> TrainingTutor { get; set; }
		public DbSet<TrainingCourseCategory> TrainingCourseCategory { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
