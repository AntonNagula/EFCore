using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EFCore.Validators;
using FluentValidation.Attributes;
namespace EFCore.Models
{
    [Validator(typeof(StudentValidator))]
    public class AppStudent
    {        
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}