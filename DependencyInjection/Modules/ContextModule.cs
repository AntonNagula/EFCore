using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFCore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Practices.Unity;
namespace DependencyInjection.Modules
{
    public class ContextModule:IModule
    {
        public void Register(IUnityContainer container)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StudentContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StudentContext;Trusted_Connection=True;");

            container.RegisterType<StudentContext>(new HierarchicalLifetimeManager(), new InjectionConstructor(optionsBuilder.Options));
        }
    }
}
