using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AMW.DB.SQLSERVER;

namespace MyWeb.Helper
{
    public class OrderHelper
    {
        public static string GetRechargeOrder()
        {
            return Guid.NewGuid().ToString().Replace("-", "").Substring(0, 3).ToUpper() + DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }


    }
}