using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using EFCore.Infrastructure.Data;

namespace DependencyInjection.Modules
{
    public class FilterContext : IModule
    {
        public void Register(IUnityContainer container)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StudentContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["FilterContext"].ConnectionString);

            container.RegisterType<StudentContext>(new HierarchicalLifetimeManager(), new InjectionConstructor(optionsBuilder.Options));
        }
    }
}
