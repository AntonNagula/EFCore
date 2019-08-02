using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using EFCore.Domain.Core;
namespace EFCore.Domain.Interfaces.Mappers
{
    public static class DomainMappers
    {
        public static DomainGeneral ToDomainGeneral(this General_Info @this)
        {
            return new DomainGeneral
            {
                Id = @this.Id,
                Name = @this.Name,
                Surname = @this.Surname
            };
        }

        public static General_Info ToGeneral_Info(this DomainGeneral @this)
        {
            return new General_Info
            {
                Id = @this.Id,
                Name = @this.Name,
                Surname = @this.Surname
            };
        }
        
        public static DomainLesson ToDomainLesson(this Lesson @this)
        {
            return new DomainLesson
            {
                Id = @this.Id,
                Name = @this.Name,
                StudentId=@this.StudentId                
            };
        }


        public static Lesson FromDomLesson_ToLesson(this DomainLesson item)
        {
            return new Lesson
            {                
                Name = item.Name,
                StudentId = item.StudentId
            };
        }
    }
}
