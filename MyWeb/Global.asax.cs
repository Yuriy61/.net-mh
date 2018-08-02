using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MyWeb.Attribute;
using AMW.DB.SQLSERVER;
using AMW.Model;
using System.IO;
using log4net.Config;

namespace MyWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            var logCfg = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config");
            XmlConfigurator.ConfigureAndWatch(logCfg);

            new AMW.DB.SQLSERVER.BasicDB().SetConnectionString(ConfigurationManager.ConnectionStrings["sqlconnectionstring"].ConnectionString);

            //new MyWeb.Quart.MyQuartz().Start();
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            var context = HttpContext.Current;
            var exception = context.Server.GetLastError();
            MyWeb.Helper.LogHelper.Error(exception.Message + "|" + exception.Source + "|" + exception.StackTrace);
            /*var context = HttpContext.Current;
            var exception = context.Server.GetLastError();
            if (exception is HttpRequestValidationException)
            {
                context.Server.ClearError();
                Response.Clear();
                Response.StatusCode = 200;
#if DEBUG
                Response.Write(context.Server.HtmlEncode(exception.ToString()));
#else
                Response.Write(@"<html><head><title>:)</title></head><body>:)</body></html>");
#endif
                Response.End();
                return;
            }*/
            Response.Redirect("/ErrorPage/500.html");

        }
    }
}
