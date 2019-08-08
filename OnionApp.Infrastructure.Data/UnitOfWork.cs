using System;
using EFCore.Infrastructure.Data.Repositories;
using EFCore.Infrastructure.Interfaces.Interfaces;
namespace EFCore.Infrastructure.Data
{
    public class UnitOfWork:IUnitOfWork,IDisposable
    {
        private StudentContext db;
        private LessonRepository LessonRepo;
        private StudentRepository StudentRepo;
        private ActionExecutingRepository ActionExecutingRepo;
        private ExceptionRepository ExceptionRepo;
        public UnitOfWork(StudentContext st)
        {
            db = st;
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

        public IActionExecutingRepository Executings
        {
            get
            {
                if (ActionExecutingRepo == null)
                    ActionExecutingRepo = new ActionExecutingRepository(db);
                return ActionExecutingRepo;
            }
        }

        public IExceptionRepository Exceptions
        {
            get
            {
                if (ExceptionRepo == null)
                    ExceptionRepo = new ExceptionRepository(db);
                return ExceptionRepo;
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
