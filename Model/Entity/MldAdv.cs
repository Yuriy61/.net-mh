using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AMW.Model.Entity
{
	 	//MldAdv
		public class MldAdv
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
        
		      	private int _AdvType;
      	public bool AdvTypeValueFlag = false;
		/// <summary>
		/// AdvType
        /// </summary>		
        public int AdvType{
        	get
        	{
        		return _AdvType;
        	}
        	set
        	{
        		_AdvType = value;
        		AdvTypeValueFlag = true;
        	}
        }
        
		      	private string _Link;
      	public bool LinkValueFlag = false;
		/// <summary>
		/// Link
        /// </summary>		
        public string Link{
        	get
        	{
        		return _Link;
        	}
        	set
        	{
        		_Link = value;
        		LinkValueFlag = true;
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
        
		   
	}
}