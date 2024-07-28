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
	public partial class NavigationButtonOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationButtonOptions()
		{
		}	
		

		/// <summary>
		/// Alignment for the buttons.
		/// </summary>
		public NavigationButtonOptionsAlign Align { get; set; }
		 

		/// <summary>
		/// The pixel spacing between buttons.
		/// </summary>
		public double? ButtonSpacing { get; set; }
		 

		/// <summary>
		/// Whether to enable buttons.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Pixel height of the buttons.
		/// </summary>
		public double? Height { get; set; }
		 

		/// <summary>
		/// Fill color for the symbol within the button.
		/// </summary>
		public string SymbolFill { get; set; }
		 

		/// <summary>
		/// The pixel size of the symbol on the button.
		/// </summary>
		public double? SymbolSize { get; set; }
		 

		/// <summary>
		/// The color of the symbol's stroke or line.
		/// </summary>
		public string SymbolStroke { get; set; }
		 

		/// <summary>
		/// The pixel stroke width of the symbol on the button.
		/// </summary>
		public double? SymbolStrokeWidth { get; set; }
		 

		/// <summary>
		/// The x position of the center of the symbol inside the button.
		/// </summary>
		public double? SymbolX { get; set; }
		 

		/// <summary>
		/// The y position of the center of the symbol inside the button.
		/// </summary>
		public double? SymbolY { get; set; }
		 

		/// <summary>
		/// A text string to add to the individual button.
		/// </summary>
		public string Text { get; set; }
		 

		/// <summary>
		/// A configuration object for the button theme. The object acceptsSVG properties like `stroke-width`, `stroke` and `fill`.Tri-state button styles are supported by the `states.hover` and`states.select` objects.
		/// </summary>
		public NavigationButtonOptionsTheme Theme { get; set; }
		 

		/// <summary>
		/// Whether to use HTML for rendering the button. HTML allows for thingslike inline CSS or image-based icons.
		/// </summary>
		public bool? UseHTML { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the buttons. Can be one of `"top"`,`"middle"` or `"bottom"`.
		/// </summary>
		public NavigationButtonOptionsVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// The pixel width of the button.
		/// </summary>
		public double? Width { get; set; }
		 

		/// <summary>
		/// The vertical offset of the button's position relative to its`verticalAlign`.
		/// </summary>
		public double? Y { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Align != NavigationButtonOptionsAlign.Null) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (ButtonSpacing != null) h.Add("buttonSpacing",ButtonSpacing);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Height != null) h.Add("height",Height);
			if (SymbolFill != null) h.Add("symbolFill",SymbolFill);
			if (SymbolSize != null) h.Add("symbolSize",SymbolSize);
			if (SymbolStroke != null) h.Add("symbolStroke",SymbolStroke);
			if (SymbolStrokeWidth != null) h.Add("symbolStrokeWidth",SymbolStrokeWidth);
			if (SymbolX != null) h.Add("symbolX",SymbolX);
			if (SymbolY != null) h.Add("symbolY",SymbolY);
			if (Text != null) h.Add("text",Text);
			if (Theme != null) h.Add("theme",Theme.ToHashtable(highcharts));
			if (UseHTML != null) h.Add("useHTML",UseHTML);
			if (VerticalAlign != NavigationButtonOptionsVerticalAlign.Null) h.Add("verticalAlign", highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (Width != null) h.Add("width",Width);
			if (Y != null) h.Add("y",Y);
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