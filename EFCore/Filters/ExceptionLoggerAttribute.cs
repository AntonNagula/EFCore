using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Mvc;
using EFCore.Domain.Core.FiltersInfo;
using EFCore.Domain.Core.Interfaces;

namespace EFCore.Filters
{
    public class ExceptionLoggerAttribute:ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext filterContext)
        {
            ExceptionDetails exc = new ExceptionDetails
            {
                ActionName = filterContext.Request.Method.ToString(),
                ControllerName = filterContext.ActionContext.ControllerContext.ControllerDescriptor.ControllerName.ToString(),
                Date = DateTime.Now,
                ExceptionMessage = filterContext.Exception.Message,
                StackTrace = filterContext.Exception.StackTrace
            };           

            var obj = (IService)filterContext.Request.GetDependencyScope().GetService(typeof(IService));
            obj.AddException(exc);
        }
    }
}