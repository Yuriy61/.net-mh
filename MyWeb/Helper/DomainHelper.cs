using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWeb.Helper
{
    /// <summary>
    /// DomainHelper 的摘要说明
    /// </summary>
    public static class DomainHelper
    {
        public static string CurDomain
        {
            get
            {
                string host = Common.HttpHelper.Context.Request.Url.Host;
                if (host.IndexOf("http://") == -1 && host.IndexOf("https://") == -1)
                {
                    return string.Format("{0}{1}", "http://", host);
                }
                return host;
            }
        }
    }
}