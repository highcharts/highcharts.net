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
		}	
		

		/// <summary>
		/// Whether to enable all buttons from the start. By default buttons areonly enabled if the corresponding time range exists on the X axis,but enabling all buttons allows for dynamically loading differenttime ranges.
		/// </summary>
		public bool? AllButtonsEnabled { get; set; }
		 

		/// <summary>
		/// Positioning for the button row.
		/// </summary>
		public RangeSelectorButtonPosition ButtonPosition { get; set; }
		 

		/// <summary>
		/// An array of configuration objects for the buttons.Defaults to:```jsbuttons: [{    type: 'month',    count: 1,    text: '1m',    title: 'View 1 month'}, {    type: 'month',    count: 3,    text: '3m',    title: 'View 3 months'}, {    type: 'month',    count: 6,    text: '6m',    title: 'View 6 months'}, {    type: 'ytd',    text: 'YTD',    title: 'View year to date'}, {    type: 'year',    count: 1,    text: '1y',    title: 'View 1 year'}, {    type: 'all',    text: 'All',    title: 'View all'}]```
		/// </summary>
		public List<RangeSelectorButton> Buttons { get; set; }
		 

		/// <summary>
		/// The space in pixels between the buttons in the range selector.
		/// </summary>
		public double? ButtonSpacing { get; set; }
		 

		/// <summary>
		/// A collection of attributes for the buttons. The object takes SVGattributes like `fill`, `stroke`, `stroke-width`, as well as `style`,a collection of CSS properties for the text.The object can also be extended with states, so you can setpresentational options for `hover`, `select` or `disabled` buttonstates.CSS styles for the text label.In styled mode, the buttons are styled by the`.highcharts-range-selector-buttons .highcharts-button` rule with itsdifferent states.
		/// </summary>
		public Object ButtonTheme { get; set; }
		 

		/// <summary>
		/// Whether to collapse the range selector buttons into a dropdown whenthere is not enough room to show everything in a single row, insteadof dividing the range selector into multiple rows.Can be one of the following: - `always`: Always collapse - `responsive`: Only collapse when there is not enough room - `never`: Never collapse
		/// </summary>
		public RangeSelectorDropdown Dropdown { get; set; }
		 

		/// <summary>
		/// Enable or disable the range selector. Default to `true` for stockcharts, using the `stockChart` factory.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// When the rangeselector is floating, the plot area does not reservespace for it. This opens for positioning anywhere on the chart.
		/// </summary>
		public bool? Floating { get; set; }
		 

		/// <summary>
		/// Deprecated. The height of the range selector. Currently it iscalculated dynamically.
		/// </summary>
		public double? Height { get; set; }
		 

		/// <summary>
		/// The border color of the date input boxes.
		/// </summary>
		public string InputBoxBorderColor { get; set; }
		 

		/// <summary>
		/// The pixel height of the date input boxes.
		/// </summary>
		public double? InputBoxHeight { get; set; }
		 

		/// <summary>
		/// The pixel width of the date input boxes. When `undefined`, the widthis fitted to the rendered content.
		/// </summary>
		public double? InputBoxWidth { get; set; }
		 

		/// <summary>
		/// The date format in the input boxes when not selected for editing.Defaults to `%e %b %Y`.This is used to determine which type of input to show,`datetime-local`, `date` or `time` and falling back to `text` whenthe browser does not support the input type or the format containsmilliseconds.
		/// </summary>
		public string InputDateFormat { get; set; }
		 

		/// <summary>
		/// A custom callback function to parse values entered in the input boxesand return a valid JavaScript time as milliseconds since 1970.The first argument passed is a value to parse,second is a boolean indicating use of the UTC time.This will only get called for inputs of type `text`. Since v8.2.3,the input type is dynamically determined based on the granularityof the `inputDateFormat` and the browser support.
		/// </summary>
		public string InputDateParser { get; set; }
		 

		/// <summary>
		/// The date format in the input boxes when they are selected forediting. This must be a format that is recognized by JavaScriptDate.parse.This will only be used for inputs of type `text`. Since v8.2.3,the input type is dynamically determined based on the granularityof the `inputDateFormat` and the browser support.
		/// </summary>
		public string InputEditDateFormat { get; set; }
		 

		/// <summary>
		/// Enable or disable the date input boxes.
		/// </summary>
		public bool? InputEnabled { get; set; }
		 

		/// <summary>
		/// Positioning for the input boxes. Allowed properties are `align`, `x` and `y`.
		/// </summary>
		public Hashtable InputPosition { get; set; }
		 

		/// <summary>
		/// The space in pixels between the labels and the date input boxes inthe range selector.
		/// </summary>
		public double? InputSpacing { get; set; }
		 

		/// <summary>
		/// CSS for the HTML inputs in the range selector.In styled mode, the inputs are styled by the`.highcharts-range-input text` rule in SVG mode, and`input.highcharts-range-selector` when active.
		/// </summary>
		public Hashtable InputStyle { get; set; }
		 

		/// <summary>
		/// CSS styles for the labels - the Zoom, From and To texts.In styled mode, the labels are styled by the`.highcharts-range-label` class.
		/// </summary>
		public Hashtable LabelStyle { get; set; }
		 

		/// <summary>
		/// The index of the button to appear pre-selected. If the selected rangeexceeds the total data range and the 'all' option is available,the 'all' option, showing the full range, is automatically selected.
		/// </summary>
		public double? Selected { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the rangeselector box. Allowed propertiesare `top`, `middle`, `bottom`.
		/// </summary>
		public RangeSelectorVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// The x offset of the range selector relative to its horizontalalignment within `chart.spacingLeft` and `chart.spacingRight`.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// The y offset of the range selector relative to its horizontalalignment within `chart.spacingLeft` and `chart.spacingRight`.
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (AllButtonsEnabled != null) h.Add("allButtonsEnabled",AllButtonsEnabled);
			if (ButtonPosition != null) h.Add("buttonPosition",ButtonPosition.ToHashtable(highstock));
			if (Buttons != null) h.Add("buttons", HashifyList(highstock,Buttons));
			if (ButtonSpacing != null) h.Add("buttonSpacing",ButtonSpacing);
			if (ButtonTheme != null) h.Add("buttonTheme",ButtonTheme);
			if (Dropdown != RangeSelectorDropdown.Null) h.Add("dropdown", highstock.FirstCharacterToLower(Dropdown.ToString()));
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Floating != null) h.Add("floating",Floating);
			if (Height != null) h.Add("height",Height);
			if (InputBoxBorderColor != null) h.Add("inputBoxBorderColor",InputBoxBorderColor);
			if (InputBoxHeight != null) h.Add("inputBoxHeight",InputBoxHeight);
			if (InputBoxWidth != null) h.Add("inputBoxWidth",InputBoxWidth);
			if (InputDateFormat != null) h.Add("inputDateFormat",InputDateFormat);
			if (InputDateParser != null) { h.Add("inputDateParser",InputDateParser); highstock.AddFunction("inputDateParser", InputDateParser); }  
			if (InputEditDateFormat != null) h.Add("inputEditDateFormat",InputEditDateFormat);
			if (InputEnabled != null) h.Add("inputEnabled",InputEnabled);
			if (InputPosition != null) h.Add("inputPosition",InputPosition);
			if (InputSpacing != null) h.Add("inputSpacing",InputSpacing);
			if (InputStyle != null) h.Add("inputStyle",InputStyle);
			if (LabelStyle != null) h.Add("labelStyle",LabelStyle);
			if (Selected != null) h.Add("selected",Selected);
			if (VerticalAlign != RangeSelectorVerticalAlign.Null) h.Add("verticalAlign", highstock.FirstCharacterToLower(VerticalAlign.ToString()));
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