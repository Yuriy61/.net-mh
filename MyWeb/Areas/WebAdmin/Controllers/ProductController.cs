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
    public class ProductController : BasicController
    {
        MldProductDal dal = new MldProductDal();

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
        public ActionResult Index(int cid, string name, string subhead,string profile,string application,string material,string weight,string length,string massOfInertia,string sectionModulus,HttpPostedFileBase profileimg, HttpPostedFileBase img, string content, string datacontent, int allshowflag, int homeshowflag, int iselite, HttpPostedFileBase img1, HttpPostedFileBase img2, HttpPostedFileBase img3, HttpPostedFileBase img4)
        {
            ViewBag.Error = "none";
            ViewBag.Category1 = new MldProductCategoryDal().QueryList("id asc", "tid=@1", 0);
            if (img != null && img.ContentLength > 0)
            {
                UploadFileResult result = img.FileUpLoad("img", 1024 * 1024 * 4, "product");
                if (!result.Ok)
                {
                    ViewBag.Error = result.Data;
                }
                else
                {
                    MldProduct model = new MldProduct();
                    model.Img = result.Data;
                    List<string> imgList = new List<string>();
                    if(img1 != null && img1.ContentLength > 0){
                        UploadFileResult result1 = img1.FileUpLoad("img", 1024 * 1024 * 4, "product");
                        if (result1.Ok) { imgList.Add(result1.Data);  }
                    }
                    if (img2 != null && img2.ContentLength > 0)
                    {
                        UploadFileResult result2 = img2.FileUpLoad("img", 1024 * 1024 * 4, "product");
                        if (result2.Ok) { imgList.Add(result2.Data); }
                    }
                    if (img3 != null && img3.ContentLength > 0)
                    {
                        UploadFileResult result3 = img3.FileUpLoad("img", 1024 * 1024 * 4, "product");
                        if (result3.Ok) { imgList.Add(result3.Data);  }
                    }
                    if (img4 != null && img4.ContentLength > 0)
                    {
                        UploadFileResult result4 = img4.FileUpLoad("img", 1024 * 1024 * 4, "product");
                        if (result4.Ok) { imgList.Add(result4.Data);}
                    }
                    model.Cid = cid;
                    model.Name = name;
                    model.SubHead = subhead;
                    model.Content = content;
                    model.AllShowFlag = allshowflag;
                    model.HomeShowFlag = homeshowflag;
                    model.IsElite = iselite;
                    model.AddTime = DateTime.Now;

                    model.Profile = profile;
                    model.Application = application;
                    model.Material = material;
                    model.Weight = weight;
                    model.Length = length;
                    model.MassOfInertia = massOfInertia;
                    model.SectionModulus = sectionModulus;


                    if (profileimg != null && profileimg.ContentLength > 0)
                    {
                        UploadFileResult result5 = profileimg.FileUpLoad("img", 1024 * 1024 * 4, "product");
                        if (result5.Ok)
                        {
                            model.ProfileImg = result5.Data;
                        }
                    }


                    int id = dal.Add(model);
                    if (id > 0)
                    {
                        MldProductImgDal imgDal = new MldProductImgDal();
                        foreach (var item in imgList)
                        {
                            MldProductImg itemImg = new MldProductImg();
                            itemImg.Img = item;
                            itemImg.Pid = id;
                            imgDal.Add(itemImg);   
                        }
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
            MldProduct model = dal.Query(id);
            MldProductCategoryDal categoryDal = new MldProductCategoryDal();
            MldProductCategory category = categoryDal.Query(model.Cid);
            ViewBag.TopCategoryID = categoryDal.Query(category.Tid).ID;
            ViewBag.Category1 = categoryDal.QueryList("id asc", "tid=@1", 0);
            ViewBag.Category2 = categoryDal.QueryList("id asc", "tid=@1", category.Tid);
            return View(model);
        }
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin, EnumAdminRole.Normal)]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, int cid, string name, string subhead, string profile, string application, string material, string weight, string length, string massOfInertia, string sectionModulus, HttpPostedFileBase profileimg, HttpPostedFileBase img, string content, string datacontent, int allshowflag, int homeshowflag, int iselite)
        {
            ViewBag.Error = "none";
            ViewBag.Category1 = new MldProductCategoryDal().QueryList("id asc", "tid=@1", 0);
            MldProduct model = dal.Query(id);
            string imgUrl = model.Img;
            if (img != null && img.ContentLength > 0)
            {
                UploadFileResult result = img.FileUpLoad("img", 1024 * 1024 * 4, "product");
                if (!result.Ok)
                {
                    ViewBag.Error = result.Data;
                }
                else
                {
                    imgUrl = result.Data;
                }
            }


            
            model.Img = imgUrl;
            model.Cid = cid;
            model.Name = name;
            model.SubHead = subhead;
            model.Content = content;
            model.AllShowFlag = allshowflag;
            model.HomeShowFlag = homeshowflag;
            model.IsElite = iselite;

            model.Profile = profile;
            model.Application = application;
            model.Material = material;
            model.Weight = weight;
            model.Length = length;
            model.MassOfInertia = massOfInertia;
            model.SectionModulus = sectionModulus;

            if (profileimg != null && profileimg.ContentLength > 0)
            {
                UploadFileResult result = profileimg.FileUpLoad("img", 1024 * 1024 * 4, "product");
                if (result.Ok)
                {
                    model.ProfileImg = result.Data;
                }
            }

            if (dal.Update(model))
            {
                ViewBag.Success = "ok";
            }
            else
            {
                ViewBag.Error = "Error";
            }

            MldProductCategoryDal categoryDal = new MldProductCategoryDal();
            model = dal.Query(id);
            MldProductCategory category = categoryDal.Query(model.Cid);
            ViewBag.TopCategoryID = categoryDal.Query(category.Tid).ID;
            ViewBag.Category1 = categoryDal.QueryList("id asc", "tid=@1", 0);
            ViewBag.Category2 = categoryDal.QueryList("id asc", "tid=@1", category.Tid);
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
            List<MldProduct> list = new List<MldProduct>();
            count = dal.QueryInt("1=1");
            int pageCount = (count + 20 - 1) / 20;
            list = dal.QueryList(pageIndex, pageSize, "a.id", "a.id desc", "1=1");
            
            Dictionary<string, object> dic = new Dictionary<string, object>();
            ViewBag.Pager = new AMW.Model.Pager() { PageSize = pageSize, PageCount = pageCount, PageIndex = pageIndex, SubmitLink = "/WebAdmin/Product/List", List = dic };
            return View(list);
        }
        #endregion
        
    }
}