using EFCore.Domain.Core.Interfaces;
using EFCore.Domain.Interfaces.Initialization;
using EFCore.Infrastructure.Data;
using EFCore.Infrastructure.Interfaces.Context;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Modules
{
    public class InitializationModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IDomainInitializationService, DomainInitializationService>(new HierarchicalLifetimeManager());
        }
    }
}
