using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace EFCore.Infrastructure.Interfaces.Interfaces
{
    public interface IStudentRepository
    {
        void Create(General_Info item);

        void Delete(int id);

        IList<General_Info> Get();    
    }
}
