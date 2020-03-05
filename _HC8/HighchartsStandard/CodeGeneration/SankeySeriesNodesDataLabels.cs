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
			Formatter = Formatter_DefaultValue = "";
			Inside = Inside_DefaultValue = true;
			NodeFormat = NodeFormat_DefaultValue = "undefined";
			NodeFormatter = NodeFormatter_DefaultValue = "";
			
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
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Format.IsDirty()) h.Add("format",Format.ToHashtable());
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highcharts.AddFunction("7ba12d94-41a9-463d-9b24-b4f0c4e33c49.formatter", Formatter); }  
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (NodeFormat != NodeFormat_DefaultValue) h.Add("nodeFormat",NodeFormat);
			if (NodeFormatter != NodeFormatter_DefaultValue) { h.Add("nodeFormatter",NodeFormatter); Highcharts.AddFunction("75ab45f7-0fdb-49c7-87a7-48b51862e4d8.nodeFormatter", NodeFormatter); }  
			

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