using System;
using System.Collections.Generic;
using System.Text;
using AMW.DB.SQLSERVER;
using AMW.Model.Entity;
namespace AMW.DAL  
{
	 	//MldNews
		public class MldNewsDal
	{
   		public int QueryInt(string where, params object[] obj)
        {
            return DBHelper.From("MldNews").Take("count(*)").Where(where, obj).QueryInt();
        }
		public string QueryString(string where, params object[] obj)
        {
            return DBHelper.From("MldNews").Take("count(*)").Where(where, obj).QueryString();
        }

		public bool Exists(string where, params object[] obj)
		{
			return QueryInt(where, obj) > 0;
		}
		public AMW.Model.Entity.MldNews Query(int id)
        {
            return DBHelper.From("MldNews").Take("*").Where("id=@1", id).QueryFirstRow<AMW.Model.Entity.MldNews>();
        }

        public AMW.Model.Entity.MldNews GetFirst()
        {
            return DBHelper.From("MldNews").Take("*").Where("isshow=@1", 1).OrderBy("id asc").QueryFirstRow<AMW.Model.Entity.MldNews>();
        }
        public List<AMW.Model.Entity.MldNews> Get3th()
        {
            return DBHelper.From("MldNews").Take("*").Where("isshow=@1", 1).GoToPage(1,4).OrderBy("priority desc,id asc").QueryList<AMW.Model.Entity.MldNews>();
        }

        public AMW.Model.Entity.MldNews getPrev(int id)
        {
            return DBHelper.From("MldNews").Take("*").Where("id<@1 and isshow=1", id).QueryFirstRow<AMW.Model.Entity.MldNews>();
        }
        public AMW.Model.Entity.MldNews getNext(int id)
        {
            return DBHelper.From("MldNews").Take("*").Where("id>@1 and isshow=1", id).QueryFirstRow<AMW.Model.Entity.MldNews>();
        }

		public AMW.Model.Entity.MldNews Query(string where, params object[] obj)
        {
            return DBHelper.From("MldNews").Take("*").Where(where, obj).QueryFirstRow<AMW.Model.Entity.MldNews>();
        }
		public List<AMW.Model.Entity.MldNews> QueryList(string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldNews").Take("*").OrderBy(orderby).Where(where, obj).QueryList<AMW.Model.Entity.MldNews>();
        }	

		public List<AMW.Model.Entity.MldNews> QueryList(int pageIndex, int pageSize,string field,string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldNews").Take("*").Where(where, obj).OrderBy(orderby).GoToPage(pageIndex,pageSize,field).QueryList<AMW.Model.Entity.MldNews>();
        }

		public int Add(AMW.Model.Entity.MldNews model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.NewsTypeValueFlag){
						dic.Add("NewsType", model.NewsType);
					}
									if(model.TitleValueFlag){
						dic.Add("Title", model.Title);
					}
									if(model.SubHeadValueFlag){
						dic.Add("SubHead", model.SubHead);
					}
									if(model.ImgValueFlag){
						dic.Add("Img", model.Img);
					}
									if(model.ContentValueFlag){
						dic.Add("Content", model.Content);
					}
									if(model.IsShowValueFlag){
						dic.Add("IsShow", model.IsShow);
					}
									if(model.PriorityValueFlag){
						dic.Add("Priority", model.Priority);
					}
									if(model.AddTimeValueFlag){
						dic.Add("AddTime", model.AddTime);
					}
				            return DBHelper.InsertInto("MldNews", dic);
        }
		
		public bool Update(AMW.Model.Entity.MldNews model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.NewsTypeValueFlag){
						dic.Add("NewsType", model.NewsType);
					}
									if(model.TitleValueFlag){
						dic.Add("Title", model.Title);
					}
									if(model.SubHeadValueFlag){
						dic.Add("SubHead", model.SubHead);
					}
									if(model.ImgValueFlag){
						dic.Add("Img", model.Img);
					}
									if(model.ContentValueFlag){
						dic.Add("Content", model.Content);
					}
									if(model.IsShowValueFlag){
						dic.Add("IsShow", model.IsShow);
					}
									if(model.PriorityValueFlag){
						dic.Add("Priority", model.Priority);
					}
									if(model.AddTimeValueFlag){
						dic.Add("AddTime", model.AddTime);
					}
				            return DBHelper.Update("MldNews").Set(dic).Where("id=@1", model.ID).Execute() > 0;
        }
		
		public bool Delete(int id)
        {
            return DBHelper.DeleteFrom("MldNews", "id=@1", id) > 0;
        }

		public bool Delete(string where , params object[] obj) {
            return DBHelper.DeleteFrom("MldNews", where, obj) > 0;
        }
	}
}