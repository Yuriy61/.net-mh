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
    public class AdvController : BasicController
    {
        MldAdvDal advDal = new MldAdvDal();

        #region 添加
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        public ActionResult Index()
        {
            ViewBag.Error = "none";
            return View();
        }

        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        [HttpPost]
        public ActionResult Index(string title,string subhead, int advType, string link, HttpPostedFileBase img, int isshow, int priority)
        {
            ViewBag.Error = "none";
            string imgUrl = "";
            if (img != null && img.ContentLength > 0)
            {
                UploadFileResult result = img.FileUpLoad("img", 1024 * 1024 * 4, "images");
                if (!result.Ok)
                {
                    ViewBag.Error = result.Data;
                }
                else
                {
                    imgUrl = result.Data;
                    MldAdv model = new MldAdv();
                    model.AdvType = advType;
                    model.Link = link;
                    model.Img = imgUrl;
                    model.IsShow = isshow;
                    model.Priority = priority;
                    model.Title = title;
                    model.SubHead = subhead;
                    if (advDal.Add(model) > 0)
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
                ViewBag.Error = "Please select the picture to upload";
            }
            return View();
        }
        #endregion

        #region 修改
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        public ActionResult Edit(int id)
        {
            ViewBag.Error = "none";
            return View(advDal.Query(id));
        }
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        [HttpPost]
        public ActionResult Edit(int id,string title,string subhead, int advType, string link, HttpPostedFileBase img, int isshow, int priority)
        {
            ViewBag.Error = "none";
            string imgUrl = "";
            if (img != null && img.ContentLength > 0)
            {
                UploadFileResult result = img.FileUpLoad("img", 1024 * 1024 * 4, "images");
                if (!result.Ok)
                {
                    ViewBag.Error = result.Data;
                }
                else
                {
                    imgUrl = result.Data;
                }
            }

            MldAdv model = advDal.Query(id);
            model.AdvType = advType;
            model.Link = link;
            model.IsShow = isshow;
            model.Priority = priority;
            model.ID = id;
            model.SubHead = subhead;
            model.Title = title;
            if (!string.IsNullOrEmpty(imgUrl))
            {
                model.Img = imgUrl;
            }

            if (advDal.Update(model))
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
            if (advDal.Delete(id))
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
            List<AMW.Model.Entity.MldAdv> list = new List<MldAdv>();
            count = advDal.QueryInt("1=1");
            int pageCount = (count + 20 - 1) / 20;
            list = advDal.QueryList(pageIndex, pageSize, "id", "id desc", "1=1");
            
            Dictionary<string, object> dic = new Dictionary<string, object>();
            ViewBag.Pager = new AMW.Model.Pager() { PageSize = pageSize, PageCount = pageCount, PageIndex = pageIndex, SubmitLink = "/WebAdmin/Adv/List", List = dic };
            return View(list);
        }
        #endregion
        
    }
}