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
	public partial class WmaSeriesLastPriceLabel  : BaseObject
	{
		Hashtable h = new Hashtable();

		public WmaSeriesLastPriceLabel()
		{
			Align = Align_DefaultValue = WmaSeriesLastPriceLabelAlign.Null;
			BackgroundColor = BackgroundColor_DefaultValue = "";
			BorderColor = BorderColor_DefaultValue = "";
			BorderRadius = BorderRadius_DefaultValue = null;
			BorderWidth = BorderWidth_DefaultValue = 0;
			Enabled = Enabled_DefaultValue = null;
			Format = Format_DefaultValue = "";
			Formatter = Formatter_DefaultValue = "";
			Padding = Padding_DefaultValue = "8";
			Shape = Shape_DefaultValue = "";
			Style = Style_DefaultValue = new Hashtable();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public WmaSeriesLastPriceLabelAlign Align { get; set; }
		private WmaSeriesLastPriceLabelAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color of `lastPrice` label.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border radius of `lastPrice` label.
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width for the `lastPrice` label.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Flag to enable `lastPrice` label.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// A format string for the `lastPrice` label. Defaults to `{value}` fornumeric axes and `{value:%b %d, %Y}` for datetime axes.
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding inside the `lastPrice` label.
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Shape { get; set; }
		private string Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// Text styles for the `lastPrice` label.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highstock.AddFunction("formatter", Formatter); }  
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Shape != Shape_DefaultValue) h.Add("shape",Shape);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			

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