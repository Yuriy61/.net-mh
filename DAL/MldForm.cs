using System;
using System.Collections.Generic;
using System.Text;
using AMW.DB.SQLSERVER;
using AMW.Model.Entity;
namespace AMW.DAL  
{
	 	//MldForm
		public class MldFormDal
	{
   		public int QueryInt(string where, params object[] obj)
        {
            return DBHelper.From("MldForm").Take("count(*)").Where(where, obj).QueryInt();
        }
		public string QueryString(string where, params object[] obj)
        {
            return DBHelper.From("MldForm").Take("count(*)").Where(where, obj).QueryString();
        }

		public bool Exists(string where, params object[] obj)
		{
			return QueryInt(where, obj) > 0;
		}
		public AMW.Model.Entity.MldForm Query(int id)
        {
            return DBHelper.From("MldForm").Take("*").Where("id=@1", id).QueryFirstRow<AMW.Model.Entity.MldForm>();
        }
		public AMW.Model.Entity.MldForm Query(string where, params object[] obj)
        {
            return DBHelper.From("MldForm").Take("*").Where(where, obj).QueryFirstRow<AMW.Model.Entity.MldForm>();
        }
		public List<AMW.Model.Entity.MldForm> QueryList(string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldForm").Take("*").OrderBy(orderby).Where(where, obj).QueryList<AMW.Model.Entity.MldForm>();
        }	

		public List<AMW.Model.Entity.MldForm> QueryList(int pageIndex, int pageSize,string field,string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldForm").Take("*").Where(where, obj).OrderBy(orderby).GoToPage(pageIndex,pageSize,field).QueryList<AMW.Model.Entity.MldForm>();
        }

		public int Add(AMW.Model.Entity.MldForm model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.NameValueFlag){
						dic.Add("Name", model.Name);
					}
									if(model.PhoneValueFlag){
						dic.Add("Phone", model.Phone);
					}
									if(model.ContentValueFlag){
						dic.Add("Content", model.Content);
					}
									if(model.AddTimeValueFlag){
						dic.Add("AddTime", model.AddTime);
					}
				            return DBHelper.InsertInto("MldForm", dic);
        }
		
		public bool Update(AMW.Model.Entity.MldForm model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.NameValueFlag){
						dic.Add("Name", model.Name);
					}
									if(model.PhoneValueFlag){
						dic.Add("Phone", model.Phone);
					}
									if(model.ContentValueFlag){
						dic.Add("Content", model.Content);
					}
									if(model.AddTimeValueFlag){
						dic.Add("AddTime", model.AddTime);
					}
				            return DBHelper.Update("MldForm").Set(dic).Where("id=@1", model.ID).Execute() > 0;
        }
		
		public bool Delete(int id)
        {
            return DBHelper.DeleteFrom("MldForm", "id=@1", id) > 0;
        }

		public bool Delete(string where , params object[] obj) {
            return DBHelper.DeleteFrom("MldForm", where, obj) > 0;
        }
	}
}