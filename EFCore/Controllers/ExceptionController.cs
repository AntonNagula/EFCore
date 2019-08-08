using System.Collections.Generic;
using System.Web.Http;
using EFCore.Domain.Core.Interfaces;
using EFCore.Domain.Core.FiltersInfo;
namespace EFCore.Controllers
{
    public class ExceptionController : ApiController
    {
        public readonly IService students;
        public ExceptionController(IService service)
        {
            students = service;
        }

        [HttpGet]
        public IList<ExceptionDetails> Get_Exceptions()
        {
            return students.Get_Exceptions();
        }
    }
}
