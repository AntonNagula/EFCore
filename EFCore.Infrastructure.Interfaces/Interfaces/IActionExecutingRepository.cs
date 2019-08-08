using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Infrastructure.Interfaces.Interfaces
{
    public interface IActionExecutingRepository
    {
        List<ActionExecuting> Get();
        void Add(ActionExecuting item);
    }
}
