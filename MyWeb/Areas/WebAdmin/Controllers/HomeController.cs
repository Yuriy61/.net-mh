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
    public class HomeController : BasicController
    {
        MldWebSiteDal websiteDal = new MldWebSiteDal();
        MldAdminDal adminDal = new MldAdminDal();

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        public ActionResult Welcome()
        {
            return View();
        }

        #region 网站设置-网站信息设置
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        public ActionResult Index()
        {
            ViewBag.Error = "none";
            return View(Helper.ApplicationHelper.CurWebsite);
        }

        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(string title, HttpPostedFileBase logo, string keyword, string description, string pagedown)
        {
            ViewBag.Error = "none";
            MldWebSite model = Helper.ApplicationHelper.CurWebsite;
            if (logo != null && logo.ContentLength > 0)
            {
                UploadFileResult result = logo.FileUpLoad("img", 1024 * 1024 * 4, "images");
                if (!result.Ok)
                {
                    ViewBag.Error = result.Data;
                }
                else
                {
                    model.Logo = result.Data;
                }
            }

            model.Title = title;
            model.KeyWord = keyword;
            model.Description = description;
            model.Content = pagedown;

            using (BasicDB db = new BasicDB(false))
            {
                if (websiteDal.Update(model))
                {
                    ViewBag.Success = "ok";
                    Helper.ApplicationHelper.CurWebsite = model;
                }
                else
                {
                    ViewBag.Error = "Error";
                }
            }
            return View(Helper.ApplicationHelper.CurWebsite);
        }
        #endregion

        #region 管理员登录
        public ActionResult Login()
        {
            ViewBag.Error = "";
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password, int isPersistent = 0)
        {
            using (BasicDB db = new BasicDB(false))
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    ViewBag.Error = "The username and password can not be empty";
                }
                else
                {

                    MldAdmin model = adminDal.Query("name=@1 and pwd=@2", username, Common.Encryption.GetAdminPwd(password));
                    if (model != null)
                    {
                        if (model.IsLock == 1)
                        {
                            ViewBag.Error = "Sorry, your account has been locked up";
                        }
                        else
                        {

                            WebSiteHelper.Login(model.Name, ((EnumAdminRole)model.Rid).ToString(), Convert.ToBoolean(isPersistent));
                            model.LastLoginTime = DateTime.Now;
                            model.LastLoginIP = HttpHelper.Context.Request.UserHostAddress;
                            adminDal.Update(model);
                            return Redirect("/WebAdmin/Home/Welcome");
                        }
                    }
                    else
                    {
                        ViewBag.Error = "The username or password is incorrect, please reenter it";
                    }
                }
            }
            return View();
        }
        #endregion

        #region 注销
        public ActionResult LogOut()
        {
            WebSiteHelper.LogOut();
            return Redirect("/WebAdmin/Home/login");
        }
        #endregion

        #region 修改密码
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        public ActionResult EditPwd()
        {
            ViewBag.Error = "none";
            return View();
        }
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult EditPwd(string oldpwd, string newpwd, string anewpwd)
        {
            ViewBag.Error = "none";
            using (BasicDB db = new BasicDB(false))
            {
                AMW.Model.Entity.MldAdmin model = CurrentAdmin;
                if (model.Pwd.Equals(Common.Encryption.GetAdminPwd(oldpwd)))
                {
                    if (newpwd.Equals(anewpwd) && !string.IsNullOrEmpty(newpwd))
                    {
                        model.Pwd = Common.Encryption.GetAdminPwd(newpwd);

                        if (adminDal.Update(model))
                        {
                            ViewBag.Success = "ok";
                        }
                        else
                        {
                            ViewBag.Error = "Edit Password Error";
                        }
                    }
                    else
                    {
                        ViewBag.Error = "The new password entered two times is inconsistent, and the password changes failed.";
                    }
                }
                else
                {
                    ViewBag.Error = "The old password you entered is incorrect, and the password is changed.";
                }
            }
            return View();
        }
        #endregion

    }
}