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
	public partial class YAxisStackLabels  : BaseObject
	{
		public YAxisStackLabels()
		{
			Align = Align_DefaultValue = YAxisStackLabelsAlign.Null;
			AllowOverlap = AllowOverlap_DefaultValue = false;
			Crop = Crop_DefaultValue = true;
			Enabled = Enabled_DefaultValue = false;
			Format = Format_DefaultValue = "{total}";
			Formatter = Formatter_DefaultValue = "";
			Overflow = Overflow_DefaultValue = YAxisLabelsOverflow.Justify;
			Rotation = Rotation_DefaultValue = 0;
			Style = Style_DefaultValue = new YAxisStackLabelsStyle();
			TextAlign = TextAlign_DefaultValue = "";
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = YAxisStackLabelsVerticalAlign.Null;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Defines the horizontal alignment of the stack total label. Can be oneof `"left"`, `"center"` or `"right"`. The default value is calculatedat runtime and depends on orientation and whether the stack ispositive or negative.
		/// </summary>
		public YAxisStackLabelsAlign Align { get; set; }
		private YAxisStackLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow the stack labels to overlap.
		/// </summary>
		public bool? AllowOverlap { get; set; }
		private bool? AllowOverlap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to hide stack labels that are outside the plot area.By default, the stack label is movedinside the plot area according to the[overflow](/highcharts/#yAxis/stackLabels/overflow)option.
		/// </summary>
		public bool? Crop { get; set; }
		private bool? Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the stack total labels.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// A [format string](http://docs.highcharts.com/#formatting) for thedata label. Available variables are the same as for `formatter`.
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to format the label. The value isgiven by `this.total`.
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to handle stack total labels that flow outside the plot area.The default is set to `"justify"`,which aligns them inside the plot area.For columns and bars, this means it will be moved inside the bar.To display stack labels outside the plot area,set `crop` to `false` and `overflow` to `"allow"`.
		/// </summary>
		public YAxisLabelsOverflow Overflow { get; set; }
		private YAxisLabelsOverflow Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Rotation of the labels in degrees.
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the label.In styled mode, the styles are set in the`.highcharts-stack-label` class.
		/// </summary>
		public YAxisStackLabelsStyle Style { get; set; }
		private YAxisStackLabelsStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text alignment for the label. While `align` determines where thetexts anchor point is placed with regards to the stack, `textAlign`determines how the text is aligned against its anchor point. Possiblevalues are `"left"`, `"center"` and `"right"`. The default value iscalculated at runtime and depends on orientation and whether thestack is positive or negative.
		/// </summary>
		public string TextAlign { get; set; }
		private string TextAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the labels.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the vertical alignment of the stack total label. Can be oneof `"top"`, `"middle"` or `"bottom"`. The default value is calculatedat runtime and depends on orientation and whether the stack ispositive or negative.
		/// </summary>
		public YAxisStackLabelsVerticalAlign VerticalAlign { get; set; }
		private YAxisStackLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to the left of thestacked bar. The default value is calculated at runtime and dependson orientation and whether the stack is positive or negative.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the tick positionon the axis. The default value is calculated at runtime and dependson orientation and whether the stack is positive or negative.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highcharts.AddFunction("7497b781-82fb-45a9-b8e6-6083bd8881a3.formatter", Formatter); }  
			if (Overflow != Overflow_DefaultValue) h.Add("overflow",Overflow);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (TextAlign != TextAlign_DefaultValue) h.Add("textAlign",TextAlign);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
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