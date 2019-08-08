using EFCore.Infrastructure.Interfaces.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Infrastructure.Data.Repositories
{
    public class ExceptionRepository: IExceptionRepository
    {
        private StudentContext db;

        public ExceptionRepository(StudentContext db)
        {
            this.db = db;
        }

        public List<Exceptions> Get()
        {
            return db.Exceptions.ToList();
        }

        public void Add(Exceptions item)
        {
            db.Exceptions.Add(item);
            db.SaveChanges();
        }
    }
}
