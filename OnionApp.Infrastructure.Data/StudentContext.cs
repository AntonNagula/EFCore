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

        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public StudentContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StudentContext;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LessonConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            Student st1 = new Student() { Id = 1, Name = "Денис", Surname = "Скриган" };
            Student st2 = new Student() { Id = 2, Name = "Александр", Surname = "Скриган" };
            Student st3 = new Student() { Id = 3, Name = "Арсений", Surname = "Скриган" };
            modelBuilder.Entity<Student>().HasData(
            new Student[]
            {
                new Student() { Id = 1, Name = "Денис", Surname = "Скриган"},
                new Student() { Id = 2, Name = "Александр", Surname = "Скриган"},
                new Student() { Id = 3, Name = "Арсений", Surname = "Скриган" },
                new Student() { Id = 4, Name = "Арсений", Surname = "Скриган" }
            });
            modelBuilder.Entity<Lesson>().HasData(
            new Lesson[]
            {
                new Lesson() { Id = 1, Name = "русский", StudentId=st1.Id},
                new Lesson() { Id = 2, Name = "английский",StudentId=st2.Id},
                new Lesson() { Id = 3, Name = "белорусский",StudentId=st3.Id },
                new Lesson() { Id = 4, Name = "белорусский",StudentId=st1.Id }
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
