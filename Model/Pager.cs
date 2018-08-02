using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMW.Model
{
    public class Pager
    {
        /// <summary>
        /// 每页大小
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 总共页数
        /// </summary>
        public int PageCount { get; set; }
        /// <summary>
        /// 当前页数
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 分页提交链接
        /// </summary>
        public string SubmitLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, object> List { get; set; }
    }
}