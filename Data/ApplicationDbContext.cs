using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConventionPractice.Core;
using Microsoft.EntityFrameworkCore;

namespace ConventionPractice.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS03;Database=PracticeConvention;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>().HasKey(s => new { s.CourseId, s.StudentId });


            modelBuilder.Entity<Grade>()
                        .HasOne<Student>(s => s.Student)
                        .WithMany(s => s.Grades)
                        .HasForeignKey(s => s.StudentId);


            modelBuilder.Entity<Grade>()
                        .HasOne<Course>(s => s.Course)
                        .WithMany(s => s.Grades)
                        .HasForeignKey(s => s.CourseId);
        }


        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}