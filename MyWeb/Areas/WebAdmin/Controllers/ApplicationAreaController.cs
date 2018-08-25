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
    public class ApplicationAreaController : BasicController
    {
        MldApplicationAreaDal dal = new MldApplicationAreaDal();

        #region 添加
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        public ActionResult Index()
        {
            ViewBag.Error = "none";
            ViewBag.Category1 = new MldProductCategoryDal().QueryList("id asc", "tid=@1", 0);
            return View();
        }

        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(string name, HttpPostedFileBase homebg, HttpPostedFileBase icon, string subhead, string content ,int homeshowflag)
        {
            ViewBag.Error = "none";

            if (homebg != null && homebg.ContentLength > 0 && icon != null && icon.ContentLength>0)
            {
                UploadFileResult result1 = homebg.FileUpLoad("img", 1024 * 1024 * 4, "applicationarea");
                UploadFileResult result2 = icon.FileUpLoad("img", 1024 * 1024 * 4, "applicationarea");
                if (!result1.Ok || !result2.Ok)
                {
                    ViewBag.Error = "图片上传错误";
                }
                else
                {
                    MldApplicationArea model = new MldApplicationArea();
                    model.AddTime = DateTime.Now;
                    model.Content = content;
                    model.HomeBg = result1.Data;
                    model.Icon = result2.Data;
                    model.Name = name;
                    model.SubHead = subhead;
                    model.HomeShowFlag = homeshowflag;

                    int id = dal.Add(model);
                    if (id > 0)
                    {
                        ViewBag.Success = "ok";
                    }
                    else
                    {
                        ViewBag.Error = "Error";
                    }
                }
            }
            else
            {
                ViewBag.Error = "请选择要上传的背景图和图标";
            }
            return View();
        }
        #endregion

        #region 修改
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        public ActionResult Edit(int id)
        {
            ViewBag.Error = "none";
            MldApplicationArea model = dal.Query(id);
            return View(model);
        }
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, string name, HttpPostedFileBase homebg, HttpPostedFileBase icon, string subhead, string content, int homeshowflag)
        {
            ViewBag.Error = "none";
            MldApplicationArea model = dal.Query(id);
            string imgUrl1 = model.HomeBg;
            if (homebg != null && homebg.ContentLength > 0)
            {
                UploadFileResult result = homebg.FileUpLoad("img", 1024 * 1024 * 4, "applicationarea");
                if (!result.Ok)
                {
                    ViewBag.Error = result.Data;
                }
                else
                {
                    imgUrl1 = result.Data;
                }
            }
            string imgUrl2 = model.Icon;
            if (icon != null && icon.ContentLength > 0)
            {
                UploadFileResult result = icon.FileUpLoad("img", 1024 * 1024 * 4, "applicationarea");
                if (!result.Ok)
                {
                    ViewBag.Error = result.Data;
                }
                else
                {
                    imgUrl2 = result.Data;
                }
            }

            model.Content = content;
            model.HomeBg = imgUrl1;
            model.Icon = imgUrl2;
            model.Name = name;
            model.SubHead = subhead;
            model.HomeShowFlag = homeshowflag;

            if (dal.Update(model))
            {
                ViewBag.Success = "ok";
            }
            else
            {
                ViewBag.Error = "Error";
            }

            model = dal.Query(id);
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
            List<MldApplicationArea> list = new List<MldApplicationArea>();
            count = dal.QueryInt("1=1");
            int pageCount = (count + 20 - 1) / 20;
            list = dal.QueryList(pageIndex, pageSize, "id", "id desc", "1=1");
            
            Dictionary<string, object> dic = new Dictionary<string, object>();
            ViewBag.Pager = new AMW.Model.Pager() { PageSize = pageSize, PageCount = pageCount, PageIndex = pageIndex, SubmitLink = "/WebAdmin/ApplicationArea/List", List = dic };
            return View(list);
        }
        #endregion
        
    }
}