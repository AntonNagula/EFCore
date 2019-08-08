using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Infrastructure.Interfaces.Interfaces
{
    public interface IExceptionRepository
    {
        List<Exceptions> Get();
        void Add(Exceptions item);
    }
}
