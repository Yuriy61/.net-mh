using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AMW.Model.Entity;
using AMW.DB.SQLSERVER;
using AMW.DAL;

namespace MyWeb.Helper
{
    public static class ApplicationHelper
    {
        /// <summary>
        /// 当前网站信息配置
        /// </summary>
        public static MldWebSite CurWebsite
        {
            get
            {
                MldWebSite result = Common.HttpHelper.Context.Application["website"] as MldWebSite;
                if(result == null){
                    result = new MldWebSiteDal().Query(1);
                }
                Common.HttpHelper.Context.Application["website"] = result;
                return result;
            }
            set
            {
                Common.HttpHelper.Context.Application["website"] = value;
            }

        }
    }
}