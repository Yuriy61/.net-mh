using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AMW.Model.Entity
{
	 	//MldProduct
		public class MldProduct
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
        
		      	private int _Cid;
      	public bool CidValueFlag = false;
		/// <summary>
		/// Cid
        /// </summary>		
        public int Cid{
        	get
        	{
        		return _Cid;
        	}
        	set
        	{
        		_Cid = value;
        		CidValueFlag = true;
        	}
        }
        
		      	private int _AllShowFlag;
      	public bool AllShowFlagValueFlag = false;
		/// <summary>
		/// AllShowFlag
        /// </summary>		
        public int AllShowFlag{
        	get
        	{
        		return _AllShowFlag;
        	}
        	set
        	{
        		_AllShowFlag = value;
        		AllShowFlagValueFlag = true;
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
        
		      	private int _IsElite;
      	public bool IsEliteValueFlag = false;
		/// <summary>
		/// IsElite
        /// </summary>		
        public int IsElite{
        	get
        	{
        		return _IsElite;
        	}
        	set
        	{
        		_IsElite = value;
        		IsEliteValueFlag = true;
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
        
		      	private string _Profile;
      	public bool ProfileValueFlag = false;
		/// <summary>
		/// Profile
        /// </summary>		
        public string Profile{
        	get
        	{
        		return _Profile;
        	}
        	set
        	{
        		_Profile = value;
        		ProfileValueFlag = true;
        	}
        }
        
		      	private string _Application;
      	public bool ApplicationValueFlag = false;
		/// <summary>
		/// Application
        /// </summary>		
        public string Application{
        	get
        	{
        		return _Application;
        	}
        	set
        	{
        		_Application = value;
        		ApplicationValueFlag = true;
        	}
        }
        
		      	private string _Material;
      	public bool MaterialValueFlag = false;
		/// <summary>
		/// Material
        /// </summary>		
        public string Material{
        	get
        	{
        		return _Material;
        	}
        	set
        	{
        		_Material = value;
        		MaterialValueFlag = true;
        	}
        }
        
		      	private string _Weight;
      	public bool WeightValueFlag = false;
		/// <summary>
		/// Weight
        /// </summary>		
        public string Weight{
        	get
        	{
        		return _Weight;
        	}
        	set
        	{
        		_Weight = value;
        		WeightValueFlag = true;
        	}
        }
        
		      	private string _Length;
      	public bool LengthValueFlag = false;
		/// <summary>
		/// Length
        /// </summary>		
        public string Length{
        	get
        	{
        		return _Length;
        	}
        	set
        	{
        		_Length = value;
        		LengthValueFlag = true;
        	}
        }
        
		      	private string _MassOfInertia;
      	public bool MassOfInertiaValueFlag = false;
		/// <summary>
		/// MassOfInertia
        /// </summary>		
        public string MassOfInertia{
        	get
        	{
        		return _MassOfInertia;
        	}
        	set
        	{
        		_MassOfInertia = value;
        		MassOfInertiaValueFlag = true;
        	}
        }
        
		      	private string _SectionModulus;
      	public bool SectionModulusValueFlag = false;
		/// <summary>
		/// SectionModulus
        /// </summary>		
        public string SectionModulus{
        	get
        	{
        		return _SectionModulus;
        	}
        	set
        	{
        		_SectionModulus = value;
        		SectionModulusValueFlag = true;
        	}
        }
        
		      	private string _ProfileImg;
      	public bool ProfileImgValueFlag = false;
		/// <summary>
		/// ProfileImg
        /// </summary>		
        public string ProfileImg{
        	get
        	{
        		return _ProfileImg;
        	}
        	set
        	{
        		_ProfileImg = value;
        		ProfileImgValueFlag = true;
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
        public string CategoryName1 { get; set; }
        public string CategoryName2 { get; set; }
		   
	}
}