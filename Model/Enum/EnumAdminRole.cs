using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace AMW.Model.Enum
{
    public enum EnumAdminRole
    {
        [Description("超级管理员")]
        SuperAdmin = 1,
        [Description("普通管理员")]
        Normal = 2
    }
}