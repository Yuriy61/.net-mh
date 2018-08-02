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
    public class NewsController : BasicController
    {
        MldNewsDal dal = new MldNewsDal();

        #region 添加
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin)]
        public ActionResult Index(int newsType)
        {
            ViewBag.Error = "none";
            ViewBag.NewsType = newsType;
            return View();
        }

        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin)]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(int newsType, string title,string subHead,HttpPostedFileBase img,string content, int isshow, int priority)
        {
            ViewBag.Error = "none";
            ViewBag.NewsType = newsType;
            MldNews model = new MldNews();

            if (img != null && img.ContentLength > 0)
            {
                UploadFileResult result = img.FileUpLoad("img", 1024 * 1024 * 4, "images");
                if (!result.Ok)
                {
                    ViewBag.Error = result.Data;
                }
                else
                {
                    model.Img = result.Data;
                }
            }

            model.AddTime = DateTime.Now;
            model.Content = content;
            model.IsShow = isshow;
            model.NewsType = newsType;
            model.Priority = priority;
            model.SubHead = subHead;
            model.Title = title;

            if (dal.Add(model) > 0)
            {
                ViewBag.Success = "ok";
            }
            else
            {
                ViewBag.Error = "添加失败";
            }
            return View();
        }
        #endregion

        #region 修改
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin)]
        public ActionResult Edit(int id)
        {
            ViewBag.Error = "none";
            return View(dal.Query(id));
        }
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin)]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, int newsType, string title, string subHead,HttpPostedFileBase img, string content, int isshow, int priority)
        {
            ViewBag.Error = "none";
            MldNews model = dal.Query(id);
            if (img != null && img.ContentLength > 0)
            {
                UploadFileResult result = img.FileUpLoad("img", 1024 * 1024 * 4, "images");
                if (!result.Ok)
                {
                    ViewBag.Error = result.Data;
                }
                else
                {
                    model.Img = result.Data;
                }
            }
            model.NewsType = newsType;
            model.SubHead = subHead;
            model.Content = content;
            model.IsShow = isshow;
            model.Priority = priority;
            model.Title = title;
            if (dal.Update(model))
            {
                ViewBag.Success = "ok";
            }
            else
            {
                ViewBag.Error = "添加失败";
            }
            return View(model);
        }
        #endregion

        #region 删除
        [HttpPost]
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin)]
        public ActionResult Del(int id)
        {
            if (dal.Delete(id))
            {
                return Json(new JsonResultModel() { ok = true });
            }
            else
            {
                return Json(new JsonResultModel() { ok = false, error = "删除失败" });
            }
        }
        #endregion


        #region 列表
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin)]
        public ActionResult List(int newsType, int pageSize = 20, int pageIndex = 1)
        {
            if (pageIndex <= 0)
            {
                pageIndex = 1;
            }
            ViewBag.Error = "none";

            int count = dal.QueryInt("newsType=@1",newsType);
            int pageCount = (count + 20 - 1) / 20;
            List<AMW.Model.Entity.MldNews> list = dal.QueryList(pageIndex, pageSize, "id", "id desc", "newsType=@1", newsType);
            Dictionary<string, object> dic = new Dictionary<string, object>();
            ViewBag.Pager = new AMW.Model.Pager() { PageSize = pageSize, PageCount = pageCount, PageIndex = pageIndex, SubmitLink = "/WebAdmin/News/List", List = dic };
            ViewBag.NewsType = newsType;
            return View(list);
        }
        #endregion
        
    }
}