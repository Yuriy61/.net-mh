using System;
using System.Collections.Generic;
using System.Text;
using AMW.DB.SQLSERVER;
using AMW.Model.Entity;
namespace AMW.DAL  
{
	 	//MldAdv
		public class MldAdvDal
	{
   		public int QueryInt(string where, params object[] obj)
        {
            return DBHelper.From("MldAdv").Take("count(*)").Where(where, obj).QueryInt();
        }
		public string QueryString(string where, params object[] obj)
        {
            return DBHelper.From("MldAdv").Take("count(*)").Where(where, obj).QueryString();
        }

		public bool Exists(string where, params object[] obj)
		{
			return QueryInt(where, obj) > 0;
		}
		public AMW.Model.Entity.MldAdv Query(int id)
        {
            return DBHelper.From("MldAdv").Take("*").Where("id=@1", id).QueryFirstRow<AMW.Model.Entity.MldAdv>();
        }
		public AMW.Model.Entity.MldAdv Query(string where, params object[] obj)
        {
            return DBHelper.From("MldAdv").Take("*").Where(where, obj).QueryFirstRow<AMW.Model.Entity.MldAdv>();
        }
		public List<AMW.Model.Entity.MldAdv> QueryList(string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldAdv").Take("*").OrderBy(orderby).Where(where, obj).QueryList<AMW.Model.Entity.MldAdv>();
        }	

		public List<AMW.Model.Entity.MldAdv> QueryList(int pageIndex, int pageSize,string field,string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldAdv").Take("*").Where(where, obj).OrderBy(orderby).GoToPage(pageIndex,pageSize,field).QueryList<AMW.Model.Entity.MldAdv>();
        }

		public int Add(AMW.Model.Entity.MldAdv model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.TitleValueFlag){
						dic.Add("Title", model.Title);
					}
									if(model.SubHeadValueFlag){
						dic.Add("SubHead", model.SubHead);
					}
									if(model.AdvTypeValueFlag){
						dic.Add("AdvType", model.AdvType);
					}
									if(model.LinkValueFlag){
						dic.Add("Link", model.Link);
					}
									if(model.ImgValueFlag){
						dic.Add("Img", model.Img);
					}
									if(model.IsShowValueFlag){
						dic.Add("IsShow", model.IsShow);
					}
									if(model.PriorityValueFlag){
						dic.Add("Priority", model.Priority);
					}
				            return DBHelper.InsertInto("MldAdv", dic);
        }
		
		public bool Update(AMW.Model.Entity.MldAdv model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.TitleValueFlag){
						dic.Add("Title", model.Title);
					}
									if(model.SubHeadValueFlag){
						dic.Add("SubHead", model.SubHead);
					}
									if(model.AdvTypeValueFlag){
						dic.Add("AdvType", model.AdvType);
					}
									if(model.LinkValueFlag){
						dic.Add("Link", model.Link);
					}
									if(model.ImgValueFlag){
						dic.Add("Img", model.Img);
					}
									if(model.IsShowValueFlag){
						dic.Add("IsShow", model.IsShow);
					}
									if(model.PriorityValueFlag){
						dic.Add("Priority", model.Priority);
					}
				            return DBHelper.Update("MldAdv").Set(dic).Where("id=@1", model.ID).Execute() > 0;
        }
		
		public bool Delete(int id)
        {
            return DBHelper.DeleteFrom("MldAdv", "id=@1", id) > 0;
        }

		public bool Delete(string where , params object[] obj) {
            return DBHelper.DeleteFrom("MldAdv", where, obj) > 0;
        }
	}
}