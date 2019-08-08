using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EFCore.Domain.Core;
using EFCore.Models;
namespace EFCore
{
    public static class AppMapers
    {
        public static DomainGeneral ToDomainstudent(this AppStudent app)
        {
            return new DomainGeneral
            {                
                Name=app.Name,
                Surname=app.Surname
            };
        }
    }
}