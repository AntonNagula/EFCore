using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EFCore.Domain.Core.Interfaces
{
    public interface IService
    {
        IList<DomainGeneral> GetStudents();
        void Create(DomainGeneral Item);
        void Delete_Student(int Id);

        void Create_Lesson(DomainLesson item);
        void Delete_Lesson(int Id);
        IList<DomainLesson> Get_Lesson(int Id);
    }
}
