using AMW.DAL;
using AMW.Model;
using AMW.Model.Entity;
using AMW.Model.Enum;
using Common;
using MyWeb.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWeb.Areas.WebAdmin.Controllers
{
    public class ProductCategoryController : BasicController
    {
        MldProductCategoryDal dal = new MldProductCategoryDal();

        #region 添加
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        public ActionResult Index()
        {
            ViewBag.Error = "none";
            return View();
        }

        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        [HttpPost]
        public ActionResult Index(int tid,string name,int order)
        {
            ViewBag.Error = "none";
            MldProductCategory model = new MldProductCategory();
            model.Tid = tid;
            model.Name = name;
            model.Order = order;
            if (dal.Add(model) > 0)
            {
                ViewBag.Success = "ok";
            }
            else
            {
                ViewBag.Error = "Error";
            }
            return View();
        }
        #endregion

        #region 修改
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        public ActionResult Edit(int id)
        {
            ViewBag.Error = "none";
            return View(dal.Query(id));
        }
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        [HttpPost]
        public ActionResult Edit(int id, int tid, string name, int order)
        {
            ViewBag.Error = "none";
          
            MldProductCategory model = dal.Query(id);
            model.Tid = tid;
            model.Name = name;
            model.Order = order;
           
            if (dal.Update(model))
            {
                ViewBag.Success = "ok";
            }
            else
            {
                ViewBag.Error = "Error";
            }
            return View(model);

        }
        #endregion

        #region 删除
        [HttpPost]
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        public ActionResult Del(int id)
        {
            if (dal.Delete(id))
            {
                return Json(new JsonResultModel() { ok = true });
            }
            else
            {
                return Json(new JsonResultModel() { ok = false, error = "Error" });
            }
        }
        #endregion

        #region 列表
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        public ActionResult List(int pageSize = 20, int pageIndex = 1)
        {
            if (pageIndex <= 0)
            {
                pageIndex = 1;
            }
            ViewBag.Error = "none";
            int count = 0;
            List<MldProductCategory> list = new List<MldProductCategory>();
            count = dal.QueryInt("1=1");
            int pageCount = (count + 20 - 1) / 20;
            list = dal.QueryList(pageIndex, pageSize, "id", "id desc", "1=1");
            
            Dictionary<string, object> dic = new Dictionary<string, object>();
            ViewBag.Pager = new AMW.Model.Pager() { PageSize = pageSize, PageCount = pageCount, PageIndex = pageIndex, SubmitLink = "/WebAdmin/ProductCategory/List", List = dic };
            return View(list);
        }
        #endregion

        public ActionResult Query(int id)
        {
            return Json(new JsonResultModel() { ok = true, data = dal.QueryList("id asc", "tid=@1", id) });
        }
        
    }
}