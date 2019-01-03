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
	public partial class PlotOptionsAreasplineLabelStyle  : BaseObject
	{
		public PlotOptionsAreasplineLabelStyle()
		{
			Font-weight = Font-weight_DefaultValue = "bold";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Font-weight { get; set; }
		private string Font-weight_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Font-weight.IsDirty()) h.Add("font-weight",Font-weight.ToHashtable());
			

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