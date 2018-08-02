using System;
using System.Collections.Generic;
using System.Text;
using AMW.DB.SQLSERVER;
using AMW.Model.Entity;
namespace AMW.DAL  
{
	 	//MldComment
		public class MldCommentDal
	{
   		public int QueryInt(string where, params object[] obj)
        {
            return DBHelper.From("MldComment").Take("count(*)").Where(where, obj).QueryInt();
        }
		public string QueryString(string where, params object[] obj)
        {
            return DBHelper.From("MldComment").Take("count(*)").Where(where, obj).QueryString();
        }

		public bool Exists(string where, params object[] obj)
		{
			return QueryInt(where, obj) > 0;
		}
		public AMW.Model.Entity.MldComment Query(int id)
        {
            return DBHelper.From("MldComment").Take("*").Where("id=@1", id).QueryFirstRow<AMW.Model.Entity.MldComment>();
        }
		public AMW.Model.Entity.MldComment Query(string where, params object[] obj)
        {
            return DBHelper.From("MldComment").Take("*").Where(where, obj).QueryFirstRow<AMW.Model.Entity.MldComment>();
        }
		public List<AMW.Model.Entity.MldComment> QueryList(string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldComment").Take("*").OrderBy(orderby).Where(where, obj).QueryList<AMW.Model.Entity.MldComment>();
        }	

		public List<AMW.Model.Entity.MldComment> QueryList(int pageIndex, int pageSize,string field,string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldComment").Take("*").Where(where, obj).OrderBy(orderby).GoToPage(pageIndex,pageSize,field).QueryList<AMW.Model.Entity.MldComment>();
        }

		public int Add(AMW.Model.Entity.MldComment model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.ContentValueFlag){
						dic.Add("Content", model.Content);
					}
									if(model.AddTimeValueFlag){
						dic.Add("AddTime", model.AddTime);
					}
				            return DBHelper.InsertInto("MldComment", dic);
        }
		
		public bool Update(AMW.Model.Entity.MldComment model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.ContentValueFlag){
						dic.Add("Content", model.Content);
					}
									if(model.AddTimeValueFlag){
						dic.Add("AddTime", model.AddTime);
					}
				            return DBHelper.Update("MldComment").Set(dic).Where("id=@1", model.ID).Execute() > 0;
        }
		
		public bool Delete(int id)
        {
            return DBHelper.DeleteFrom("MldComment", "id=@1", id) > 0;
        }

		public bool Delete(string where , params object[] obj) {
            return DBHelper.DeleteFrom("MldComment", where, obj) > 0;
        }
	}
}