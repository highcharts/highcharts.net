using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class AnnotationsLabelOptions  : BaseObject
	{
		public AnnotationsLabelOptions()
		{
			Align = Align_DefaultValue = AnnotationsLabelOptionsAlign.Center;
			AllowOverlap = AllowOverlap_DefaultValue = null;
			BackgroundColor = BackgroundColor_DefaultValue = "rgba(0, 0, 0, 0.75)";
			BorderColor = BorderColor_DefaultValue = "black";
			BorderRadius = BorderRadius_DefaultValue = null;
			BorderWidth = BorderWidth_DefaultValue = null;
			Crop = Crop_DefaultValue = null;
			Formatter = Formatter_DefaultValue = "";
			Overflow = Overflow_DefaultValue = AnnotationsLabelOptionsOverflow.Justify;
			Padding = Padding_DefaultValue = null;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			Shape = Shape_DefaultValue = "callout";
			Style = Style_DefaultValue = new AnnotationsLabelOptionsStyle();
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = AnnotationsLabelOptionsVerticalAlign.Bottom;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			Format = Format_DefaultValue = "undefined";
			Text = Text_DefaultValue = "undefined";
			Distance = Distance_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The alignment of the annotation&#39;s label. If right,the right side of the label should be touching the point.</p>
		/// </summary>
		public AnnotationsLabelOptionsAlign Align { get; set; }
		private AnnotationsLabelOptionsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to allow the annotation&#39;s labels to overlap.To make the labels less sensitive for overlapping, the can be set to 0.</p>
		/// </summary>
		public bool? AllowOverlap { get; set; }
		private bool? AllowOverlap_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The background color or gradient for the annotation&#39;s label.</p>
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The border color for the annotation&#39;s label.</p>
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The border radius in pixels for the annotaiton&#39;s label.</p>
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The border width in pixels for the annotation&#39;s label</p>
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to hide the annotation&#39;s label that is outside the plot area.</p>
		/// </summary>
		public bool? Crop { get; set; }
		private bool? Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Callback JavaScript function to format the annotation&#39;s label. Note thatif a <code>format</code> or <code>text</code> are defined, the format or text take precedenceand the formatter is ignored. <code>This</code> refers to a point object.</p>
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>How to handle the annotation&#39;s label that flow outside the plotarea. The justify option aligns the label inside the plot area.</p>
		/// </summary>
		public AnnotationsLabelOptionsOverflow Overflow { get; set; }
		private AnnotationsLabelOptionsOverflow Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When either the borderWidth or the backgroundColor is set,this    is the padding within the box.</p>
		/// </summary>
		public double? Padding { get; set; }
		private double? Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The shadow of the box. The shadow can be an object configurationcontaining <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.</p>
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The name of a symbol to use for the border around the label.Symbols are predefined functions on the Renderer object.</p>
		/// </summary>
		public string Shape { get; set; }
		private string Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Styles for the annotation&#39;s label.</p>
		/// </summary>
		public AnnotationsLabelOptionsStyle Style { get; set; }
		private AnnotationsLabelOptionsStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html">use HTML</a> to render the annotation&#39;s label.</p>
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The vertical alignment of the annotation&#39;s label.</p>
		/// </summary>
		public AnnotationsLabelOptionsVerticalAlign VerticalAlign { get; set; }
		private AnnotationsLabelOptionsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The x position offset of the label relative to the point.Note that if a <code>distance</code> is defined, the distance takesprecedence over <code>x</code> and <code>y</code> options.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The y position offset of the label relative to the point.Note that if a <code>distance</code> is defined, the distance takesprecedence over <code>x</code> and <code>y</code> options.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <a href="https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting">format</a> string for the data label.</p>
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Alias for the format option.</p>
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The label&#39;s pixel distance from the point.</p>
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highstock.AddFunction("AnnotationsLabelOptionsFormatter.formatter", Formatter); }  
			if (Overflow != Overflow_DefaultValue) h.Add("overflow", Highstock.FirstCharacterToLower(Overflow.ToString()));
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Shadow.IsDirty()) h.Add("shadow",Shadow.ToHashtable());
			if (Shape != Shape_DefaultValue) h.Add("shape",Shape);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highstock.FirstCharacterToLower(VerticalAlign.ToString()));
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