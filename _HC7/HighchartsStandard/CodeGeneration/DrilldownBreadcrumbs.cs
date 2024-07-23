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
	public partial class DrilldownBreadcrumbs  : BaseObject
	{
		Hashtable h = new Hashtable();

		public DrilldownBreadcrumbs()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The default padding for each button and separator in each direction.
		/// </summary>
		public double? ButtonSpacing { get; set; }
		 

		/// <summary>
		/// A collection of attributes for the buttons. The object takes SVGattributes like `fill`, `stroke`, `stroke-width`, as well as `style`,a collection of CSS properties for the text.The object can also be extended with states, so you can setpresentational options for `hover`, `select` or `disabled` buttonstates.
		/// </summary>
		public DrilldownBreadcrumbsButtonTheme ButtonTheme { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public DrilldownBreadcrumbsEvents Events { get; set; }
		 

		/// <summary>
		/// When the breadcrumbs are floating, the plot area will not move tomake space for it. By default, the chart will not make space for thebuttons. This property won't work when positioned in the middle.
		/// </summary>
		public bool? Floating { get; set; }
		 

		/// <summary>
		/// A format string for the breadcrumbs button. Variables are enclosed bycurly brackets. Available values are passed in the declared pointoptions.
		/// </summary>
		public string Format { get; set; }
		 

		/// <summary>
		/// Callback function to format the breadcrumb text from scratch.
		/// </summary>
		public string Formatter { get; set; }
		 

		/// <summary>
		/// Positioning for the button row. The breadcrumbs buttons will bealigned properly for the default chart layout (title,  subtitle,legend, range selector) for the custom chart layout set the positionproperties.
		/// </summary>
		public DrilldownBreadcrumbsPosition Position { get; set; }
		 

		/// <summary>
		/// What box to align the button to. Can be either `plotBox` or`spacingBox`.
		/// </summary>
		public string RelativeTo { get; set; }
		 

		/// <summary>
		/// Whether to reverse the order of buttons. This is common in Arabicand Hebrew.
		/// </summary>
		public bool? Rtl { get; set; }
		 

		/// <summary>
		/// Options object for Breadcrumbs separator.
		/// </summary>
		public DrilldownBreadcrumbsSeparator Separator { get; set; }
		 

		/// <summary>
		/// Show full path or only a single button.
		/// </summary>
		public bool? ShowFullPath { get; set; }
		 

		/// <summary>
		/// CSS styles for all breadcrumbs.In styled mode, the breadcrumbs buttons are styled by the`.highcharts-breadcrumbs-buttons .highcharts-button` rule with itsdifferent states.
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// Whether to use HTML to render the breadcrumbs items texts.
		/// </summary>
		public bool? UseHTML { get; set; }
		 

		/// <summary>
		/// The z index of the breadcrumbs group.
		/// </summary>
		public double? ZIndex { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (ButtonSpacing != null) h.Add("buttonSpacing",ButtonSpacing);
			if (ButtonTheme != null) h.Add("buttonTheme",ButtonTheme.ToHashtable(highcharts));
			if (Events != null) h.Add("events",Events.ToHashtable(highcharts));
			if (Floating != null) h.Add("floating",Floating);
			if (Format != null) h.Add("format",Format);
			if (Formatter != null) { h.Add("formatter",Formatter); highcharts.AddFunction("formatter", Formatter); }  
			if (Position != null) h.Add("position",Position.ToHashtable(highcharts));
			if (RelativeTo != null) h.Add("relativeTo",RelativeTo);
			if (Rtl != null) h.Add("rtl",Rtl);
			if (Separator != null) h.Add("separator",Separator.ToHashtable(highcharts));
			if (ShowFullPath != null) h.Add("showFullPath",ShowFullPath);
			if (Style != null) h.Add("style",Style);
			if (UseHTML != null) h.Add("useHTML",UseHTML);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
			if (CustomFields.Count > 0)
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