using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace AMW.Model.Enum
{
    public enum EnumAdvType
    {
        [Description("Home Pic")]
        Banner = 1,
        [Description("OnlineFilling Pic")]
        OnlineFilling = 2,
        [Description("Download Pic")]
        Download = 3,
        [Description("Q&A Pic")]
        QA = 4,
        [Description("ContactUs Pic")]
        ContactUs = 5,
    }

    public class AdvTypeHelper
    {
        public static List<EnumAdvType> GetList()
        {
            List<EnumAdvType> result = new List<EnumAdvType>();
            result.Add(EnumAdvType.Banner);
            result.Add(EnumAdvType.OnlineFilling);
            result.Add(EnumAdvType.Download);
            result.Add(EnumAdvType.QA);
            result.Add(EnumAdvType.ContactUs);
            return result;
        }
    }
}