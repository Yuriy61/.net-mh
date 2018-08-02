using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AMW.Model.Entity
{
	 	//MldProductCategory
		public class MldProductCategory
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
        
		      	private int _Tid;
      	public bool TidValueFlag = false;
		/// <summary>
		/// Tid
        /// </summary>		
        public int Tid{
        	get
        	{
        		return _Tid;
        	}
        	set
        	{
        		_Tid = value;
        		TidValueFlag = true;
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
        
		      	private int _Order;
      	public bool OrderValueFlag = false;
		/// <summary>
		/// Order
        /// </summary>		
        public int Order{
        	get
        	{
        		return _Order;
        	}
        	set
        	{
        		_Order = value;
        		OrderValueFlag = true;
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