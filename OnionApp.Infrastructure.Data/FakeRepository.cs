using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.Infrastructure.Interfaces.Context;
namespace EFCore.Infrastructure.Data
{
    public class FakeRepository : IStudentProvider
    {
        public List<Student> students = new List<Student>()
        {
             new Student() { Id = 1, Name = "Денис", Surname = "Скриган" },
             new Student() { Id = 2, Name = "Александр", Surname = "Скриган" },
             new Student() { Id = 3, Name = "Арсений", Surname = "Скриган" }
        };

        public List<Lesson> lessons= new List<Lesson>
        {
                new Lesson() { Id = 1, Name = "русский", StudentId = 1},
                new Lesson() { Id = 2, Name = "английский",StudentId = 2},
                new Lesson() { Id = 3, Name = "белорусский",StudentId = 3 },
                new Lesson() { Id = 4, Name = "белорусский",StudentId = 1 }
        };

        public IList<Student> GetStudent()
        {
            return students.ToList();
        }

        public IList<Lesson> GetLesson()
        {
            return lessons.ToList();
        }
        
    }
}
