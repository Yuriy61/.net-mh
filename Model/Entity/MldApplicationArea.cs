using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AMW.Model.Entity
{
	 	//MldApplicationArea
		public class MldApplicationArea
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
        
		      	private string _Name;
      	public bool NameValueFlag = false;
		/// <summary>
		/// Name
        /// </summary>		
        public string Name{
        	get
        	{
        		return _Name;
        	}
        	set
        	{
        		_Name = value;
        		NameValueFlag = true;
        	}
        }
        
		      	private string _HomeBg;
      	public bool HomeBgValueFlag = false;
		/// <summary>
		/// HomeBg
        /// </summary>		
        public string HomeBg{
        	get
        	{
        		return _HomeBg;
        	}
        	set
        	{
        		_HomeBg = value;
        		HomeBgValueFlag = true;
        	}
        }
        
		      	private string _Icon;
      	public bool IconValueFlag = false;
		/// <summary>
		/// Icon
        /// </summary>		
        public string Icon{
        	get
        	{
        		return _Icon;
        	}
        	set
        	{
        		_Icon = value;
        		IconValueFlag = true;
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
        
		      	private int _HomeShowFlag;
      	public bool HomeShowFlagValueFlag = false;
		/// <summary>
		/// HomeShowFlag
        /// </summary>		
        public int HomeShowFlag{
        	get
        	{
        		return _HomeShowFlag;
        	}
        	set
        	{
        		_HomeShowFlag = value;
        		HomeShowFlagValueFlag = true;
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