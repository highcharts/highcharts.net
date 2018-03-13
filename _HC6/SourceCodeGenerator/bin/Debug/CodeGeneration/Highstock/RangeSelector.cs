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
	public partial class RangeSelector  : BaseObject
	{
		public RangeSelector()
		{
			VerticalAlign = VerticalAlign_DefaultValue = "top";
			ButtonTheme = ButtonTheme_DefaultValue = new RangeSelectorButtonTheme();
			Floating = Floating_DefaultValue = false;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = 0;
			Height = Height_DefaultValue = null;
			InputPosition = InputPosition_DefaultValue = new Hashtable();
			ButtonPosition = ButtonPosition_DefaultValue = new RangeSelectorButtonPosition();
			LabelStyle = LabelStyle_DefaultValue = new RangeSelectorLabelStyle();
			AllButtonsEnabled = AllButtonsEnabled_DefaultValue = false;
			ButtonSpacing = ButtonSpacing_DefaultValue = 0;
			Enabled = Enabled_DefaultValue = true;
			InputBoxBorderColor = InputBoxBorderColor_DefaultValue = "#cccccc";
			InputBoxHeight = InputBoxHeight_DefaultValue = 17;
			InputBoxStyle = InputBoxStyle_DefaultValue = "";
			InputBoxWidth = InputBoxWidth_DefaultValue = 90;
			InputDateFormat = InputDateFormat_DefaultValue = "%b %e %Y,";
			InputDateParser = InputDateParser_DefaultValue = "";
			InputEditDateFormat = InputEditDateFormat_DefaultValue = "%Y-%m-%d";
			InputEnabled = InputEnabled_DefaultValue = null;
			InputStyle = InputStyle_DefaultValue = new Hashtable();
			Selected = Selected_DefaultValue = null;
			Buttons = Buttons_DefaultValue = new RangeSelectorButtons();
			
		}	
		

		/// <summary>
		/// The vertical alignment of the rangeselector box. Allowed properties are `top`,`middle`, `bottom`.
		/// </summary>
		public string VerticalAlign { get; set; }
		private string VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of attributes for the buttons. The object takes SVGattributes like `fill`, `stroke`, `stroke-width`, as well as `style`,a collection of CSS properties for the text.The object can also be extended with states, so you can set presentationaloptions for `hover`, `select` or `disabled` button states.CSS styles for the text label.In styled mode, the buttons are styled by the `.highcharts-range-selector-buttons .highcharts-button` rule with its differentstates.
		/// </summary>
		public RangeSelectorButtonTheme ButtonTheme { get; set; }
		private RangeSelectorButtonTheme ButtonTheme_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the rangeselector is floating, the plot area does not reserve space for it. This opens for positioning anywhere on the chart.
		/// </summary>
		public bool? Floating { get; set; }
		private bool? Floating_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x offset of the range selector relative to its horizontalalignment within `chart.spacingLeft` and `chart.spacingRight`.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y offset of the range selector relative to its horizontalalignment within `chart.spacingLeft` and `chart.spacingRight`.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Deprecated. The height of the range selector. Currently it iscalculated dynamically.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// Positioning for the input boxes. Allowed properties are `align`, `x` and `y`.
		/// </summary>
		public Hashtable InputPosition { get; set; }
		private Hashtable InputPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// Positioning for the button row.
		/// </summary>
		public RangeSelectorButtonPosition ButtonPosition { get; set; }
		private RangeSelectorButtonPosition ButtonPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the labels - the Zoom, From and To texts.In styled mode, the labels are styled by the `.highcharts-range-label` class.
		/// </summary>
		public RangeSelectorLabelStyle LabelStyle { get; set; }
		private RangeSelectorLabelStyle LabelStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to enable all buttons from the start. By default buttonsare only enabled if the corresponding time range exists on the Xaxis, but enabling all buttons allows for dynamically loading differenttime ranges.
		/// </summary>
		public bool? AllButtonsEnabled { get; set; }
		private bool? AllButtonsEnabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The space in pixels between the buttons in the range selector.
		/// </summary>
		public double? ButtonSpacing { get; set; }
		private double? ButtonSpacing_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the range selector.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color of the date input boxes.
		/// </summary>
		public string InputBoxBorderColor { get; set; }
		private string InputBoxBorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel height of the date input boxes.
		/// </summary>
		public double? InputBoxHeight { get; set; }
		private double? InputBoxHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS for the container DIV holding the input boxes. Deprecated asof 1.2.5\. Use [inputPosition](#rangeSelector.inputPosition) instead.
		/// </summary>
		public Hashtable InputBoxStyle { get; set; }
		private Hashtable InputBoxStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the date input boxes.
		/// </summary>
		public double? InputBoxWidth { get; set; }
		private double? InputBoxWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The date format in the input boxes when not selected for editing. Defaults to `%b %e, %Y`.
		/// </summary>
		public string InputDateFormat { get; set; }
		private string InputDateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// A custom callback function to parse values entered in the input boxesand return a valid JavaScript time as milliseconds since 1970.
		/// </summary>
		public string InputDateParser { get; set; }
		private string InputDateParser_DefaultValue { get; set; }
		 

		/// <summary>
		/// The date format in the input boxes when they are selected for editing.This must be a format that is recognized by JavaScript Date.parse.
		/// </summary>
		public string InputEditDateFormat { get; set; }
		private string InputEditDateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the date input boxes. Defaults to enabled whenthere is enough space, disabled if not (typically mobile).
		/// </summary>
		public bool? InputEnabled { get; set; }
		private bool? InputEnabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS for the HTML inputs in the range selector.In styled mode, the inputs are styled by the `.highcharts-range-input text` rule in SVG mode, and `input.highcharts-range-selector`when active.
		/// </summary>
		public Hashtable InputStyle { get; set; }
		private Hashtable InputStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The index of the button to appear pre-selected.
		/// </summary>
		public double? Selected { get; set; }
		private double? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of configuration objects for the buttons.Defaults to<pre>buttons: [{    type: 'month',    count: 1,    text: '1m'}, {    type: 'month',    count: 3,    text: '3m'}, {    type: 'month',    count: 6,    text: '6m'}, {    type: 'ytd',    text: 'YTD'}, {    type: 'year',    count: 1,    text: '1y'}, {    type: 'all',    text: 'All'}]</pre>
		/// </summary>
		public List<object> Buttons { get; set; }
		private List<object> Buttons_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (ButtonTheme.IsDirty()) h.Add("buttonTheme",ButtonTheme.ToHashtable());
			if (Floating != Floating_DefaultValue) h.Add("floating",Floating);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (InputPosition != InputPosition_DefaultValue) h.Add("inputPosition",InputPosition);
			if (ButtonPosition.IsDirty()) h.Add("buttonPosition",ButtonPosition.ToHashtable());
			if (LabelStyle != LabelStyle_DefaultValue) h.Add("labelStyle",LabelStyle);
			if (AllButtonsEnabled != AllButtonsEnabled_DefaultValue) h.Add("allButtonsEnabled",AllButtonsEnabled);
			if (ButtonSpacing != ButtonSpacing_DefaultValue) h.Add("buttonSpacing",ButtonSpacing);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (InputBoxBorderColor != InputBoxBorderColor_DefaultValue) h.Add("inputBoxBorderColor",InputBoxBorderColor);
			if (InputBoxHeight != InputBoxHeight_DefaultValue) h.Add("inputBoxHeight",InputBoxHeight);
			if (InputBoxStyle != InputBoxStyle_DefaultValue) h.Add("inputBoxStyle",InputBoxStyle);
			if (InputBoxWidth != InputBoxWidth_DefaultValue) h.Add("inputBoxWidth",InputBoxWidth);
			if (InputDateFormat != InputDateFormat_DefaultValue) h.Add("inputDateFormat",InputDateFormat);
			if (InputDateParser != InputDateParser_DefaultValue) { h.Add("inputDateParser",InputDateParser); Highstock.AddFunction("RangeSelectorInputDateParser.inputDateParser", InputDateParser); }  
			if (InputEditDateFormat != InputEditDateFormat_DefaultValue) h.Add("inputEditDateFormat",InputEditDateFormat);
			if (InputEnabled != InputEnabled_DefaultValue) h.Add("inputEnabled",InputEnabled);
			if (InputStyle != InputStyle_DefaultValue) h.Add("inputStyle",InputStyle);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Buttons.IsDirty()) h.Add("buttons",Buttons.ToHashtable());
			

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