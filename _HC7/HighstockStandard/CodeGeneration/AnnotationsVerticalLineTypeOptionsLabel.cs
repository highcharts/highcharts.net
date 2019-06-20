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
	public partial class AnnotationsVerticalLineTypeOptionsLabel  : BaseObject
	{
		public AnnotationsVerticalLineTypeOptionsLabel()
		{
			Align = Align_DefaultValue = AnnotationsVerticalLineTypeOptionsLabelAlign.Center;
			AllowOverlap = AllowOverlap_DefaultValue = true;
			BackgroundColor = BackgroundColor_DefaultValue = "none";
			BorderColor = BorderColor_DefaultValue = "black";
			BorderRadius = BorderRadius_DefaultValue = 3;
			BorderWidth = BorderWidth_DefaultValue = 0;
			ClassName = ClassName_DefaultValue = "";
			Crop = Crop_DefaultValue = true;
			Distance = Distance_DefaultValue = null;
			Format = Format_DefaultValue = "undefined";
			Formatter = Formatter_DefaultValue = "";
			Offset = Offset_DefaultValue = -40;
			Overflow = Overflow_DefaultValue = "none";
			Padding = Padding_DefaultValue = "5";
			Point = Point_DefaultValue = "";
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShadowBool = ShadowBool_DefaultValue = null;
			Shape = Shape_DefaultValue = "rect";
			Style = Style_DefaultValue = new AnnotationsVerticalLineTypeOptionsLabelStyle();
			Text = Text_DefaultValue = "{y:.2f}";
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = AnnotationsVerticalLineTypeOptionsLabelVerticalAlign.Bottom;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = -16;
			
		}	
		

		/// <summary>
		/// The alignment of the annotation's label. If right,the right side of the label should be touching the point.
		/// </summary>
		public AnnotationsVerticalLineTypeOptionsLabelAlign Align { get; set; }
		private AnnotationsVerticalLineTypeOptionsLabelAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? AllowOverlap { get; set; }
		private bool? AllowOverlap_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// A class name for styling by CSS.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Crop { get; set; }
		private bool? Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// The label's pixel distance from the point.
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// A [format](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting) string for the data label.
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to formatthe annotation's label. Note that if a `format` or `text`are defined, the format or text take precedence andthe formatter is ignored. `This` refers to a * point object.
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Offset { get; set; }
		private double? Offset_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Overflow { get; set; }
		private string Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// When either the borderWidth or the backgroundColor is set,this is the padding within the box.
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  Point { get; set; }
		private  Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow of the box. The shadow can bean object configuration containing`color`, `offsetX`, `offsetY`, `opacity` and `width`.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow of the box. The shadow can bean object configuration containing`color`, `offsetX`, `offsetY`, `opacity` and `width`.
		/// </summary>
		public bool? ShadowBool { get; set; }
		private bool? ShadowBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Shape { get; set; }
		private string Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styles for the annotation's label.
		/// </summary>
		public AnnotationsVerticalLineTypeOptionsLabelStyle Style { get; set; }
		private AnnotationsVerticalLineTypeOptionsLabelStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the annotation's label.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the annotation's label.
		/// </summary>
		public AnnotationsVerticalLineTypeOptionsLabelVerticalAlign VerticalAlign { get; set; }
		private AnnotationsVerticalLineTypeOptionsLabelVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highstock.AddFunction("AnnotationsVerticalLineTypeOptionsLabelFormatter.formatter", Formatter); }  
			if (Offset != Offset_DefaultValue) h.Add("offset",Offset);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow",Overflow);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Point != Point_DefaultValue) h.Add("point",Point);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShadowBool != ShadowBool_DefaultValue) h.Add("shadow",ShadowBool);
			if (Shape != Shape_DefaultValue) h.Add("shape",Shape);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highstock.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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