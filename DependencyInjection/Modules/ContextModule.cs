using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using EFCore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Practices.Unity;
using EFCore.Infrastructure.Interfaces.Context;

namespace DependencyInjection.Modules
{
    public class ContextModule:IModule
    {
        public void Register(IUnityContainer container)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StudentContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MyContext"].ConnectionString);

            container.RegisterType<StudentContext>(new HierarchicalLifetimeManager(), new InjectionConstructor(optionsBuilder.Options));

            container.RegisterType<IMyContextInitialization, MyContextInitializationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IStudentProvider, FakeRepository>(new HierarchicalLifetimeManager());
        }
    }
}
