using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFCore.Domain.Core.Interfaces;
using EFCore.Domain.Interfaces;
using Microsoft.Practices.Unity;
namespace DependencyInjection.Modules
{
    public class ServiceModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IService, Service>(new HierarchicalLifetimeManager());
        }
    }
}
