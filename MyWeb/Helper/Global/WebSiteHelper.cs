using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Microsoft.Owin.Extensions;
using System.Security.Claims;

namespace MyWeb.Helper.Global
{
    /// <summary>
    /// 网站管理通用类
    /// </summary>
    public class WebSiteHelper
    {
        public readonly static string Title = "Dderservices 后台管理系统";
        public readonly static string CopyRight = "© 2018 Dderservices. All Rights Reserved | Technical Support by Dderservices";
        public readonly static string Logo = "/Content/webadmin/Logo.png";

        /// <summary>
        /// 获取HttpContext对象
        /// </summary>
        public static HttpContext Context { get { return HttpContext.Current; } }
        private static IAuthenticationManager AuthenticationManager
        {
            get
            {
                return Context.GetOwinContext().Authentication;
            }
        }

        public static void Login(string name, string role, bool isPersistent)
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, name));
            claims.Add(new Claim(ClaimTypes.Role, role));
            ClaimsIdentity ci = new ClaimsIdentity(claims, DefaultAuthenticationTypes.ApplicationCookie);
            AuthenticationProperties properties = new AuthenticationProperties();
            properties.IsPersistent = isPersistent;
            AuthenticationManager.SignIn(properties, ci);
        }

        public static void LogOut()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }
    }
}