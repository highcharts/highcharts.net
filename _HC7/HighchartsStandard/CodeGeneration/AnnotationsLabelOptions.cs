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
	public partial class AnnotationsLabelOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsLabelOptions()
		{
		}	
		

		/// <summary>
		/// Accessibility options for an annotation label.
		/// </summary>
		public AnnotationsLabelOptionsAccessibility Accessibility { get; set; }
		 

		/// <summary>
		/// The alignment of the annotation's label. If right,the right side of the label should be touching the point.
		/// </summary>
		public AnnotationsLabelOptionsAlign Align { get; set; }
		 

		/// <summary>
		/// Whether to allow the annotation's labels to overlap.To make the labels less sensitive for overlapping,the can be set to 0.
		/// </summary>
		public bool? AllowOverlap { get; set; }
		 

		/// <summary>
		/// The background color or gradient for the annotation'slabel.
		/// </summary>
		public string BackgroundColor { get; set; }
		 

		/// <summary>
		/// The border color for the annotation's label.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// The border radius in pixels for the annotation's label.
		/// </summary>
		public double? BorderRadius { get; set; }
		 

		/// <summary>
		/// The border width in pixels for the annotation's label
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// A class name for styling by CSS.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// Whether to hide the annotation's labelthat is outside the plot area.
		/// </summary>
		public bool? Crop { get; set; }
		 

		/// <summary>
		/// The label's pixel distance from the point.
		/// </summary>
		public double? Distance { get; set; }
		 

		/// <summary>
		/// A[format](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting)string for the data label.
		/// </summary>
		public string Format { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to format the annotation'slabel. Note that if a `format` or `text` are defined,the format or text take precedence and the formatter isignored. `This` refers to a point object.
		/// </summary>
		public string Formatter { get; set; }
		 

		/// <summary>
		/// Whether the annotation is visible in the exported datatable.
		/// </summary>
		public bool? IncludeInDataExport { get; set; }
		 

		/// <summary>
		/// How to handle the annotation's label that flow outsidethe plot area. The justify option aligns the label insidethe plot area.
		/// </summary>
		public AnnotationsLabelOptionsOverflow Overflow { get; set; }
		 

		/// <summary>
		/// When either the borderWidth or the backgroundColor isset, this is the padding within the box.
		/// </summary>
		public double? Padding { get; set; }
		 

		/// <summary>
		/// The shadow of the box. The shadow can be an objectconfiguration containing `color`, `offsetX`, `offsetY`,`opacity` and `width`.
		/// </summary>
		public Shadow Shadow { get; set; }
		 

		/// <summary>
		/// The shadow of the box. The shadow can be an objectconfiguration containing `color`, `offsetX`, `offsetY`,`opacity` and `width`.
		/// </summary>
		public bool? ShadowBool { get; set; }
		 

		/// <summary>
		/// The name of a symbol to use for the border around thelabel. Symbols are predefined functions on the Rendererobject.
		/// </summary>
		public string Shape { get; set; }
		 

		/// <summary>
		/// Styles for the annotation's label.
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// Alias for the format option.
		/// </summary>
		public string Text { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the annotation's label.
		/// </summary>
		public bool? UseHTML { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the annotation's label.
		/// </summary>
		public AnnotationsLabelOptionsVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to the point.Note that if a `distance` is defined, the distance takesprecedence over `x` and `y` options.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the point.Note that if a `distance` is defined, the distance takesprecedence over `x` and `y` options.
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Accessibility != null) h.Add("accessibility",Accessibility.ToHashtable(highcharts));
			if (Align != AnnotationsLabelOptionsAlign.Null) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (AllowOverlap != null) h.Add("allowOverlap",AllowOverlap);
			if (BackgroundColor != null) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderRadius != null) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (ClassName != null) h.Add("className",ClassName);
			if (Crop != null) h.Add("crop",Crop);
			if (Distance != null) h.Add("distance",Distance);
			if (Format != null) h.Add("format",Format);
			if (Formatter != null) { h.Add("formatter",Formatter); highcharts.AddFunction("formatter", Formatter); }  
			if (IncludeInDataExport != null) h.Add("includeInDataExport",IncludeInDataExport);
			if (Overflow != AnnotationsLabelOptionsOverflow.Null) h.Add("overflow", highcharts.FirstCharacterToLower(Overflow.ToString()));
			if (Padding != null) h.Add("padding",Padding);
			if (Shadow != null) h.Add("shadow",Shadow.ToHashtable(highcharts));
			if (ShadowBool != null) h.Add("shadow",ShadowBool);
			if (Shape != null) h.Add("shape",Shape);
			if (Style != null) h.Add("style",Style);
			if (Text != null) h.Add("text",Text);
			if (UseHTML != null) h.Add("useHTML",UseHTML);
			if (VerticalAlign != AnnotationsLabelOptionsVerticalAlign.Null) h.Add("verticalAlign", highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != null) h.Add("x",X);
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