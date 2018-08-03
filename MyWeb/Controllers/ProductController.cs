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

namespace MyWeb.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index(int id)
        {
            MldProduct model = new MldProductDal().Query(id);
            List<MldProductImg> imgList= new MldProductImgDal().QueryList("id asc","pid=@1",id);
            if (null == imgList || imgList.Count<=0)
            {
                imgList = new List<MldProductImg>();
                imgList.Add(new MldProductImg() { Img = model.Img, Pid =id });
            }
            ViewBag.ImgList = imgList;
            ViewBag.CategoryName = new MldProductCategoryDal().Query(model.Cid).Name;
            return View(model);
        }
        public ActionResult List(int cid = 0,string keyword = "",int id = 1)
        {
            int curPage = 1;
            if(!string.IsNullOrEmpty(Request["curPage"])){
                try{
                    curPage = int.Parse(Request["curPage"]);
                }catch{
                    curPage = 1;
                }
            }

            ViewBag.ID = id;
            string where = "a.AllShowFlag=1";
            List<object> parame = new List<object>();
            if(!string.IsNullOrEmpty(keyword)){
                where += " and a.name like @1";
                parame.Add("%"+keyword+"%");
            }
            else
            {
                if(cid!=0){
                    where += " and a.cid=@1";
                    parame.Add(cid);
                }
                else
                {
                    where += " and a.cid in(select id from MldProductCategory where tid=@1)";
                    parame.Add(id);
                }
            }
            MldProductDal dal = new MldProductDal();
            int count = dal.QueryInt(where, parame.ToArray());
            List<MldProduct> list = dal.QueryList(curPage, 12, "a.id", "a.id desc", where, parame.ToArray());

            int PageCount = (count + 12 - 1) / 12;

            ViewBag.Cid = cid;
            ViewBag.Id = id;
            ViewBag.Keyword = keyword;
            ViewBag.PageCount = PageCount;
            ViewBag.CurPage = curPage;

            return View(list);
        }

        public ActionResult GetList(int cid = 0, string keyword = "", int id = 1)
        {
            int curPage = 1;
            if (!string.IsNullOrEmpty(Request["curPage"]))
            {
                try
                {
                    curPage = int.Parse(Request["curPage"]);
                }
                catch
                {
                    curPage = 1;
                }
            }

            ViewBag.ID = id;
            string where = "a.AllShowFlag=1";
            List<object> parame = new List<object>();
            if (!string.IsNullOrEmpty(keyword))
            {
                where += " and a.name like @1";
                parame.Add("%" + keyword + "%");
            }
            else
            {
                if (cid != 0)
                {
                    where += " and a.cid=@1";
                    parame.Add(cid);
                }
                else
                {
                    where += " and a.cid in(select id from MldProductCategory where tid=@1)";
                    parame.Add(id);
                }
            }
            MldProductDal dal = new MldProductDal();
            int count = dal.QueryInt(where, parame.ToArray());
            List<MldProduct> list = dal.QueryList(curPage, 12, "a.id", "a.id desc", where, parame.ToArray());

            int PageCount = (count + 12 - 1) / 12;

            return Json(new JsonResultModel() { ok = true, data = new { pageCount = PageCount, proList = list,curPage = curPage } });
        }
    }
}