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
    public class CommentController : BasicController
    {
        MldCommentDal dal = new MldCommentDal();

        #region 列表
        [CustomAdminAuthorize(EnumAdminRole.SuperAdmin)]
        public ActionResult List(int pageSize = 20, int pageIndex = 1)
        {
            if (pageIndex <= 0)
            {
                pageIndex = 1;
            }
            ViewBag.Error = "none";

            int count = dal.QueryInt("1=1");
            int pageCount = (count + 20 - 1) / 20;
            List<AMW.Model.Entity.MldComment> list = dal.QueryList(pageIndex, pageSize, "id", "id desc", "1=1");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            ViewBag.Pager = new AMW.Model.Pager() { PageSize = pageSize, PageCount = pageCount, PageIndex = pageIndex, SubmitLink = "/WebAdmin/Comment/List", List = dic };
            return View(list);
        }
        #endregion
        
    }
}