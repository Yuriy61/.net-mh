using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using MyWeb.Attribute;
using AMW.DB.SQLSERVER;
using Common;
using AMW.Model;
using AMW.Model.Enum;
using AMW.Model.Entity;
using AMW.DAL;
using MyWeb.Helper.Global;

namespace MyWeb.Areas.WebAdmin.Controllers
{
    public class WebsiteContentController : BasicController
    {

        AMW.DAL.MldPageDal dal = new MldPageDal();
        #region 网站内容设置
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        public ActionResult Index(int id)
        {
            ViewBag.Error = "none";
            return View(dal.Query(id));
        }

        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(int id, string title,string keyword,string description,string content)
        {
            ViewBag.Error = "none";
            MldPage model = dal.Query(id);

            model.Title = title;
            model.Content = content;
            model.KeyWord = keyword;
            model.Description = description;

            using (BasicDB db = new BasicDB(false))
            {
                if (dal.Update(model))
                {
                    ViewBag.Success = "ok";
                }
                else
                {
                    ViewBag.Error = "Error";
                }
            }
            return View(model);
        }
        #endregion

    }
}