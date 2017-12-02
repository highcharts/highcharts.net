using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class PlotOptionsSankeyDataLabels  : BaseObject
	{
		public PlotOptionsSankeyDataLabels()
		{
			Enabled = Enabled_DefaultValue = True;
			BackgroundColor = BackgroundColor_DefaultValue = none;
			Crop = Crop_DefaultValue = False;
			NodeFormat = NodeFormat_DefaultValue = "";
			NodeFormatter = NodeFormatter_DefaultValue = "";
			Format = Format_DefaultValue = "";
			Formatter = Formatter_DefaultValue = "";
			Inside = Inside_DefaultValue = True;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyDataLabelsEnabled Enabled { get; set; }
		private PlotOptionsSankeyDataLabelsEnabled Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyDataLabelsBackgroundColor BackgroundColor { get; set; }
		private PlotOptionsSankeyDataLabelsBackgroundColor BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyDataLabelsCrop Crop { get; set; }
		private PlotOptionsSankeyDataLabelsCrop Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// The [format string](http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting) specifying what to show for _nodes_ in the sankey diagram. By default the `nodeFormatter` returns`{point.name}`.
		/// </summary>
		public string NodeFormat { get; set; }
		private string NodeFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback to format data labels for _nodes_ in the sankey diagram. The `nodeFormat` option takes precedence over the `nodeFormatter`.
		/// </summary>
		public string NodeFormatter { get; set; }
		private string NodeFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// The [format string](http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting) specifying what to show for _links_ in the sankey diagram. Defaults to an empty string returned from the `formatter`, in effect disabling the labels.
		/// </summary>
		public PlotOptionsSankeyDataLabelsFormat Format { get; set; }
		private PlotOptionsSankeyDataLabelsFormat Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback to format data labels for _links_ in the sankey diagram. The `format` option takes precedence over the `formatter`.
		/// </summary>
		public PlotOptionsSankeyDataLabelsFormatter Formatter { get; set; }
		private PlotOptionsSankeyDataLabelsFormatter Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyDataLabelsInside Inside { get; set; }
		private PlotOptionsSankeyDataLabelsInside Inside_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (NodeFormat != NodeFormat_DefaultValue) h.Add("nodeFormat",NodeFormat);
			if (NodeFormatter != NodeFormatter_DefaultValue) h.Add("nodeFormatter",NodeFormatter);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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