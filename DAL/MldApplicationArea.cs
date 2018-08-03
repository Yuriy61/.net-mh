using System;
using System.Collections.Generic;
using System.Text;
using AMW.DB.SQLSERVER;
using AMW.Model.Entity;
namespace AMW.DAL  
{
	 	//MldApplicationArea
		public class MldApplicationAreaDal
	{
   		public int QueryInt(string where, params object[] obj)
        {
            return DBHelper.From("MldApplicationArea").Take("count(*)").Where(where, obj).QueryInt();
        }
		public string QueryString(string where, params object[] obj)
        {
            return DBHelper.From("MldApplicationArea").Take("count(*)").Where(where, obj).QueryString();
        }

		public bool Exists(string where, params object[] obj)
		{
			return QueryInt(where, obj) > 0;
		}
		public AMW.Model.Entity.MldApplicationArea Query(int id)
        {
            return DBHelper.From("MldApplicationArea").Take("*").Where("id=@1", id).QueryFirstRow<AMW.Model.Entity.MldApplicationArea>();
        }
		public AMW.Model.Entity.MldApplicationArea Query(string where, params object[] obj)
        {
            return DBHelper.From("MldApplicationArea").Take("*").Where(where, obj).QueryFirstRow<AMW.Model.Entity.MldApplicationArea>();
        }
		public List<AMW.Model.Entity.MldApplicationArea> QueryList(string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldApplicationArea").Take("*").OrderBy(orderby).Where(where, obj).QueryList<AMW.Model.Entity.MldApplicationArea>();
        }	

		public List<AMW.Model.Entity.MldApplicationArea> QueryList(int pageIndex, int pageSize,string field,string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldApplicationArea").Take("*").Where(where, obj).OrderBy(orderby).GoToPage(pageIndex,pageSize,field).QueryList<AMW.Model.Entity.MldApplicationArea>();
        }

		public int Add(AMW.Model.Entity.MldApplicationArea model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.NameValueFlag){
						dic.Add("Name", model.Name);
					}
									if(model.HomeBgValueFlag){
						dic.Add("HomeBg", model.HomeBg);
					}
									if(model.IconValueFlag){
						dic.Add("Icon", model.Icon);
					}
									if(model.SubHeadValueFlag){
						dic.Add("SubHead", model.SubHead);
					}
									if(model.ContentValueFlag){
						dic.Add("Content", model.Content);
					}
									if(model.HomeShowFlagValueFlag){
						dic.Add("HomeShowFlag", model.HomeShowFlag);
					}
									if(model.AddTimeValueFlag){
						dic.Add("AddTime", model.AddTime);
					}
				            return DBHelper.InsertInto("MldApplicationArea", dic);
        }
		
		public bool Update(AMW.Model.Entity.MldApplicationArea model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.NameValueFlag){
						dic.Add("Name", model.Name);
					}
									if(model.HomeBgValueFlag){
						dic.Add("HomeBg", model.HomeBg);
					}
									if(model.IconValueFlag){
						dic.Add("Icon", model.Icon);
					}
									if(model.SubHeadValueFlag){
						dic.Add("SubHead", model.SubHead);
					}
									if(model.ContentValueFlag){
						dic.Add("Content", model.Content);
					}
									if(model.HomeShowFlagValueFlag){
						dic.Add("HomeShowFlag", model.HomeShowFlag);
					}
									if(model.AddTimeValueFlag){
						dic.Add("AddTime", model.AddTime);
					}
				            return DBHelper.Update("MldApplicationArea").Set(dic).Where("id=@1", model.ID).Execute() > 0;
        }
		
		public bool Delete(int id)
        {
            return DBHelper.DeleteFrom("MldApplicationArea", "id=@1", id) > 0;
        }

		public bool Delete(string where , params object[] obj) {
            return DBHelper.DeleteFrom("MldApplicationArea", where, obj) > 0;
        }
	}
}