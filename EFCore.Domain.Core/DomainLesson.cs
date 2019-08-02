using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Domain.Core
{
    public class DomainLesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? StudentId { get; set; }
    }
}
