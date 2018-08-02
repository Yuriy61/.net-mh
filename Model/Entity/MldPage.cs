using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AMW.Model.Entity
{
	 	//MldPage
		public class MldPage
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
        
		      	private string _Intro;
      	public bool IntroValueFlag = false;
		/// <summary>
		/// Intro
        /// </summary>		
        public string Intro{
        	get
        	{
        		return _Intro;
        	}
        	set
        	{
        		_Intro = value;
        		IntroValueFlag = true;
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