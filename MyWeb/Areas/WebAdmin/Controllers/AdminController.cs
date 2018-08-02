using AMW.DB.SQLSERVER;
using MyWeb.Attribute;
using AMW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWeb.Helper;
using AMW.Model.Enum;
using AMW.Model.Entity;
using AMW.DAL;

namespace MyWeb.Areas.WebAdmin.Controllers
{
    public class AdminController : BasicController
    {
        MldAdminDal adminDal = new MldAdminDal();

        #region 管理员管理-添加管理员
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        public ActionResult Index()
        {
            ViewBag.Error = "none";
            return View();
        }

        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(string name, string pwd)
        {
            ViewBag.Error = "none";
            using (BasicDB db = new BasicDB(false))
            {
                if (string.IsNullOrEmpty(name))
                {
                    ViewBag.Error = "Account is not null";
                }
                else
                {
                    if (string.IsNullOrEmpty(pwd))
                    {
                        ViewBag.Error = "Pwd is not null";
                    }
                    else
                    {
                        if (adminDal.Exists("name=@1",name))
                        {
                            ViewBag.Error = "The account has already existed";
                        }
                        else
                        {
                            MldAdmin model = new MldAdmin() { Rid = (int)EnumAdminRole.Normal, Name =name, Pwd = Common.Encryption.GetAdminPwd(pwd),AddTime = DateTime.Now,IsLock = 0 };

                            if (adminDal.Add(model) > 0)
                            {
                                ViewBag.Success = "ok";
                            }
                            else
                            {
                                ViewBag.Error = "Error";
                            }
                        }
                    }
                    
                }
            }
            return View();
        }
        #endregion

        #region 管理员管理-修改管理员 
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        public ActionResult Edit(int id)
        {
            using (BasicDB db = new BasicDB(false))
            {
                ViewBag.Error = "none";

                return View(adminDal.Query(id));
            }
        }

        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        [HttpPost]
        public ActionResult Edit(int id, string name, string pwd, int islock)
        {
            ViewBag.Error = "none";
            using (BasicDB db = new BasicDB(false))
            {
                if (adminDal.Exists("name=@1 and id!=@2", name, id))
                {
                    ViewBag.Error = "The account has already existed";
                }
                else
                {
                    if (string.IsNullOrEmpty(name))
                    {
                        ViewBag.Error = "Account is not null";
                    }
                    else
                    {
                        MldAdmin model = new MldAdmin();
                        model.ID = id;
                        model.Name = name;
                        
                        model.IsLock = islock;
                        if (!string.IsNullOrEmpty(pwd))
                        {
                            model.Pwd = Common.Encryption.GetAdminPwd(pwd);
                        }
                        if (adminDal.Update(model))
                        {
                            ViewBag.Success = "ok";
                        }
                        else
                        {
                            ViewBag.Error = "Error";
                        }
                    }
                    
                }
                return View("Edit", adminDal.Query(id));
            }
        }
        #endregion

        #region 管理员管理-管理员列表
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        public ActionResult List(int pageSize = 20, int pageIndex = 1)
        {
            if (pageIndex <= 0)
            {
                pageIndex = 1;
            }
            using (BasicDB db = new BasicDB(false))
            {
                int count = adminDal.QueryInt("id!=1");
                int pageCount = (count + pageSize - 1) / pageSize;
                List<MldAdmin> list = adminDal.QueryList(pageIndex,pageSize,"id","id desc","id!=1");
                ViewBag.Pager = new AMW.Model.Pager() { PageSize = pageSize, PageCount = pageCount, PageIndex = pageIndex, SubmitLink = "/WebAdmin/Admin/List" };
                return View(list);
            }
        }
        #endregion

        #region 删除管理员
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        public ActionResult Delete(int id)
        {
            using (BasicDB db = new BasicDB(false))
            {
                if (adminDal.Delete(id))
                {
                    return Json(new JsonResultModel() { ok = true });
                }
                else
                {
                    return Json(new JsonResultModel() { ok = false, error = "Error" });
                }
            }
        }
        #endregion
    }
}