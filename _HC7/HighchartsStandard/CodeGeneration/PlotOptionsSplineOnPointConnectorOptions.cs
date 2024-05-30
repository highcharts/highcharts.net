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
	public partial class PlotOptionsSplineOnPointConnectorOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSplineOnPointConnectorOptions()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// A name for the dash style to use for the connector.
		/// </summary>
		public Hashtable Dashstyle { get; set; }
		private Hashtable Dashstyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the connector line. By default it's the series' color.
		/// </summary>
		public string Stroke { get; set; }
		private string Stroke_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pixel width of the connector line.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Dashstyle != null) h.Add("dashstyle",Dashstyle);
			if (Stroke != null) h.Add("stroke",Stroke);
			if (Width != null) h.Add("width",Width);
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