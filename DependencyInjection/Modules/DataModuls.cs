using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFCore.Infrastructure.Interfaces.Interfaces;
using EFCore.Infrastructure.Data;
using EFCore.Infrastructure.Data.Repositories;
using Microsoft.Practices.Unity;
using Models;
namespace DependencyInjection.Modules
{
    public class DataModuls:IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<IStudentRepository ,StudentRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ILessonRepository, LessonRepository>(new HierarchicalLifetimeManager());
        }
    }
}
