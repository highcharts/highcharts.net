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
	public partial class PlotOptionsTreemapBreadcrumbs  : PlotOptionsSeries
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTreemapBreadcrumbs()
		{
			ButtonSpacing = ButtonSpacing_DefaultValue = 5;
			ButtonTheme = ButtonTheme_DefaultValue = new PlotOptionsTreemapBreadcrumbsButtonTheme();
			Events = Events_DefaultValue = new PlotOptionsTreemapBreadcrumbsEvents();
			Floating = Floating_DefaultValue = false;
			Format = Format_DefaultValue = "undefined";
			Formatter = Formatter_DefaultValue = "";
			Position = Position_DefaultValue = new Hashtable();
			RelativeTo = RelativeTo_DefaultValue = "plotBox";
			Separator = Separator_DefaultValue = new PlotOptionsTreemapBreadcrumbsSeparator();
			ShowFullPath = ShowFullPath_DefaultValue = true;
			Style = Style_DefaultValue = new Hashtable();
			UseHTML = UseHTML_DefaultValue = false;
			ZIndex = ZIndex_DefaultValue = 7;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The default padding for each button and separator in each direction.
		/// </summary>
		public double? ButtonSpacing { get; set; }
		private double? ButtonSpacing_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of attributes for the buttons. The object takes SVGattributes like `fill`, `stroke`, `stroke-width`, as well as `style`,a collection of CSS properties for the text.The object can also be extended with states, so you can setpresentational options for `hover`, `select` or `disabled` buttonstates.
		/// </summary>
		public PlotOptionsTreemapBreadcrumbsButtonTheme ButtonTheme { get; set; }
		private PlotOptionsTreemapBreadcrumbsButtonTheme ButtonTheme_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapBreadcrumbsEvents Events { get; set; }
		private PlotOptionsTreemapBreadcrumbsEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the breadcrumbs are floating, the plot area will not move tomake space for it. By default, the chart will not make space for thebuttons. This property won't work when positioned in the middle.
		/// </summary>
		public bool? Floating { get; set; }
		private bool? Floating_DefaultValue { get; set; }
		 

		/// <summary>
		/// A format string for the breadcrumbs button. Variables are enclosed bycurly brackets. Available values are passed in the declared pointoptions.
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback function to format the breadcrumb text from scratch.
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Positioning for the button row. The breadcrumbs buttons will bealigned properly for the default chart layout (title,  subtitle,legend, range selector) for the custom chart layout set the positionproperties.
		/// </summary>
		public Hashtable Position { get; set; }
		private Hashtable Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// What box to align the button to. Can be either `plotBox` or`spacingBox`.
		/// </summary>
		public string RelativeTo { get; set; }
		private string RelativeTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options object for Breadcrumbs separator.
		/// </summary>
		public PlotOptionsTreemapBreadcrumbsSeparator Separator { get; set; }
		private PlotOptionsTreemapBreadcrumbsSeparator Separator_DefaultValue { get; set; }
		 

		/// <summary>
		/// Show full path or only a single button.
		/// </summary>
		public bool? ShowFullPath { get; set; }
		private bool? ShowFullPath_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for all breadcrumbs.In styled mode, the breadcrumbs buttons are styled by the`.highcharts-breadcrumbs-buttons .highcharts-button` rule with itsdifferent states.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to use HTML to render the breadcrumbs items texts.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// The z index of the breadcrumbs group.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (ButtonSpacing != ButtonSpacing_DefaultValue) h.Add("buttonSpacing",ButtonSpacing);
			if (ButtonTheme.IsDirty(ref highcharts)) h.Add("buttonTheme",ButtonTheme.ToHashtable(ref highcharts));
			if (Events.IsDirty(ref highcharts)) h.Add("events",Events.ToHashtable(ref highcharts));
			if (Floating != Floating_DefaultValue) h.Add("floating",Floating);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); highcharts.AddFunction("formatter", Formatter); }  
			if (Position != Position_DefaultValue) h.Add("position",Position);
			if (RelativeTo != RelativeTo_DefaultValue) h.Add("relativeTo",RelativeTo);
			if (Separator.IsDirty(ref highcharts)) h.Add("separator",Separator.ToHashtable(ref highcharts));
			if (ShowFullPath != ShowFullPath_DefaultValue) h.Add("showFullPath",ShowFullPath);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}