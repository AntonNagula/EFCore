using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Infrastructure.Interfaces.Interfaces
{
    public interface IUnitOfWork
    {
        IStudentRepository Students{get;}

        ILessonRepository Lessons { get; }

        IActionExecutingRepository Executings { get; }

        IExceptionRepository Exceptions { get; }
    }
}
