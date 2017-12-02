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
	public partial class AnnotationsLabelOptions  : BaseObject
	{
		public AnnotationsLabelOptions()
		{
			Align = Align_DefaultValue = center;
			AllowOverlap = AllowOverlap_DefaultValue = False;
			BackgroundColor = BackgroundColor_DefaultValue = "rgba(0, 0, 0, 0.75)";
			BorderColor = BorderColor_DefaultValue = "black";
			BorderRadius = BorderRadius_DefaultValue = 1;
			BorderWidth = BorderWidth_DefaultValue = 1;
			Crop = Crop_DefaultValue = False;
			Formatter = Formatter_DefaultValue = "";
			Overflow = Overflow_DefaultValue = justify;
			Padding = Padding_DefaultValue = 5;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			Shape = Shape_DefaultValue = "callout";
			Style = Style_DefaultValue = "";
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = "bottom";
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = -16;
			Format = Format_DefaultValue = "undefined";
			Text = Text_DefaultValue = "undefined";
			Distance = Distance_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The alignment of the annotation's label. If right,the right side of the label should be touching the point.
		/// </summary>
		public AnnotationsLabelOptionsAlign Align { get; set; }
		private AnnotationsLabelOptionsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to allow the annotation's labels to overlap.To make the labels less sensitive for overlapping, the can be set to 0.
		/// </summary>
		public AnnotationsLabelOptionsAllowOverlap AllowOverlap { get; set; }
		private AnnotationsLabelOptionsAllowOverlap AllowOverlap_DefaultValue { get; set; }
		 

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
		public AnnotationsLabelOptionsBorderRadius BorderRadius { get; set; }
		private AnnotationsLabelOptionsBorderRadius BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width in pixels for the annotation's label
		/// </summary>
		public AnnotationsLabelOptionsBorderWidth BorderWidth { get; set; }
		private AnnotationsLabelOptionsBorderWidth BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to hide the annotation's label that is outside the plot area.
		/// </summary>
		public AnnotationsLabelOptionsCrop Crop { get; set; }
		private AnnotationsLabelOptionsCrop Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to format the annotation's label. Note thatif a `format` or `text` are defined, the format or text take precedenceand the formatter is ignored. `This` refers to a point object.
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to handle the annotation's label that flow outside the plotarea. The justify option aligns the label inside the plot area.
		/// </summary>
		public AnnotationsLabelOptionsOverflow Overflow { get; set; }
		private AnnotationsLabelOptionsOverflow Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// When either the borderWidth or the backgroundColor is set,thisis the padding within the box.
		/// </summary>
		public AnnotationsLabelOptionsPadding Padding { get; set; }
		private AnnotationsLabelOptionsPadding Padding_DefaultValue { get; set; }
		 

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
		public string VerticalAlign { get; set; }
		private string VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to the point.Note that if a `distance` is defined, the distance takesprecedence over `x` and `y` options.
		/// </summary>
		public AnnotationsLabelOptionsX X { get; set; }
		private AnnotationsLabelOptionsX X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the point.Note that if a `distance` is defined, the distance takesprecedence over `x` and `y` options.
		/// </summary>
		public AnnotationsLabelOptionsY Y { get; set; }
		private AnnotationsLabelOptionsY Y_DefaultValue { get; set; }
		 

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

			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow",Overflow);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (Shape != Shape_DefaultValue) h.Add("shape",Shape);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
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