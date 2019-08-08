using EFCore.Infrastructure.Interfaces.Interfaces;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.Infrastructure.Data.Mappers;
namespace EFCore.Infrastructure.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private StudentContext db;
        
        public StudentRepository(StudentContext db)
        {
            this.db = db;
        }

        public void Create(General_Info item)
        {
            db.Students.Add(item.FromGeneral_InfoToStudent());
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Student st = db.Students.Find(id);
            db.Students.Remove(st);
            db.SaveChanges();
        }

        public IList<General_Info> Get()
        {
            return db.Students.Select(x => x.FromStudentToGeneral_Info()).ToList();
        }
        
    }
}
