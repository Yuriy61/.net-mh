using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AMW.Model.Entity
{
	 	//MldNews
		public class MldNews
	{
   		     
      	      	private int _ID;
      	public bool IDValueFlag = false;
		/// <summary>
		/// ID
        /// </summary>		
        public int ID{
        	get
        	{
        		return _ID;
        	}
        	set
        	{
        		_ID = value;
        		IDValueFlag = true;
        	}
        }
        
		      	private int _NewsType;
      	public bool NewsTypeValueFlag = false;
		/// <summary>
		/// NewsType
        /// </summary>		
        public int NewsType{
        	get
        	{
        		return _NewsType;
        	}
        	set
        	{
        		_NewsType = value;
        		NewsTypeValueFlag = true;
        	}
        }
        
		      	private string _Title;
      	public bool TitleValueFlag = false;
		/// <summary>
		/// Title
        /// </summary>		
        public string Title{
        	get
        	{
        		return _Title;
        	}
        	set
        	{
        		_Title = value;
        		TitleValueFlag = true;
        	}
        }
        
		      	private string _SubHead;
      	public bool SubHeadValueFlag = false;
		/// <summary>
		/// SubHead
        /// </summary>		
        public string SubHead{
        	get
        	{
        		return _SubHead;
        	}
        	set
        	{
        		_SubHead = value;
        		SubHeadValueFlag = true;
        	}
        }
        
		      	private string _Img;
      	public bool ImgValueFlag = false;
		/// <summary>
		/// Img
        /// </summary>		
        public string Img{
        	get
        	{
        		return _Img;
        	}
        	set
        	{
        		_Img = value;
        		ImgValueFlag = true;
        	}
        }
        
		      	private string _Content;
      	public bool ContentValueFlag = false;
		/// <summary>
		/// Content
        /// </summary>		
        public string Content{
        	get
        	{
        		return _Content;
        	}
        	set
        	{
        		_Content = value;
        		ContentValueFlag = true;
        	}
        }
        
		      	private int _IsShow;
      	public bool IsShowValueFlag = false;
		/// <summary>
		/// IsShow
        /// </summary>		
        public int IsShow{
        	get
        	{
        		return _IsShow;
        	}
        	set
        	{
        		_IsShow = value;
        		IsShowValueFlag = true;
        	}
        }
        
		      	private int _Priority;
      	public bool PriorityValueFlag = false;
		/// <summary>
		/// Priority
        /// </summary>		
        public int Priority{
        	get
        	{
        		return _Priority;
        	}
        	set
        	{
        		_Priority = value;
        		PriorityValueFlag = true;
        	}
        }
        
		      	private DateTime _AddTime;
      	public bool AddTimeValueFlag = false;
		/// <summary>
		/// AddTime
        /// </summary>		
        public DateTime AddTime{
        	get
        	{
        		return _AddTime;
        	}
        	set
        	{
        		_AddTime = value;
        		AddTimeValueFlag = true;
        	}
        }
        
		   
	}
}