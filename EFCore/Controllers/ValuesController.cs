using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EFCore.Domain.Core.Interfaces;
using EFCore.Domain.Core;
namespace EFCore.Controllers
{
    [RoutePrefix("Students")]
    public class ValuesController : ApiController
    {
        // GET api/values
        public readonly IService students;
        public ValuesController(IService service)
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
        public void Create_Student([FromBody]DomainGeneral value)
        {
            students.Create(value);
        }


        [HttpDelete, Route("{id}")]
        public void Delete_Student(int id)
        {
            students.Delete_Student(id);
        }

        [HttpGet, Route("{id}/lessons")]
        public IList<DomainLesson> Get_lessons(int Id)
        {
            return students.Get_Lesson(Id);
        }


        [HttpPost, Route("{id}")]
        public void Create_Lesson(int id, [FromBody]string value)
        {
            DomainLesson lesson = new DomainLesson { Name=value, StudentId=id};
            students.Create_Lesson(lesson);
        }

        [HttpDelete, Route("{id}/lessons/{LessonId}")]
        public void Delete_Lesson(int id,int LessonId)
        {            
            students.Delete_Lesson(LessonId);
        }

    }
}
