using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AMW.Model.Entity
{
	 	//MldProductImg
		public class MldProductImg
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
        
		      	private int _Pid;
      	public bool PidValueFlag = false;
		/// <summary>
		/// Pid
        /// </summary>		
        public int Pid{
        	get
        	{
        		return _Pid;
        	}
        	set
        	{
        		_Pid = value;
        		PidValueFlag = true;
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
        
		   
	}
}