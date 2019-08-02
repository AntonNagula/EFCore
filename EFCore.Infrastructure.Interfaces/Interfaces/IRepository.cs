using System.Collections.Generic;
using Models;
namespace EFCore.Infrastructure.Interfaces.Interfaces
{
    public interface IRepository
    {
        IList<General_Info> GetStudents();
        void Create(General_Info Item);
        void Delete(int Id);

        IList<Lesson> GetLessons(int Id);
        //IList<Lesson> GetLessons(int Id);
        //Lesson Getstudent_Info(int Id);
        //Student Getstudent(int Id);
        //void Delete_Student(int id);
        //void Delete_Lesson(int StId,int Id);
        //void Create_Student(Genera_lnfo item);
        //void Create_Lesson(int Id);       
    }
}
