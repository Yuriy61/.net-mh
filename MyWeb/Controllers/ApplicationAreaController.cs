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
    public class ApplicationAreaController : Controller
    {
        MldApplicationAreaDal dal = new MldApplicationAreaDal();
        public ActionResult Index(int id)
        {
            return View(dal.Query(id));
        }
        public ActionResult List(int curPage = 1)
        {
            int count = dal.QueryInt("1=1");
            List<MldApplicationArea> list = dal.QueryList(curPage, 12, "id", "id desc", "1=1");
            ViewBag.PageCount = (count + 12 - 1) / 12;
            ViewBag.CurPage = curPage;
            return View(list);
        }
    }
}