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
	public partial class NoData  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NoData()
		{
			Attr = Attr_DefaultValue = new Hashtable();
			Position = Position_DefaultValue = new NoDataPosition();
			Style = Style_DefaultValue = new Hashtable();
			UseHTML = UseHTML_DefaultValue = false;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// An object of additional SVG attributes for the no-data label.
		/// </summary>
		public Hashtable Attr { get; set; }
		private Hashtable Attr_DefaultValue { get; set; }
		 

		/// <summary>
		/// The position of the no-data label, relative to the plot area.
		/// </summary>
		public NoDataPosition Position { get; set; }
		private NoDataPosition Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the no-data label.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to insert the label as HTML, or as pseudo-HTML rendered withSVG.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Attr != Attr_DefaultValue) h.Add("attr",Attr);
			if (Position.IsDirty(ref highcharts)) h.Add("position",Position.ToHashtable(ref highcharts));
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}