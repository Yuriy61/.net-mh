using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AMW.Model.Enum;

namespace MyWeb.Attribute
{
    public class CustomUserAuthorizeAttribute : AuthorizeAttribute
    {
        private string AreaName { get; set; }
        private string ControllerName { get; set; }
        private string ActionName { get; set; }
        public CustomUserAuthorizeAttribute(params EnumUserRole[] roles)
        {
            Roles = string.Join(",", roles.Select(r => r.ToString()).ToArray());
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            ControllerName =  ((filterContext.RouteData.Values["controller"] as string)+"").ToLower();
            ActionName = ((filterContext.RouteData.Values["action"] as string)+"").ToLower();
            AreaName = ((filterContext.RouteData.DataTokens["area"] as string) + "").ToLower();
            base.OnAuthorization(filterContext);
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool roleFlag = false;
            foreach (var item in Roles.Split(','))
            {
                if (httpContext.User.IsInRole(item))
                {
                    roleFlag = true;
                    break;
                }
            }
            bool result = roleFlag && httpContext.User.Identity.IsAuthenticated;
            return result;
        }
        
        protected override void HandleUnauthorizedRequest(AuthorizationContext context)
        {
            if (context.HttpContext.Request.IsAjaxRequest())
            {
                context.HttpContext.Response.StatusCode = 200;
                context.Result = new JsonResult
                {
                    Data = new
                    {
                        @ok = false,
                        error = "抱歉，您没有权限操作此功能"
                    },
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
            else
            {
                base.HandleUnauthorizedRequest(context);
                if (AreaName.Equals("") && ControllerName.Equals("home") && ActionName.Equals("index"))
                {
                    context.Result = new RedirectResult("/Account/Login");
                }
                else
                {
                    context.Result = new RedirectResult("/ErrorPage/401.html");
                }
            }
        }  
    }
}