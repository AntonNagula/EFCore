using EFCore.Infrastructure.Interfaces.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Infrastructure.Data.Repositories
{
    public class ActionExecutingRepository : IActionExecutingRepository
    {
        private StudentContext db;

        public ActionExecutingRepository(StudentContext db)
        {
            this.db = db;
        }

        public List<ActionExecuting> Get()
        {
            return db.ActionExecutingDetails.ToList();
        }
        public void Add(ActionExecuting item)
        {
            db.ActionExecutingDetails.Add(item);
            db.SaveChanges();
        }
    }
}
