using System;
using System.Collections.Generic;
using System.Text;
using AMW.DB.SQLSERVER;
using AMW.Model.Entity;
namespace AMW.DAL  
{
	 	//MldProductImg
		public class MldProductImgDal
	{
   		public int QueryInt(string where, params object[] obj)
        {
            return DBHelper.From("MldProductImg").Take("count(*)").Where(where, obj).QueryInt();
        }
		public string QueryString(string where, params object[] obj)
        {
            return DBHelper.From("MldProductImg").Take("count(*)").Where(where, obj).QueryString();
        }

		public bool Exists(string where, params object[] obj)
		{
			return QueryInt(where, obj) > 0;
		}
		public AMW.Model.Entity.MldProductImg Query(int id)
        {
            return DBHelper.From("MldProductImg").Take("*").Where("id=@1", id).QueryFirstRow<AMW.Model.Entity.MldProductImg>();
        }
		public AMW.Model.Entity.MldProductImg Query(string where, params object[] obj)
        {
            return DBHelper.From("MldProductImg").Take("*").Where(where, obj).QueryFirstRow<AMW.Model.Entity.MldProductImg>();
        }
		public List<AMW.Model.Entity.MldProductImg> QueryList(string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldProductImg").Take("*").OrderBy(orderby).Where(where, obj).QueryList<AMW.Model.Entity.MldProductImg>();
        }	

		public List<AMW.Model.Entity.MldProductImg> QueryList(int pageIndex, int pageSize,string field,string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldProductImg").Take("*").Where(where, obj).OrderBy(orderby).GoToPage(pageIndex,pageSize,field).QueryList<AMW.Model.Entity.MldProductImg>();
        }

		public int Add(AMW.Model.Entity.MldProductImg model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.PidValueFlag){
						dic.Add("Pid", model.Pid);
					}
									if(model.ImgValueFlag){
						dic.Add("Img", model.Img);
					}
				            return DBHelper.InsertInto("MldProductImg", dic);
        }
		
		public bool Update(AMW.Model.Entity.MldProductImg model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.PidValueFlag){
						dic.Add("Pid", model.Pid);
					}
									if(model.ImgValueFlag){
						dic.Add("Img", model.Img);
					}
				            return DBHelper.Update("MldProductImg").Set(dic).Where("id=@1", model.ID).Execute() > 0;
        }
		
		public bool Delete(int id)
        {
            return DBHelper.DeleteFrom("MldProductImg", "id=@1", id) > 0;
        }

		public bool Delete(string where , params object[] obj) {
            return DBHelper.DeleteFrom("MldProductImg", where, obj) > 0;
        }
	}
}