using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AMW.DB.SQLSERVER;
using MyWeb.Helper.Global;
using AMW.Model.Entity;
using AMW.Model.Enum;

namespace MyWeb.Areas.WebAdmin.Controllers
{
    public class BasicController : Controller
    {
        public static MldAdmin CurrentAdmin
        {
            get
            {
                MldAdmin model = null;
                if (WebSiteHelper.Context.User.Identity.IsAuthenticated)
                {
                    model = WebSiteHelper.Context.Session["CurAdmin"] as MldAdmin;
                    if (model == null)
                    {
                        model = DBHelper.From("MldAdmin a")
                        .Take("a.*")
                        .Where("a.name=@1 and a.islock=0", WebSiteHelper.Context.User.Identity.Name).QueryFirstRow<MldAdmin>();
                        WebSiteHelper.Context.Session["CurAdmin"] = model;
                    }
                }
                return model;
            }
        }
    }
}