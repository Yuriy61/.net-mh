using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMW.Model
{
    public class JsonResultModel
    {
        public bool ok { get; set; }
        public string error { get; set; }
        public object data { get; set; }
    }
}