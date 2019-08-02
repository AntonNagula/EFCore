using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace EFCore.Infrastructure.Interfaces.Interfaces
{
    public interface ILessonRepository
    {
        void Create(Lesson item);

        void Delete(int id);

        IList<Lesson> Get(int id);
    }
}
