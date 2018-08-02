using System;
using System.Collections.Generic;
using System.Text;
using AMW.DB.SQLSERVER;
using AMW.Model.Entity;
namespace AMW.DAL  
{
	 	//MldProductCategory
		public class MldProductCategoryDal
	{
   		public int QueryInt(string where, params object[] obj)
        {
            return DBHelper.From("MldProductCategory").Take("count(*)").Where(where, obj).QueryInt();
        }
		public string QueryString(string where, params object[] obj)
        {
            return DBHelper.From("MldProductCategory").Take("count(*)").Where(where, obj).QueryString();
        }

		public bool Exists(string where, params object[] obj)
		{
			return QueryInt(where, obj) > 0;
		}
		public AMW.Model.Entity.MldProductCategory Query(int id)
        {
            return DBHelper.From("MldProductCategory").Take("*").Where("id=@1", id).QueryFirstRow<AMW.Model.Entity.MldProductCategory>();
        }
		public AMW.Model.Entity.MldProductCategory Query(string where, params object[] obj)
        {
            return DBHelper.From("MldProductCategory").Take("*").Where(where, obj).QueryFirstRow<AMW.Model.Entity.MldProductCategory>();
        }
		public List<AMW.Model.Entity.MldProductCategory> QueryList(string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldProductCategory").Take("*").OrderBy(orderby).Where(where, obj).QueryList<AMW.Model.Entity.MldProductCategory>();
        }	

		public List<AMW.Model.Entity.MldProductCategory> QueryList(int pageIndex, int pageSize,string field,string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldProductCategory").Take("*").Where(where, obj).OrderBy(orderby).GoToPage(pageIndex,pageSize,field).QueryList<AMW.Model.Entity.MldProductCategory>();
        }

		public int Add(AMW.Model.Entity.MldProductCategory model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.TidValueFlag){
						dic.Add("Tid", model.Tid);
					}
									if(model.NameValueFlag){
						dic.Add("Name", model.Name);
					}
									if(model.OrderValueFlag){
						dic.Add("Order", model.Order);
					}
									if(model.AddTimeValueFlag){
						dic.Add("AddTime", model.AddTime);
					}
				            return DBHelper.InsertInto("MldProductCategory", dic);
        }
		
		public bool Update(AMW.Model.Entity.MldProductCategory model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.TidValueFlag){
						dic.Add("Tid", model.Tid);
					}
									if(model.NameValueFlag){
						dic.Add("Name", model.Name);
					}
									if(model.OrderValueFlag){
						dic.Add("Order", model.Order);
					}
									if(model.AddTimeValueFlag){
						dic.Add("AddTime", model.AddTime);
					}
				            return DBHelper.Update("MldProductCategory").Set(dic).Where("id=@1", model.ID).Execute() > 0;
        }
		
		public bool Delete(int id)
        {
            return DBHelper.DeleteFrom("MldProductCategory", "id=@1", id) > 0;
        }

		public bool Delete(string where , params object[] obj) {
            return DBHelper.DeleteFrom("MldProductCategory", where, obj) > 0;
        }
	}
}