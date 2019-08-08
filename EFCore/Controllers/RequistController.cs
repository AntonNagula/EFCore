using System.Collections.Generic;
using System.Web.Http;
using EFCore.Domain.Core.Interfaces;
using EFCore.Domain.Core.FiltersInfo;
namespace EFCore.Controllers
{
    public class RequistController : ApiController
    {
        public readonly IService students;
        public RequistController(IService service)
        {
            students = service;
        }

        [HttpGet]
        public IList<ActionExecutingDetails> Get_Exceptions()
        {
            return students.Get_ActionExecuting();
        }
    }
}
