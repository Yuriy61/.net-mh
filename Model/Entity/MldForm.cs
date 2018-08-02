using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AMW.Model.Entity
{
	 	//MldForm
		public class MldForm
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
        
		      	private string _Phone;
      	public bool PhoneValueFlag = false;
		/// <summary>
		/// Phone
        /// </summary>		
        public string Phone{
        	get
        	{
        		return _Phone;
        	}
        	set
        	{
        		_Phone = value;
        		PhoneValueFlag = true;
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