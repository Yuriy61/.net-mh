using AMW.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AMW.Model.Entity;
using MyWeb.Helper;
using System.Text;
using AMW.Model.Enum;
using AMW.Model;
using System.IO;
using AMW.DB.SQLSERVER;
using MyWeb.Attribute;

namespace MyWeb.Controllers
{
    [ExceptionAttribute]
    public class HomeController : Controller
    {
        MldApplicationAreaDal applicationAreaDal = new MldApplicationAreaDal();
        public ActionResult Index()
        {
            ViewBag.ProList1 = DBHelper.From("MldProduct")
                .Take("*")
                .Where("cid in(select id from MldProductCategory where tid=@1) and allshowflag=1 and homeshowflag=1", (int)EnumProductCategory.Category1)
                .OrderBy("id asc")
                .GoToPage(1,9,"id")
                .QueryList<MldProduct>();

            ViewBag.ApplicateionArea = applicationAreaDal.QueryList(1, 6, "id", "id desc", "homeshowFlag = @1", 1);

            return View();
        }
        public ActionResult GetHomeProduct(int cid)
        {
            MldProductCategoryDal proCategory = new MldProductCategoryDal();
            List<MldProductCategory> categoryList = proCategory.QueryList(1, 4, "id", "id asc", "tid=@1", cid);

            List<MldProduct> proList = DBHelper.From("MldProduct")
                   .Take("*")
                   .Where("cid in(select id from MldProductCategory where tid=@1) and allshowflag=1 and homeshowflag=1", cid)
                   .OrderBy("id asc")
                   .GoToPage(1, 9, "id")
                   .QueryList<MldProduct>();
            return Json(new JsonResultModel() { ok = true, data = new { categoryList = categoryList, proList = proList } });

        }
        public ActionResult GetHomeProduct2(int cid)
        {

            List<MldProduct> proList = DBHelper.From("MldProduct")
                   .Take("*")
                   .Where("cid = @1 and allshowflag=1 and homeshowflag=1", cid)
                   .OrderBy("id asc")
                   .GoToPage(1, 9, "id")
                   .QueryList<MldProduct>();
            return Json(new JsonResultModel() { ok = true, data = new { proList = proList } });

        }
        public ActionResult AboutUs(int id = 1)
        {
            MldPage model = new MldPageDal().Query(id);
            return View(model);
        }
        public ActionResult Comment()
        {
            return View();
        }

        public ActionResult SubmitForm(string name,string phone,string content,string code)
        {
            if (code.Equals(SessionHelper.ValidateCode))
            {
                MldForm form = new MldForm();
                form.AddTime = DateTime.Now;
                form.Content = content;
                form.Name = name;
                form.Phone = phone;

                return Json(new JsonResultModel() { ok = new MldFormDal().Add(form) > 0 });
            }
            else
            {
                return Json(new JsonResultModel() { ok = false, error = "请输入正确的验证码！" });
            }
            
        }
        public ActionResult SubmitComment(string content, string code)
        {
            if (code.Equals(SessionHelper.ValidateCode))
            {
                MldComment form = new MldComment();
                form.AddTime = DateTime.Now;
                form.Content = content;

                return Json(new JsonResultModel() { ok = new MldCommentDal().Add(form) > 0 });
            }
            else
            {
                return Json(new JsonResultModel() { ok = false, error = "请输入正确的验证码！" });
            }
            
        }
    }
}