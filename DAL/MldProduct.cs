using System;
using System.Collections.Generic;
using System.Text;
using AMW.DB.SQLSERVER;
using AMW.Model.Entity;
namespace AMW.DAL  
{
	 	//MldProduct
		public class MldProductDal
	{
   		public int QueryInt(string where, params object[] obj)
        {
            return DBHelper.From("MldProduct a").Take("count(*)").Where(where, obj).QueryInt();
        }
		public string QueryString(string where, params object[] obj)
        {
            return DBHelper.From("MldProduct").Take("count(*)").Where(where, obj).QueryString();
        }

		public bool Exists(string where, params object[] obj)
		{
			return QueryInt(where, obj) > 0;
		}
		public AMW.Model.Entity.MldProduct Query(int id)
        {
            return DBHelper.From("MldProduct").Take("*").Where("id=@1", id).QueryFirstRow<AMW.Model.Entity.MldProduct>();
        }
		public AMW.Model.Entity.MldProduct Query(string where, params object[] obj)
        {
            return DBHelper.From("MldProduct").Take("*").Where(where, obj).QueryFirstRow<AMW.Model.Entity.MldProduct>();
        }
		public List<AMW.Model.Entity.MldProduct> QueryList(string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldProduct").Take("*").OrderBy(orderby).Where(where, obj).QueryList<AMW.Model.Entity.MldProduct>();
        }	

		public List<AMW.Model.Entity.MldProduct> QueryList(int pageIndex, int pageSize,string field,string orderby,string where, params object[] obj)
        {
            return DBHelper.From("MldProduct a")
                .LeftJoin("MldProductCategory b", "a.Cid=b.id")
                .LeftJoin("MldProductCategory c", "b.tid=c.id").Take("a.*,c.name as CategoryName1,b.name as CategoryName2").Where(where, obj).OrderBy(orderby).GoToPage(pageIndex, pageSize, field).QueryList<AMW.Model.Entity.MldProduct>();
        }

		public int Add(AMW.Model.Entity.MldProduct model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.CidValueFlag){
						dic.Add("Cid", model.Cid);
					}
									if(model.AllShowFlagValueFlag){
						dic.Add("AllShowFlag", model.AllShowFlag);
					}
									if(model.HomeShowFlagValueFlag){
						dic.Add("HomeShowFlag", model.HomeShowFlag);
					}
									if(model.IsEliteValueFlag){
						dic.Add("IsElite", model.IsElite);
					}
									if(model.NameValueFlag){
						dic.Add("Name", model.Name);
					}
									if(model.SubHeadValueFlag){
						dic.Add("SubHead", model.SubHead);
					}
									if(model.ImgValueFlag){
						dic.Add("Img", model.Img);
					}
									if(model.ProfileValueFlag){
						dic.Add("Profile", model.Profile);
					}
									if(model.ApplicationValueFlag){
						dic.Add("Application", model.Application);
					}
									if(model.MaterialValueFlag){
						dic.Add("Material", model.Material);
					}
									if(model.WeightValueFlag){
						dic.Add("Weight", model.Weight);
					}
									if(model.LengthValueFlag){
						dic.Add("Length", model.Length);
					}
									if(model.MassOfInertiaValueFlag){
						dic.Add("MassOfInertia", model.MassOfInertia);
					}
									if(model.SectionModulusValueFlag){
						dic.Add("SectionModulus", model.SectionModulus);
					}
									if(model.ProfileImgValueFlag){
						dic.Add("ProfileImg", model.ProfileImg);
					}
									if(model.ContentValueFlag){
						dic.Add("Content", model.Content);
					}
									if(model.AddTimeValueFlag){
						dic.Add("AddTime", model.AddTime);
					}
				            return DBHelper.InsertInto("MldProduct", dic);
        }
		
		public bool Update(AMW.Model.Entity.MldProduct model)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
								if(model.CidValueFlag){
						dic.Add("Cid", model.Cid);
					}
									if(model.AllShowFlagValueFlag){
						dic.Add("AllShowFlag", model.AllShowFlag);
					}
									if(model.HomeShowFlagValueFlag){
						dic.Add("HomeShowFlag", model.HomeShowFlag);
					}
									if(model.IsEliteValueFlag){
						dic.Add("IsElite", model.IsElite);
					}
									if(model.NameValueFlag){
						dic.Add("Name", model.Name);
					}
									if(model.SubHeadValueFlag){
						dic.Add("SubHead", model.SubHead);
					}
									if(model.ImgValueFlag){
						dic.Add("Img", model.Img);
					}
									if(model.ProfileValueFlag){
						dic.Add("Profile", model.Profile);
					}
									if(model.ApplicationValueFlag){
						dic.Add("Application", model.Application);
					}
									if(model.MaterialValueFlag){
						dic.Add("Material", model.Material);
					}
									if(model.WeightValueFlag){
						dic.Add("Weight", model.Weight);
					}
									if(model.LengthValueFlag){
						dic.Add("Length", model.Length);
					}
									if(model.MassOfInertiaValueFlag){
						dic.Add("MassOfInertia", model.MassOfInertia);
					}
									if(model.SectionModulusValueFlag){
						dic.Add("SectionModulus", model.SectionModulus);
					}
									if(model.ProfileImgValueFlag){
						dic.Add("ProfileImg", model.ProfileImg);
					}
									if(model.ContentValueFlag){
						dic.Add("Content", model.Content);
					}
									if(model.AddTimeValueFlag){
						dic.Add("AddTime", model.AddTime);
					}
				            return DBHelper.Update("MldProduct").Set(dic).Where("id=@1", model.ID).Execute() > 0;
        }
		
		public bool Delete(int id)
        {
            return DBHelper.DeleteFrom("MldProduct", "id=@1", id) > 0;
        }

		public bool Delete(string where , params object[] obj) {
            return DBHelper.DeleteFrom("MldProduct", where, obj) > 0;
        }



        public List<AMW.Model.Entity.MldProduct> getElite()
        {
            int count = QueryInt("AllShowFlag=@1 and iselite=@2", 1, 1) / 2;
            if (count > 0)
            {
                return DBHelper.From("MldProduct").Take("*").OrderBy("id asc").GoToPage(new Random().Next(1, count + 1), 2).Where("AllShowFlag=@1 and iselite=@2", 1, 1).QueryList<AMW.Model.Entity.MldProduct>();
            }
            return new List<MldProduct>();

        }
        public List<AMW.Model.Entity.MldProduct> getElite(int cid)
        {
            int count = QueryInt("AllShowFlag=@1 and iselite=@2 and cid=@3", 1, 1, cid) / 3;
            if (count > 0)
            {
                return DBHelper.From("MldProduct").Take("*").OrderBy("id asc").GoToPage(new Random().Next(1, count + 1), 3).Where("AllShowFlag=@1 and iselite=@2 and cid=@3", 1, 1, cid).QueryList<AMW.Model.Entity.MldProduct>();
            }
            return new List<MldProduct>();

        }
	}
}