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
	public partial class SankeySeriesNodesDataLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public SankeySeriesNodesDataLabels()
		{
			BackgroundColor = BackgroundColor_DefaultValue = "none";
			Crop = Crop_DefaultValue = false;
			Enabled = Enabled_DefaultValue = true;
			Format = Format_DefaultValue = new SankeySeriesNodesDataLabelsFormat();
			FormatString = FormatString_DefaultValue = "null";
			Formatter = Formatter_DefaultValue = "";
			Inside = Inside_DefaultValue = true;
			NodeFormat = NodeFormat_DefaultValue = "undefined";
			NodeFormatter = NodeFormatter_DefaultValue = "";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Crop { get; set; }
		private bool? Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public SankeySeriesNodesDataLabelsFormat Format { get; set; }
		private SankeySeriesNodesDataLabelsFormat Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FormatString { get; set; }
		private string FormatString_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Inside { get; set; }
		private bool? Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// The[format string](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting)specifying what to show for _nodes_ in the sankey diagram. Bydefault the `nodeFormatter` returns `{point.name}`.
		/// </summary>
		public string NodeFormat { get; set; }
		private string NodeFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback to format data labels for _nodes_ in the sankey diagram.The `nodeFormat` option takes precedence over the`nodeFormatter`.
		/// </summary>
		public string NodeFormatter { get; set; }
		private string NodeFormatter_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Format.IsDirty()) h.Add("format",Format.ToHashtable());
			if (FormatString != FormatString_DefaultValue) h.Add("format",FormatString);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highcharts.AddFunction("97aa9f7f-f024-4540-84e0-9681064dd49b.formatter", Formatter); }  
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (NodeFormat != NodeFormat_DefaultValue) h.Add("nodeFormat",NodeFormat);
			if (NodeFormatter != NodeFormatter_DefaultValue) { h.Add("nodeFormatter",NodeFormatter); Highcharts.AddFunction("1f4d1e36-66e6-4ae6-b7fc-77db1091e068.nodeFormatter", NodeFormatter); }  
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