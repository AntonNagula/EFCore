using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.Infrastructure.Interfaces.Interfaces;
using Models;
namespace EFCore.Infrastructure.Data.Repositories
{
    public class LessonRepository:ILessonRepository
    {
        private StudentContext db;

        public LessonRepository()
        {
            db = new StudentContext();
        }

        public LessonRepository(StudentContext db)
        {
            this.db = db;
        }

        public void Create(Lesson item)
        {
            db.Lessons.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Lesson lesson = db.Lessons.Find(id);
            db.Lessons.Remove(lesson);
            db.SaveChanges();
        }

        public IList<Lesson> Get(int id)
        {
            return db.Lessons.Where(x=>x.StudentId==id).ToList();
        }                
    }
}
