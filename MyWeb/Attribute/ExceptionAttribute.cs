using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWeb.Attribute
{
    public class ExceptionAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            Exception exp = filterContext.Exception;
            filterContext.ExceptionHandled = true;
            string controllerName = ((filterContext.RouteData.Values["controller"] as string) + "").ToLower();
            string actionName = ((filterContext.RouteData.Values["action"] as string) + "").ToLower();
            string areaName = ((filterContext.RouteData.DataTokens["area"] as string) + "").ToLower();

            string msgTemplate = "在执行 area [{0}] 的 controller[{1}] 的 action[{2}] 时产生异常,异常原因：{3},异常堆栈：{4}";

            MyWeb.Helper.LogHelper.Error(string.Format(msgTemplate, areaName, controllerName, actionName, exp.Message,exp.StackTrace));
            filterContext.Result = new JsonResult
            {
                Data = new
                {
                    ok = false,
                    error = filterContext.Exception.Message
                }
            };
            base.OnException(filterContext);
        }
    }
}