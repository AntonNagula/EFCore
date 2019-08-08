using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using EFCore.Domain.Core.Interfaces;
namespace EFCore.App_Start
{
    public static class AppInit
    {
        public static void Initialize()
        {
            using (var scope = GlobalConfiguration.Configuration.DependencyResolver.BeginScope())
            {
                var service = (IDomainInitializationService)scope.GetService(typeof(IDomainInitializationService));

                service.Initialization();
            }
        }
    }
}