using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.Infrastructure.Interfaces.Interfaces;
using EFCore.Infrastructure.Data;
using Models;
using EFCore.Infrastructure.Data.Mappers;
namespace EFCore.Infrastructure.Data
{
    public class Repository:IRepository
    {
        private readonly StudentContext _students;
        public Repository(StudentContext students)
        {
            _students = students;
        }

        public IList<General_Info> GetStudents()
        {
            IList<General_Info> students = _students.Students.Select(x=>x.FromStudentToGeneral_Info()).ToList();
            return students;

        }

        public void Create(General_Info Item)
        {           
            _students.Add(Item.FromGeneral_InfoToStudent());
            _students.SaveChanges();
        }

        public void Delete(int Id)
        {
            Student student = _students.Students.Find(Id);
            _students.Remove(student);
            _students.SaveChanges();
        }

        public IList<Lesson> GetLessons(int Id)
        {
            IList<Lesson> Lessons = _students.Lessons.Where(x=>x.StudentId==Id).ToList();
            return Lessons;
        }
        //public Lesson Getstudent_Info(int Id)
        //{
        //    return data.FirstOrDefault(_ => _.Id == Id);
        //}

        //public Student Getstudent(int Id)
        //{
        //    return data.FirstOrDefault(_=>_.Id==Id).ToStudent();
        //}     

        //public void Delete(int id)
        //{
        //    var obj = data.FirstOrDefault(_ => _.Id == id);
        //    bool res = data.Remove(obj);
        //}

        //public void Create(Lesson Item)
        //{            
        //    data.Remove(Item);
        //    data.Add(Item);
        //}

        //public void Create_New(Lesson Item)
        //{            
        //    data.Add(Item);
        //}

        //public void Update(Lesson Item)
        //{
        //    var res = data.Find(x => x.Id == Item.Id);
        //    data.Remove(res);
        //    data.Add(Item);

        //}

        //public void Update_Info(int id,int group)
        //{
        //    Lesson res = data.Find(x => x.Id == id);
        //    Lesson newstudent= new Lesson() { Id=res.Id,Name=res.Name,Surname=res.Surname,Group=group};
        //    data.Remove(res);                   
        //    data.Add(newstudent);
        //}

        //public bool Exist(int id)
        //{
        //    var res = data.Find(x => x.Id == id);
        //    if (res == null)
        //    {
        //        return false;
        //    }
        //    else
        //        return true;
        //}
    }
}
