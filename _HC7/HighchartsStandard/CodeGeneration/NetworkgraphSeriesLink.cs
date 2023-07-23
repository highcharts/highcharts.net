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
	public partial class NetworkgraphSeriesLink  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NetworkgraphSeriesLink()
		{
			Color = Color_DefaultValue = "rgba(100, 100, 100, 0.5)";
			DashStyle = DashStyle_DefaultValue = NetworkgraphSeriesLinkDashStyle.Null;
			Opacity = Opacity_DefaultValue = 1;
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
		public NetworkgraphSeriesLinkDashStyle DashStyle { get; set; }
		private NetworkgraphSeriesLinkDashStyle DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Opacity of the link between two nodes.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// Width (px) of the link between two nodes.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", highcharts.FirstCharacterToLower(DashStyle.ToString()));
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
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