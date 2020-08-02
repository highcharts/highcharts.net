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
	public partial class VbpSeriesZoneLines  : BaseObject
	{
		Hashtable h = new Hashtable();

		public VbpSeriesZoneLines()
		{
			Enabled = Enabled_DefaultValue = true;
			Styles = Styles_DefaultValue = new Hashtable();
			
		}	
		

		/// <summary>
		/// Enable/disable zone lines.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specify the style of zone lines.
		/// </summary>
		public Hashtable Styles { get; set; }
		private Hashtable Styles_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Styles != Styles_DefaultValue) h.Add("styles",Styles);
			

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