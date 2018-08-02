using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AMW.DB.SQLSERVER;

namespace MyWeb.Helper
{
    public class SessionHelper
    {
        public static string ValidateCode
        {
            get { return Convert.ToString(Common.HttpHelper.Context.Session["ValidateCode"]); }
            set { Common.HttpHelper.Context.Session["ValidateCode"] = value; }
        }
    }
}