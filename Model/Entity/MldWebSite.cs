using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AMW.Model.Entity
{
	 	//MldWebSite
		public class MldWebSite
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
        
		      	private string _Logo;
      	public bool LogoValueFlag = false;
		/// <summary>
		/// Logo
        /// </summary>		
        public string Logo{
        	get
        	{
        		return _Logo;
        	}
        	set
        	{
        		_Logo = value;
        		LogoValueFlag = true;
        	}
        }
        
		      	private string _KeyWord;
      	public bool KeyWordValueFlag = false;
		/// <summary>
		/// KeyWord
        /// </summary>		
        public string KeyWord{
        	get
        	{
        		return _KeyWord;
        	}
        	set
        	{
        		_KeyWord = value;
        		KeyWordValueFlag = true;
        	}
        }
        
		      	private string _Description;
      	public bool DescriptionValueFlag = false;
		/// <summary>
		/// Description
        /// </summary>		
        public string Description{
        	get
        	{
        		return _Description;
        	}
        	set
        	{
        		_Description = value;
        		DescriptionValueFlag = true;
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
        
		   
	}
}