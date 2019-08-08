using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace EFCore.Infrastructure.Interfaces.Context
{
    public interface IStudentProvider
    {
        IList<Student> GetStudent();
        IList<Lesson> GetLesson();
    }
}
