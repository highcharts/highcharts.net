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
	public partial class AnnotationsLabels  : BaseObject
	{
		public AnnotationsLabels()
		{
			Point = Point_DefaultValue = new AnnotationsLabelsPoint();
			Align = Align_DefaultValue = AnnotationsLabelsAlign.Center;
			AllowOverlap = AllowOverlap_DefaultValue = false;
			BackgroundColor = BackgroundColor_DefaultValue = "rgba(0, 0, 0, 0.75)";
			BorderColor = BorderColor_DefaultValue = "black";
			BorderRadius = BorderRadius_DefaultValue = 1;
			BorderWidth = BorderWidth_DefaultValue = 1;
			Crop = Crop_DefaultValue = false;
			Formatter = Formatter_DefaultValue = "";
			Overflow = Overflow_DefaultValue = AnnotationsLabelsOverflow.Justify;
			Padding = Padding_DefaultValue = "5";
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			Shape = Shape_DefaultValue = "callout";
			Style = Style_DefaultValue = new AnnotationsLabelsStyle();
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = AnnotationsLabelsVerticalAlign.Bottom;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = -16;
			Format = Format_DefaultValue = "undefined";
			Text = Text_DefaultValue = "undefined";
			Distance = Distance_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// This option defines the point to which the label will be connected.It can be either the point which exists in the series - it is referencedby the point's id - or a new point with defined x, y properiesand optionally axes.
		/// </summary>
		public string Point { get; set; }
		private string Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// The alignment of the annotation's label. If right,the right side of the label should be touching the point.
		/// </summary>
		public AnnotationsLabelsAlign Align { get; set; }
		private AnnotationsLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to allow the annotation's labels to overlap.To make the labels less sensitive for overlapping, the can be set to 0.
		/// </summary>
		public bool? AllowOverlap { get; set; }
		private bool? AllowOverlap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The background color or gradient for the annotation's label.
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
		/// Whether to hide the annotation's label that is outside the plot area.
		/// </summary>
		public bool? Crop { get; set; }
		private bool? Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to format the annotation's label. Note thatif a `format` or `text` are defined, the format or text take precedenceand the formatter is ignored. `This` refers to a point object.
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to handle the annotation's label that flow outside the plotarea. The justify option aligns the label inside the plot area.
		/// </summary>
		public AnnotationsLabelsOverflow Overflow { get; set; }
		private AnnotationsLabelsOverflow Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// When either the borderWidth or the backgroundColor is set,thisis the padding within the box.
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow of the box. The shadow can be an object configurationcontaining `color`, `offsetX`, `offsetY`, `opacity` and `width`.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of a symbol to use for the border around the label.Symbols are predefined functions on the Renderer object.
		/// </summary>
		public string Shape { get; set; }
		private string Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styles for the annotation's label.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html) to render the annotation's label.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the annotation's label.
		/// </summary>
		public AnnotationsLabelsVerticalAlign VerticalAlign { get; set; }
		private AnnotationsLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

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
		 

		/// <summary>
		/// A [format](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting) string for the data label.
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// Alias for the format option.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// The label's pixel distance from the point.
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow", Highcharts.FirstCharacterToLower(Overflow.ToString()));
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (Shape != Shape_DefaultValue) h.Add("shape",Shape);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			

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