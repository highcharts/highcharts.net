using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class NavigationBindingsRay  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationBindingsRay()
		{
			Start = Start_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Start { get; set; }
		private string Start_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Start != Start_DefaultValue) h.Add("start",Start);
			

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