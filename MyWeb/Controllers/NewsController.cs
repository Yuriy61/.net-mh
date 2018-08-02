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
    public class NewsController : Controller
    {
        public ActionResult Index(int id)
        {
            return View(new MldNewsDal().Query(id));
        }
        public ActionResult List()
        {
            return View(new MldNewsDal().QueryList("priority desc,id desc","isshow=@1",1));
        }
    }
}