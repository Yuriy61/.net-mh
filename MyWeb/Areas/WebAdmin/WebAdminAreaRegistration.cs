using System.Web.Mvc;

namespace MyWeb.Areas.WebAdmin
{
    public class WebAdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "WebAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "WebAdmin_default",
                "WebAdmin/{controller}/{action}/{id}",
                new { controller="Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "MyWeb.Areas.WebAdmin.Controllers" }
            );
        }
    }
}