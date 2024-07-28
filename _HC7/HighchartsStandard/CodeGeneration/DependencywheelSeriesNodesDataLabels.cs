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
	public partial class DependencywheelSeriesNodesDataLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public DependencywheelSeriesNodesDataLabels()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string BackgroundColor { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Crop { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public DependencywheelSeriesNodesDataLabelsFormat Format { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FormatString { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Formatter { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Inside { get; set; }
		 

		/// <summary>
		/// The[format string](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting)specifying what to show for _nodes_ in the sankey diagram. Bydefault the `nodeFormatter` returns `{point.name}`.
		/// </summary>
		public string NodeFormat { get; set; }
		 

		/// <summary>
		/// Callback to format data labels for _nodes_ in the sankey diagram.The `nodeFormat` option takes precedence over the`nodeFormatter`.
		/// </summary>
		public string NodeFormatter { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (BackgroundColor != null) h.Add("backgroundColor",BackgroundColor);
			if (Crop != null) h.Add("crop",Crop);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Format != null) h.Add("format",Format.ToHashtable(highcharts));
			if (FormatString != null) h.Add("format",FormatString);
			if (Formatter != null) { h.Add("formatter",Formatter); highcharts.AddFunction("formatter", Formatter); }  
			if (Inside != null) h.Add("inside",Inside);
			if (NodeFormat != null) h.Add("nodeFormat",NodeFormat);
			if (NodeFormatter != null) { h.Add("nodeFormatter",NodeFormatter); highcharts.AddFunction("nodeFormatter", NodeFormatter); }  
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}