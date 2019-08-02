using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.Infrastructure.Data;
using EFCore.Infrastructure.Interfaces.Interfaces;
using Microsoft.Practices.Unity;
namespace DependencyInjection.Modules
{
    public class RepositoryModule: IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IRepository, Repository>(new HierarchicalLifetimeManager());
        }
    }
}
