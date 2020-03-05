using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class NavigationBindingsZoomX  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationBindingsZoomX()
		{
			Init = Init_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Init { get; set; }
		private string Init_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Init != Init_DefaultValue) h.Add("init",Init);
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}