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
	public partial class PlotOptionsNetworkgraphLink  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsNetworkgraphLink()
		{
			Color = Color_DefaultValue = "rgba(100, 100, 100, 0.5)";
			DashStyle = DashStyle_DefaultValue = PlotOptionsNetworkgraphLinkDashStyle.Null;
			Width = Width_DefaultValue = 1;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Color of the link between two nodes.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// A name for the dash style to use for links.
		/// </summary>
		public PlotOptionsNetworkgraphLinkDashStyle DashStyle { get; set; }
		private PlotOptionsNetworkgraphLinkDashStyle DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Width (px) of the link between two nodes.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", Highcharts.FirstCharacterToLower(DashStyle.ToString()));
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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