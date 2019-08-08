using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EFCore.Domain.Core.Interfaces;
using EFCore.Domain.Core;
using EFCore.Filters;
using EFCore.Attributes;
using EFCore.Domain.Core.FiltersInfo;
using EFCore.Models;

namespace EFCore.Controllers
{
    [RoutePrefix("Students")]
    [ModelValidationFilter, MyActionFilter,ExceptionLogger]
    public class StudentsController : ApiController
    {
        // GET api/values
        public readonly IService students;
        public StudentsController(IService service)
        {
            students = service;
        }

        // GET api/values
        [HttpGet, Route("")]
        public IEnumerable<DomainGeneral> Get()
        {
            
            return students.GetStudents();
        }

        [HttpPost, Route("")]
        public void Create_Student([FromBody]AppStudent value)
        {
            students.Create(value.ToDomainstudent());
        }


        [HttpDelete, Route("{id}")]
        public void Delete_Student(int id)
        {
            students.Delete_Student(id);
        }

        [HttpGet, Route("{id}/lessons")]
        public IList<DomainLesson> Get_lessons(int Id)
        {
            if (students.Get_Lesson(Id).Count >1)
                throw new Exception("too much");
            return students.Get_Lesson(Id);
        }


        [HttpPost, Route("{id}/lessons")]
        public void Create_Lesson(int id, [FromBody]AppLesson lesson)
        {
            DomainLesson Lesson = new DomainLesson { Name=lesson.Name, StudentId=id};
            students.Create_Lesson(Lesson);
        }

        [HttpDelete, Route("{id}/lessons/{LessonId}")]
        public void Delete_Lesson(int id,int LessonId)
        {            
            students.Delete_Lesson(LessonId);
        }

    }
}
