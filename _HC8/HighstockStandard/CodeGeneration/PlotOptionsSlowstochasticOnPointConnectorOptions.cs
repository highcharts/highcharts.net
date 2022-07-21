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
	public partial class PlotOptionsSlowstochasticOnPointConnectorOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSlowstochasticOnPointConnectorOptions()
		{
			Dashstyle = Dashstyle_DefaultValue = new Hashtable();
			Stroke = Stroke_DefaultValue = "";
			Width = Width_DefaultValue = 1;
			
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
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Dashstyle != Dashstyle_DefaultValue) h.Add("dashstyle",Dashstyle);
			if (Stroke != Stroke_DefaultValue) h.Add("stroke",Stroke);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}