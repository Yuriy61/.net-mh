using System;
using System.Collections.Generic;
using System.Text;
using AMW.DB.SQLSERVER;
using AMW.Model.Entity;
namespace AMW.DAL  
{
	 	//MldWebSite
		public class MldWebSiteDal
	{
   		public int QueryInt(string where, params object[] obj)
        {
            return DBHelper.From("MldWebSite").Take("count(*)").Where(where, obj).QueryInt();
        }
		public string QueryString(string where, params object[] obj)
        {
            return DBHelper.From("MldWebSite").Take("count(*)").Where(where, obj).QueryString();
        }

		public bool Exists(string where, params object[] obj)
		{
			return QueryInt(where, obj) > 0;
		}
		public AMW.Model.Entity.MldWebSite Query(int id)
        {
            return DBHelper.From("MldWebSite").Take("*").Where("id=@1", id).QueryFirstRow<AMW.Model.Entity.MldWebSite>();
        }
		public AMW.Model.Entity.MldWebSite Query(string where, params object[] obj)
        {
            return DBHelper.From("MldWebSite").Take("*").Where(where, obj).QueryFirstRow<AMW.Model.Entity.MldWebSite>();
        }
		public List<AMW.Model.Entity.MldWebSite> QueryList(string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldWebSite").Take("*").OrderBy(orderby).Where(where, obj).QueryList<AMW.Model.Entity.MldWebSite>();
        }	

		public List<AMW.Model.Entity.MldWebSite> QueryList(int pageIndex, int pageSize,string field,string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldWebSite").Take("*").Where(where, obj).OrderBy(orderby).GoToPage(pageIndex,pageSize,field).QueryList<AMW.Model.Entity.MldWebSite>();
        }

		public int Add(AMW.Model.Entity.MldWebSite model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.TitleValueFlag){
						dic.Add("Title", model.Title);
					}
									if(model.LogoValueFlag){
						dic.Add("Logo", model.Logo);
					}
									if(model.KeyWordValueFlag){
						dic.Add("KeyWord", model.KeyWord);
					}
									if(model.DescriptionValueFlag){
						dic.Add("Description", model.Description);
					}
									if(model.ContentValueFlag){
						dic.Add("Content", model.Content);
					}
				            return DBHelper.InsertInto("MldWebSite", dic);
        }
		
		public bool Update(AMW.Model.Entity.MldWebSite model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.TitleValueFlag){
						dic.Add("Title", model.Title);
					}
									if(model.LogoValueFlag){
						dic.Add("Logo", model.Logo);
					}
									if(model.KeyWordValueFlag){
						dic.Add("KeyWord", model.KeyWord);
					}
									if(model.DescriptionValueFlag){
						dic.Add("Description", model.Description);
					}
									if(model.ContentValueFlag){
						dic.Add("Content", model.Content);
					}
				            return DBHelper.Update("MldWebSite").Set(dic).Where("id=@1", model.ID).Execute() > 0;
        }
		
		public bool Delete(int id)
        {
            return DBHelper.DeleteFrom("MldWebSite", "id=@1", id) > 0;
        }

		public bool Delete(string where , params object[] obj) {
            return DBHelper.DeleteFrom("MldWebSite", where, obj) > 0;
        }
	}
}