using System;
using System.Collections.Generic;
using System.Text;
using AMW.DB.SQLSERVER;
using AMW.Model.Entity;
namespace AMW.DAL  
{
	 	//MldPage
		public class MldPageDal
	{
   		public int QueryInt(string where, params object[] obj)
        {
            return DBHelper.From("MldPage").Take("count(*)").Where(where, obj).QueryInt();
        }
		public string QueryString(string where, params object[] obj)
        {
            return DBHelper.From("MldPage").Take("count(*)").Where(where, obj).QueryString();
        }

		public bool Exists(string where, params object[] obj)
		{
			return QueryInt(where, obj) > 0;
		}
		public AMW.Model.Entity.MldPage Query(int id)
        {
            return DBHelper.From("MldPage").Take("*").Where("id=@1", id).QueryFirstRow<AMW.Model.Entity.MldPage>();
        }
		public AMW.Model.Entity.MldPage Query(string where, params object[] obj)
        {
            return DBHelper.From("MldPage").Take("*").Where(where, obj).QueryFirstRow<AMW.Model.Entity.MldPage>();
        }
		public List<AMW.Model.Entity.MldPage> QueryList(string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldPage").Take("*").OrderBy(orderby).Where(where, obj).QueryList<AMW.Model.Entity.MldPage>();
        }	

		public List<AMW.Model.Entity.MldPage> QueryList(int pageIndex, int pageSize,string field,string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldPage").Take("*").Where(where, obj).OrderBy(orderby).GoToPage(pageIndex,pageSize,field).QueryList<AMW.Model.Entity.MldPage>();
        }

		public int Add(AMW.Model.Entity.MldPage model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.TitleValueFlag){
						dic.Add("Title", model.Title);
					}
									if(model.KeyWordValueFlag){
						dic.Add("KeyWord", model.KeyWord);
					}
									if(model.DescriptionValueFlag){
						dic.Add("Description", model.Description);
					}
									if(model.IntroValueFlag){
						dic.Add("Intro", model.Intro);
					}
									if(model.ContentValueFlag){
						dic.Add("Content", model.Content);
					}
				            return DBHelper.InsertInto("MldPage", dic);
        }
		
		public bool Update(AMW.Model.Entity.MldPage model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.TitleValueFlag){
						dic.Add("Title", model.Title);
					}
									if(model.KeyWordValueFlag){
						dic.Add("KeyWord", model.KeyWord);
					}
									if(model.DescriptionValueFlag){
						dic.Add("Description", model.Description);
					}
									if(model.IntroValueFlag){
						dic.Add("Intro", model.Intro);
					}
									if(model.ContentValueFlag){
						dic.Add("Content", model.Content);
					}
				            return DBHelper.Update("MldPage").Set(dic).Where("id=@1", model.ID).Execute() > 0;
        }
		
		public bool Delete(int id)
        {
            return DBHelper.DeleteFrom("MldPage", "id=@1", id) > 0;
        }

		public bool Delete(string where , params object[] obj) {
            return DBHelper.DeleteFrom("MldPage", where, obj) > 0;
        }
	}
}