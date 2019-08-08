using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using EFCore.Domain.Core;
using EFCore.Domain.Core.FiltersInfo;

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

        public static ExceptionDetails ToExceptionDetails(this Exceptions item)
        {
            return new ExceptionDetails
            {                
                Id=item.Id,
                ActionName=item.ActionName,
                ControllerName=item.ControllerName,
                ExceptionMessage=item.ExceptionMessage,
                Date=item.Date,
                StackTrace=item.StackTrace                 
            };
        }

        public static Exceptions ToExceptions(this ExceptionDetails item)
        {
            return new Exceptions
            {                
                ActionName = item.ActionName,
                ControllerName = item.ControllerName,
                ExceptionMessage = item.ExceptionMessage,
                Date = item.Date,
                StackTrace = item.StackTrace
            };
        }

        public static ActionExecutingDetails ToExecutingDetails(this ActionExecuting item)
        {
            return new ActionExecutingDetails
            {
                Id = item.Id,
                ActionName = item.ActionName,
                ControllerName = item.ControllerName,
                Date = item.Date,    
            };
        }

        public static ActionExecuting ToActionExecuting(this ActionExecutingDetails item)
        {
            return new ActionExecuting
            {
                ActionName = item.ActionName,
                ControllerName = item.ControllerName,
                Date = item.Date,
            };
        }
    }
}
