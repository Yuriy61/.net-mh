using System;
using System.Collections.Generic;
using System.Text;
using AMW.DB.SQLSERVER;
using AMW.Model.Entity;
namespace AMW.DAL  
{
	 	//MldAdmin
		public class MldAdminDal
	{
   		public int QueryInt(string where, params object[] obj)
        {
            return DBHelper.From("MldAdmin").Take("count(*)").Where(where, obj).QueryInt();
        }
		public string QueryString(string where, params object[] obj)
        {
            return DBHelper.From("MldAdmin").Take("count(*)").Where(where, obj).QueryString();
        }

		public bool Exists(string where, params object[] obj)
		{
			return QueryInt(where, obj) > 0;
		}
		public AMW.Model.Entity.MldAdmin Query(int id)
        {
            return DBHelper.From("MldAdmin").Take("*").Where("id=@1", id).QueryFirstRow<AMW.Model.Entity.MldAdmin>();
        }
		public AMW.Model.Entity.MldAdmin Query(string where, params object[] obj)
        {
            return DBHelper.From("MldAdmin").Take("*").Where(where, obj).QueryFirstRow<AMW.Model.Entity.MldAdmin>();
        }
		public List<AMW.Model.Entity.MldAdmin> QueryList(string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldAdmin").Take("*").OrderBy(orderby).Where(where, obj).QueryList<AMW.Model.Entity.MldAdmin>();
        }	

		public List<AMW.Model.Entity.MldAdmin> QueryList(int pageIndex, int pageSize,string field,string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldAdmin").Take("*").Where(where, obj).OrderBy(orderby).GoToPage(pageIndex,pageSize,field).QueryList<AMW.Model.Entity.MldAdmin>();
        }

		public int Add(AMW.Model.Entity.MldAdmin model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.RidValueFlag){
						dic.Add("Rid", model.Rid);
					}
									if(model.NameValueFlag){
						dic.Add("Name", model.Name);
					}
									if(model.PwdValueFlag){
						dic.Add("Pwd", model.Pwd);
					}
									if(model.AddTimeValueFlag){
						dic.Add("AddTime", model.AddTime);
					}
									if(model.LastLoginTimeValueFlag){
						dic.Add("LastLoginTime", model.LastLoginTime);
					}
									if(model.LastLoginIPValueFlag){
						dic.Add("LastLoginIP", model.LastLoginIP);
					}
									if(model.IsLockValueFlag){
						dic.Add("IsLock", model.IsLock);
					}
				            return DBHelper.InsertInto("MldAdmin", dic);
        }
		
		public bool Update(AMW.Model.Entity.MldAdmin model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.RidValueFlag){
						dic.Add("Rid", model.Rid);
					}
									if(model.NameValueFlag){
						dic.Add("Name", model.Name);
					}
									if(model.PwdValueFlag){
						dic.Add("Pwd", model.Pwd);
					}
									if(model.AddTimeValueFlag){
						dic.Add("AddTime", model.AddTime);
					}
									if(model.LastLoginTimeValueFlag){
						dic.Add("LastLoginTime", model.LastLoginTime);
					}
									if(model.LastLoginIPValueFlag){
						dic.Add("LastLoginIP", model.LastLoginIP);
					}
									if(model.IsLockValueFlag){
						dic.Add("IsLock", model.IsLock);
					}
				            return DBHelper.Update("MldAdmin").Set(dic).Where("id=@1", model.ID).Execute() > 0;
        }
		
		public bool Delete(int id)
        {
            return DBHelper.DeleteFrom("MldAdmin", "id=@1", id) > 0;
        }

		public bool Delete(string where , params object[] obj) {
            return DBHelper.DeleteFrom("MldAdmin", where, obj) > 0;
        }
	}
}