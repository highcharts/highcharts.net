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
	public partial class NavigatorXAxisDateTimeLabelFormatsHour  : BaseObject
	{
		public NavigatorXAxisDateTimeLabelFormatsHour()
		{
			Main = Main_DefaultValue = "%H:%M";
			Range = Range_DefaultValue = false;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Main { get; set; }
		private string Main_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Range { get; set; }
		private bool? Range_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Main != Main_DefaultValue) h.Add("main",Main);
			if (Range != Range_DefaultValue) h.Add("range",Range);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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