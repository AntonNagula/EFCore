using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace EFCore.Infrastructure.Data.Mappers
{
    public static class Map
    {
        public static General_Info FromStudentToGeneral_Info(this Student item)
        {
            return new General_Info
            {
                Id = item.Id,
                Name = item.Name,
                Surname = item.Surname
            };
        }

        public static Student FromGeneral_InfoToStudent(this General_Info item)
        {
            return new Student
            {                
                Name = item.Name,
                Surname = item.Surname
            };
        }
        
    }
}
