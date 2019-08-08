using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using DependencyInjection;
using DependencyInjection.Modules;
using EFCore.Domain.Core.Interfaces;

namespace EFCore
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            Register<ContextModule>(container);
            //Register<RepositoryModule>(container);
            Register<ServiceModule>(container);
            Register<DataModuls>(container);
            Register<InitializationModule>(container);
            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        public static void Register<T>(IUnityContainer container) where T : IModule, new()
        {            
            new T().Register(container);
        }
    }
}