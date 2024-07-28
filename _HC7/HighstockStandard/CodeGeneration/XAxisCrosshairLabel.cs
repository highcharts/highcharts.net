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
	public partial class XAxisCrosshairLabel  : BaseObject
	{
		Hashtable h = new Hashtable();

		public XAxisCrosshairLabel()
		{
		}	
		

		/// <summary>
		/// Alignment of the label compared to the axis. Defaults to `"left"` forright-side axes, `"right"` for left-side axes and `"center"` forhorizontal axes.
		/// </summary>
		public XAxisCrosshairLabelAlign Align { get; set; }
		 

		/// <summary>
		/// The background color for the label. Defaults to the related seriescolor, or `#666666` if that is not available.
		/// </summary>
		public string BackgroundColor { get; set; }
		 

		/// <summary>
		/// The border color for the crosshair label
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// The border corner radius of the crosshair label.
		/// </summary>
		public double? BorderRadius { get; set; }
		 

		/// <summary>
		/// The border width for the crosshair label.
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// Flag to enable crosshair's label.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// A format string for the crosshair label. Defaults to `{value}` fornumeric axes and `{value:%b %d, %Y}` for datetime axes.
		/// </summary>
		public string Format { get; set; }
		 

		/// <summary>
		/// Formatter function for the label text.
		/// </summary>
		public string Formatter { get; set; }
		 

		/// <summary>
		/// Padding inside the crosshair label.
		/// </summary>
		public double? Padding { get; set; }
		 

		/// <summary>
		/// The shape to use for the label box.
		/// </summary>
		public string Shape { get; set; }
		 

		/// <summary>
		/// Text styles for the crosshair label.
		/// </summary>
		public Hashtable Style { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Align != XAxisCrosshairLabelAlign.Null) h.Add("align", highstock.FirstCharacterToLower(Align.ToString()));
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