using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWeb.Helper
{
    public static class LogHelper
    {
        private static ILog log = LogManager.GetLogger("log1");
        public static void Info(string msg) {
            log.Info(msg);
        }
        public static void Error(string msg) {
            log.Error(msg);
        }
        public static void Warn(string msg) {
            log.Warn(msg);
        }
    }
}