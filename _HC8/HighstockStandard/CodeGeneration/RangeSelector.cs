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
	public partial class RangeSelector  : BaseObject
	{
		Hashtable h = new Hashtable();

		public RangeSelector()
		{
			AllButtonsEnabled = AllButtonsEnabled_DefaultValue = false;
			ButtonPosition = ButtonPosition_DefaultValue = new RangeSelectorButtonPosition();
			Buttons = Buttons_DefaultValue = new List<RangeSelectorButton>();
			ButtonSpacing = ButtonSpacing_DefaultValue = 5;
			ButtonTheme = ButtonTheme_DefaultValue = null;
			Dropdown = Dropdown_DefaultValue = RangeSelectorDropdown.Responsive;
			Enabled = Enabled_DefaultValue = null;
			Floating = Floating_DefaultValue = false;
			Height = Height_DefaultValue = null;
			InputBoxBorderColor = InputBoxBorderColor_DefaultValue = "none";
			InputBoxHeight = InputBoxHeight_DefaultValue = 17;
			InputBoxWidth = InputBoxWidth_DefaultValue = null;
			InputDateFormat = InputDateFormat_DefaultValue = "%b %e, %Y";
			InputDateParser = InputDateParser_DefaultValue = "";
			InputEditDateFormat = InputEditDateFormat_DefaultValue = "%Y-%m-%d";
			InputEnabled = InputEnabled_DefaultValue = true;
			InputPosition = InputPosition_DefaultValue = new Hashtable();
			InputSpacing = InputSpacing_DefaultValue = 5;
			InputStyle = InputStyle_DefaultValue = new Hashtable();
			LabelStyle = LabelStyle_DefaultValue = new Hashtable();
			Selected = Selected_DefaultValue = null;
			VerticalAlign = VerticalAlign_DefaultValue = RangeSelectorVerticalAlign.Top;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// Whether to enable all buttons from the start. By default buttons areonly enabled if the corresponding time range exists on the X axis,but enabling all buttons allows for dynamically loading differenttime ranges.
		/// </summary>
		public bool? AllButtonsEnabled { get; set; }
		private bool? AllButtonsEnabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Positioning for the button row.
		/// </summary>
		public RangeSelectorButtonPosition ButtonPosition { get; set; }
		private RangeSelectorButtonPosition ButtonPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of configuration objects for the buttons.Defaults to:```jsbuttons: [{    type: 'month',    count: 1,    text: '1m',    title: 'View 1 month'}, {    type: 'month',    count: 3,    text: '3m',    title: 'View 3 months'}, {    type: 'month',    count: 6,    text: '6m',    title: 'View 6 months'}, {    type: 'ytd',    text: 'YTD',    title: 'View year to date'}, {    type: 'year',    count: 1,    text: '1y',    title: 'View 1 year'}, {    type: 'all',    text: 'All',    title: 'View all'}]```
		/// </summary>
		public List<RangeSelectorButton> Buttons { get; set; }
		private List<RangeSelectorButton> Buttons_DefaultValue { get; set; }
		 

		/// <summary>
		/// The space in pixels between the buttons in the range selector.
		/// </summary>
		public double? ButtonSpacing { get; set; }
		private double? ButtonSpacing_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of attributes for the buttons. The object takes SVGattributes like `fill`, `stroke`, `stroke-width`, as well as `style`,a collection of CSS properties for the text.The object can also be extended with states, so you can setpresentational options for `hover`, `select` or `disabled` buttonstates.CSS styles for the text label.In styled mode, the buttons are styled by the`.highcharts-range-selector-buttons .highcharts-button` rule with itsdifferent states.
		/// </summary>
		public Object ButtonTheme { get; set; }
		private Object ButtonTheme_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to collapse the range selector buttons into a dropdown whenthere is not enough room to show everything in a single row, insteadof dividing the range selector into multiple rows.Can be one of the following: - `always`: Always collapse - `responsive`: Only collapse when there is not enough room - `never`: Never collapse
		/// </summary>
		public RangeSelectorDropdown Dropdown { get; set; }
		private RangeSelectorDropdown Dropdown_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the range selector. Default to `true` for stockcharts, using the `stockChart` factory.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the rangeselector is floating, the plot area does not reservespace for it. This opens for positioning anywhere on the chart.
		/// </summary>
		public bool? Floating { get; set; }
		private bool? Floating_DefaultValue { get; set; }
		 

		/// <summary>
		/// Deprecated. The height of the range selector. Currently it iscalculated dynamically.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

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
		/// The pixel width of the date input boxes. When `undefined`, the widthis fitted to the rendered content.
		/// </summary>
		public double? InputBoxWidth { get; set; }
		private double? InputBoxWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The date format in the input boxes when not selected for editing.Defaults to `%b %e, %Y`.This is used to determine which type of input to show,`datetime-local`, `date` or `time` and falling back to `text` whenthe browser does not support the input type or the format containsmilliseconds.
		/// </summary>
		public string InputDateFormat { get; set; }
		private string InputDateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// A custom callback function to parse values entered in the input boxesand return a valid JavaScript time as milliseconds since 1970.The first argument passed is a value to parse,second is a boolean indicating use of the UTC time.This will only get called for inputs of type `text`. Since v8.2.3,the input type is dynamically determined based on the granularityof the `inputDateFormat` and the browser support.
		/// </summary>
		public string InputDateParser { get; set; }
		private string InputDateParser_DefaultValue { get; set; }
		 

		/// <summary>
		/// The date format in the input boxes when they are selected forediting. This must be a format that is recognized by JavaScriptDate.parse.This will only be used for inputs of type `text`. Since v8.2.3,the input type is dynamically determined based on the granularityof the `inputDateFormat` and the browser support.
		/// </summary>
		public string InputEditDateFormat { get; set; }
		private string InputEditDateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the date input boxes.
		/// </summary>
		public bool? InputEnabled { get; set; }
		private bool? InputEnabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Positioning for the input boxes. Allowed properties are `align`, `x` and `y`.
		/// </summary>
		public Hashtable InputPosition { get; set; }
		private Hashtable InputPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// The space in pixels between the labels and the date input boxes inthe range selector.
		/// </summary>
		public double? InputSpacing { get; set; }
		private double? InputSpacing_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS for the HTML inputs in the range selector.In styled mode, the inputs are styled by the`.highcharts-range-input text` rule in SVG mode, and`input.highcharts-range-selector` when active.
		/// </summary>
		public Hashtable InputStyle { get; set; }
		private Hashtable InputStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the labels - the Zoom, From and To texts.In styled mode, the labels are styled by the`.highcharts-range-label` class.
		/// </summary>
		public Hashtable LabelStyle { get; set; }
		private Hashtable LabelStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The index of the button to appear pre-selected.
		/// </summary>
		public double? Selected { get; set; }
		private double? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the rangeselector box. Allowed propertiesare `top`, `middle`, `bottom`.
		/// </summary>
		public RangeSelectorVerticalAlign VerticalAlign { get; set; }
		private RangeSelectorVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (AllButtonsEnabled != AllButtonsEnabled_DefaultValue) h.Add("allButtonsEnabled",AllButtonsEnabled);
			if (ButtonPosition.IsDirty(ref highstock)) h.Add("buttonPosition",ButtonPosition.ToHashtable(ref highstock));
			if (Buttons != Buttons_DefaultValue) h.Add("buttons", HashifyList(ref highstock,Buttons));
			if (ButtonSpacing != ButtonSpacing_DefaultValue) h.Add("buttonSpacing",ButtonSpacing);
			if (ButtonTheme != ButtonTheme_DefaultValue) h.Add("buttonTheme",ButtonTheme);
			if (Dropdown != Dropdown_DefaultValue) h.Add("dropdown", Highstock.FirstCharacterToLower(Dropdown.ToString()));
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Floating != Floating_DefaultValue) h.Add("floating",Floating);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (InputBoxBorderColor != InputBoxBorderColor_DefaultValue) h.Add("inputBoxBorderColor",InputBoxBorderColor);
			if (InputBoxHeight != InputBoxHeight_DefaultValue) h.Add("inputBoxHeight",InputBoxHeight);
			if (InputBoxWidth != InputBoxWidth_DefaultValue) h.Add("inputBoxWidth",InputBoxWidth);
			if (InputDateFormat != InputDateFormat_DefaultValue) h.Add("inputDateFormat",InputDateFormat);
			if (InputDateParser != InputDateParser_DefaultValue) { h.Add("inputDateParser",InputDateParser); Highstock.AddFunction("inputDateParser", InputDateParser); }  
			if (InputEditDateFormat != InputEditDateFormat_DefaultValue) h.Add("inputEditDateFormat",InputEditDateFormat);
			if (InputEnabled != InputEnabled_DefaultValue) h.Add("inputEnabled",InputEnabled);
			if (InputPosition != InputPosition_DefaultValue) h.Add("inputPosition",InputPosition);
			if (InputSpacing != InputSpacing_DefaultValue) h.Add("inputSpacing",InputSpacing);
			if (InputStyle != InputStyle_DefaultValue) h.Add("inputStyle",InputStyle);
			if (LabelStyle != LabelStyle_DefaultValue) h.Add("labelStyle",LabelStyle);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highstock.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}