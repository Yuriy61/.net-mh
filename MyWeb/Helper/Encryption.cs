using System;
using System.Collections.Generic;
using System.Web;

namespace MyWeb.Helper
{
    /// <summary>
    ///Encryption 的摘要说明
    /// </summary>
    public class Encryption
    {
        public Encryption()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }

        /// <summary>
        /// MD5去字符串加密
        /// </summary>
        /// <param name="str">要加密的字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string MD5(string str)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5");
        }
    }
}