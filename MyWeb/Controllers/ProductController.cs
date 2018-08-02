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
            bool enableEnterPage = true;
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
                List<int> ids = new List<int>() { 6,39,40,41,42,43,44,45};
                
                if(cid!=0){
                    where += " and a.cid=@1";
                    parame.Add(cid);
                    if(ids.Contains(cid)){
                        enableEnterPage = false;
                    }
                }
                else
                {
                    where += " and a.cid in(select id from MldProductCategory where tid=@1)";
                    parame.Add(id);
                    if(ids.Contains(id)){
                        enableEnterPage = false;
                    }
                }
            }
            MldProductDal dal = new MldProductDal();
            int count = dal.QueryInt(where, parame.ToArray());
            List<MldProduct> list = dal.QueryList(curPage, 12, "a.id", "a.id desc", where, parame.ToArray());
            ViewBag.EnableEnterPage = enableEnterPage;
            return View(list);
        }
    }
}