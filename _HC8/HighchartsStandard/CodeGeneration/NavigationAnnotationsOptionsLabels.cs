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
	public partial class NavigationAnnotationsOptionsLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationAnnotationsOptionsLabels()
		{
			Accessibility = Accessibility_DefaultValue = new NavigationAnnotationsOptionsLabelsAccessibility();
			Align = Align_DefaultValue = NavigationAnnotationsOptionsLabelsAlign.Center;
			AllowOverlap = AllowOverlap_DefaultValue = false;
			BackgroundColor = BackgroundColor_DefaultValue = "rgba(0, 0, 0, 0.75)";
			BorderColor = BorderColor_DefaultValue = "black";
			BorderRadius = BorderRadius_DefaultValue = 3;
			BorderWidth = BorderWidth_DefaultValue = 1;
			ClassName = ClassName_DefaultValue = "";
			Crop = Crop_DefaultValue = false;
			Distance = Distance_DefaultValue = null;
			Format = Format_DefaultValue = "";
			Formatter = Formatter_DefaultValue = "";
			IncludeInDataExport = IncludeInDataExport_DefaultValue = true;
			Overflow = Overflow_DefaultValue = NavigationAnnotationsOptionsLabelsOverflow.Justify;
			Padding = Padding_DefaultValue = "5";
			Point = Point_DefaultValue = new NavigationAnnotationsOptionsLabelsPoint();
			PointString = PointString_DefaultValue = "null";
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShadowBool = ShadowBool_DefaultValue = null;
			Shape = Shape_DefaultValue = "callout";
			Style = Style_DefaultValue = new Hashtable();
			Text = Text_DefaultValue = "";
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = NavigationAnnotationsOptionsLabelsVerticalAlign.Bottom;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = -16;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Accessibility options for an annotation label.
		/// </summary>
		public NavigationAnnotationsOptionsLabelsAccessibility Accessibility { get; set; }
		private NavigationAnnotationsOptionsLabelsAccessibility Accessibility_DefaultValue { get; set; }
		 

		/// <summary>
		/// The alignment of the annotation's label. If right,the right side of the label should be touching the point.
		/// </summary>
		public NavigationAnnotationsOptionsLabelsAlign Align { get; set; }
		private NavigationAnnotationsOptionsLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to allow the annotation's labels to overlap.To make the labels less sensitive for overlapping,the can be set to 0.
		/// </summary>
		public bool? AllowOverlap { get; set; }
		private bool? AllowOverlap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The background color or gradient for the annotation'slabel.
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color for the annotation's label.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border radius in pixels for the annotaiton's label.
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width in pixels for the annotation's label
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// A class name for styling by CSS.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to hide the annotation's labelthat is outside the plot area.
		/// </summary>
		public bool? Crop { get; set; }
		private bool? Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// The label's pixel distance from the point.
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// A[format](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting)string for the data label.
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to format the annotation'slabel. Note that if a `format` or `text` are defined,the format or text take precedence and the formatter isignored. `This` refers to a point object.
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the annotation is visible in the exported datatable.
		/// </summary>
		public bool? IncludeInDataExport { get; set; }
		private bool? IncludeInDataExport_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to handle the annotation's label that flow outsidethe plot area. The justify option aligns the label insidethe plot area.
		/// </summary>
		public NavigationAnnotationsOptionsLabelsOverflow Overflow { get; set; }
		private NavigationAnnotationsOptionsLabelsOverflow Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// When either the borderWidth or the backgroundColor isset, this is the padding within the box.
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option defines the point to which the label will beconnected. It can be either the point which exists in theseries - it is referenced by the point's id - or a new pointwith defined x, y properties and optionally axes.
		/// </summary>
		public NavigationAnnotationsOptionsLabelsPoint Point { get; set; }
		private NavigationAnnotationsOptionsLabelsPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option defines the point to which the label will beconnected. It can be either the point which exists in theseries - it is referenced by the point's id - or a new pointwith defined x, y properties and optionally axes.
		/// </summary>
		public string PointString { get; set; }
		private string PointString_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow of the box. The shadow can be an objectconfiguration containing `color`, `offsetX`, `offsetY`,`opacity` and `width`.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow of the box. The shadow can be an objectconfiguration containing `color`, `offsetX`, `offsetY`,`opacity` and `width`.
		/// </summary>
		public bool? ShadowBool { get; set; }
		private bool? ShadowBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of a symbol to use for the border around thelabel. Symbols are predefined functions on the Rendererobject.
		/// </summary>
		public string Shape { get; set; }
		private string Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styles for the annotation's label.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// Alias for the format option.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the annotation's label.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the annotation's label.
		/// </summary>
		public NavigationAnnotationsOptionsLabelsVerticalAlign VerticalAlign { get; set; }
		private NavigationAnnotationsOptionsLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to the point.Note that if a `distance` is defined, the distance takesprecedence over `x` and `y` options.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the point.Note that if a `distance` is defined, the distance takesprecedence over `x` and `y` options.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Accessibility.IsDirty()) h.Add("accessibility",Accessibility.ToHashtable());
			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highcharts.AddFunction("formatter", Formatter); }  
			if (IncludeInDataExport != IncludeInDataExport_DefaultValue) h.Add("includeInDataExport",IncludeInDataExport);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow", Highcharts.FirstCharacterToLower(Overflow.ToString()));
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (PointString != PointString_DefaultValue) h.Add("point",PointString);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShadowBool != ShadowBool_DefaultValue) h.Add("shadow",ShadowBool);
			if (Shape != Shape_DefaultValue) h.Add("shape",Shape);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
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