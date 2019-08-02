using System;
using EFCore.Infrastructure.Data.Repositories;
using EFCore.Infrastructure.Interfaces.Interfaces;
namespace EFCore.Infrastructure.Data
{
    public class UnitOfWork:IUnitOfWork,IDisposable
    {
        private StudentContext db = new StudentContext();
        private LessonRepository LessonRepo;
        private StudentRepository StudentRepo;

        public UnitOfWork()
        {

        }
        public ILessonRepository Lessons
        {
            get
            {
                if (LessonRepo == null)
                    LessonRepo = new LessonRepository(db);
                return LessonRepo;
            }
        }

        public IStudentRepository Students
        {
            get
            {
                if (StudentRepo == null)
                    StudentRepo = new StudentRepository(db);
                return StudentRepo;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
