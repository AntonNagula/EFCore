using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Mvc;
using EFCore.Domain.Core.FiltersInfo;
using EFCore.Domain.Core.Interfaces;

namespace EFCore.Filters
{
    public class MyActionFilter: System.Web.Http.Filters.ActionFilterAttribute
    {
        public MyActionFilter()
        {
          
        }
        public override void OnActionExecuting(HttpActionContext actionContext)
        {

            ActionExecutingDetails action = new ActionExecutingDetails
            {
                Id = 1,
                ActionName = actionContext.Request.Method.ToString(),
                ControllerName = actionContext.ControllerContext.ControllerDescriptor.ControllerName,
                Date = DateTime.Now,
               
            };
            var obj = (IService)actionContext.Request.GetDependencyScope().GetService(typeof(IService));
            obj.AddExecuting(action);
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionContext)
        {
            
        }
    }
}