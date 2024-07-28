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
	public partial class PlotOptionsDisparityindexLastPriceLabel  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsDisparityindexLastPriceLabel()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsDisparityindexLastPriceLabelAlign Align { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BackgroundColor { get; set; }
		 

		/// <summary>
		/// The border color of `lastPrice` label.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// The border radius of `lastPrice` label.
		/// </summary>
		public double? BorderRadius { get; set; }
		 

		/// <summary>
		/// The border width for the `lastPrice` label.
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// Flag to enable `lastPrice` label.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// A format string for the `lastPrice` label. Defaults to `{value}` fornumeric axes and `{value:%b %d, %Y}` for datetime axes.
		/// </summary>
		public string Format { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Formatter { get; set; }
		 

		/// <summary>
		/// Padding inside the `lastPrice` label.
		/// </summary>
		public double? Padding { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Shape { get; set; }
		 

		/// <summary>
		/// Text styles for the `lastPrice` label.
		/// </summary>
		public Hashtable Style { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Align != PlotOptionsDisparityindexLastPriceLabelAlign.Null) h.Add("align", highstock.FirstCharacterToLower(Align.ToString()));
			if (BackgroundColor != null) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderRadius != null) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Format != null) h.Add("format",Format);
			if (Formatter != null) { h.Add("formatter",Formatter); highstock.AddFunction("formatter", Formatter); }  
			if (Padding != null) h.Add("padding",Padding);
			if (Shape != null) h.Add("shape",Shape);
			if (Style != null) h.Add("style",Style);
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