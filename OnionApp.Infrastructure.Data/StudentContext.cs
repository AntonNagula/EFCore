using System;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Models;
using EFCore.Infrastructure.Data.Configuration;
namespace EFCore.Infrastructure.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Exceptions> Exceptions { get; set; }
        public DbSet<ActionExecuting> ActionExecutingDetails { get; set; }

        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new LessonConfiguration());
            modelBuilder.ApplyConfiguration(new ExceptionConfiguration());
            modelBuilder.ApplyConfiguration(new ActionConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
