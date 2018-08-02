using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace MyWeb.Helper
{
    public class EncodeHelper
    {
        public static string md5(string str)
        {
            return BitConverter.ToString(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(str))).Replace("-", "").ToUpper();
        }

        public static string sha1(string str)
        {
            return BitConverter.ToString(SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(str))).Replace("-", "").ToUpper();
        }
    }
}