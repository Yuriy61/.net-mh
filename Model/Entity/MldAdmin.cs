using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AMW.Model.Entity
{
	 	//MldAdmin
		public class MldAdmin
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
        
		      	private int _Rid;
      	public bool RidValueFlag = false;
		/// <summary>
		/// Rid
        /// </summary>		
        public int Rid{
        	get
        	{
        		return _Rid;
        	}
        	set
        	{
        		_Rid = value;
        		RidValueFlag = true;
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
        
		      	private string _Pwd;
      	public bool PwdValueFlag = false;
		/// <summary>
		/// Pwd
        /// </summary>		
        public string Pwd{
        	get
        	{
        		return _Pwd;
        	}
        	set
        	{
        		_Pwd = value;
        		PwdValueFlag = true;
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
        
		      	private DateTime _LastLoginTime;
      	public bool LastLoginTimeValueFlag = false;
		/// <summary>
		/// LastLoginTime
        /// </summary>		
        public DateTime LastLoginTime{
        	get
        	{
        		return _LastLoginTime;
        	}
        	set
        	{
        		_LastLoginTime = value;
        		LastLoginTimeValueFlag = true;
        	}
        }
        
		      	private string _LastLoginIP;
      	public bool LastLoginIPValueFlag = false;
		/// <summary>
		/// LastLoginIP
        /// </summary>		
        public string LastLoginIP{
        	get
        	{
        		return _LastLoginIP;
        	}
        	set
        	{
        		_LastLoginIP = value;
        		LastLoginIPValueFlag = true;
        	}
        }
        
		      	private int _IsLock;
      	public bool IsLockValueFlag = false;
		/// <summary>
		/// IsLock
        /// </summary>		
        public int IsLock{
        	get
        	{
        		return _IsLock;
        	}
        	set
        	{
        		_IsLock = value;
        		IsLockValueFlag = true;
        	}
        }
        
		   
	}
}