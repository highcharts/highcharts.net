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
			AllButtonsEnabled = AllButtonsEnabled_DefaultValue = false;
			ButtonSpacing = ButtonSpacing_DefaultValue = 0;
			ButtonTheme = ButtonTheme_DefaultValue = "";
			Buttons = Buttons_DefaultValue = null;
			Enabled = Enabled_DefaultValue = true;
			InputBoxBorderColor = InputBoxBorderColor_DefaultValue = "silver";
			InputBoxHeight = InputBoxHeight_DefaultValue = 17;
			InputBoxWidth = InputBoxWidth_DefaultValue = 90;
			InputDateFormat = InputDateFormat_DefaultValue = "%b %e %Y,";
			InputDateParser = InputDateParser_DefaultValue = "";
			InputEditDateFormat = InputEditDateFormat_DefaultValue = "%Y-%m-%d";
			InputEnabled = InputEnabled_DefaultValue = null;
			InputPosition = InputPosition_DefaultValue = new Hashtable{{ "align" , "right" }};
			InputStyle = InputStyle_DefaultValue = new Hashtable();
			LabelStyle = LabelStyle_DefaultValue = new Hashtable();
			Selected = Selected_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Whether to enable all buttons from the start. By default buttons are only enabled if the corresponding time range exists on the X axis, but enabling all buttons allows for dynamically loading different time ranges.
		/// </summary>
		public bool? AllButtonsEnabled { get; set; }
		private bool? AllButtonsEnabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The space in pixels between the buttons in the range selector.
		/// </summary>
		public double? ButtonSpacing { get; set; }
		private double? ButtonSpacing_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of attributes for the buttons. The object takes SVG attributes like <code>fill</code>, <code>stroke</code>, <code>stroke-width</code>, as well as <code>style</code>, a collection of CSS properties for the text.
		/// </summary>
		public Object ButtonTheme { get; set; }
		private Object ButtonTheme_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of configuration objects for the buttons. The individual options for each item are:  <dl> <dt><code>type</code></dt> <dd>Defines the timespan, can be one of 'millisecond', 'second', 'minute', 'day', 'week',  'month', 'ytd' (year to date), 'year' and 'all'.</dd> <dt><code>count</code></dt> <dd>Defines how many units of the defined type to use.</dd> <dt><code>dataGrouping</code></dt> <dd>A custom data grouping definition for the button.</dd> <dt><code>text</code></dt> <dd>The text for the button itself</dd> </dl>Defaults to <pre>buttons: [{type: 'month',count: 1,text: '1m'}, {type: 'month',count: 3,text: '3m'}, {type: 'month',count: 6,text: '6m'}, {type: 'ytd',text: 'YTD'}, {type: 'year',count: 1,text: '1y'}, {type: 'all',text: 'All'}]</pre>
		/// </summary>
		public List<object> Buttons { get; set; }
		private List<object> Buttons_DefaultValue { get; set; }
		 

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
		/// The pixel width of the date input boxes. 
		/// </summary>
		public double? InputBoxWidth { get; set; }
		private double? InputBoxWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The date format in the input boxes when not selected for editing. Defaults to <code>%b %e, %Y</code>.
		/// </summary>
		public string InputDateFormat { get; set; }
		private string InputDateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// A custom callback function to parse values entered in the input boxes and return a valid JavaScript time as milliseconds since 1970.
		/// </summary>
		public string InputDateParser { get; set; }
		private string InputDateParser_DefaultValue { get; set; }
		 

		/// <summary>
		/// The date format in the input boxes when they are selected for editing. This must be a format that is recognized by JavaScript Date.parse.
		/// </summary>
		public string InputEditDateFormat { get; set; }
		private string InputEditDateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the date input boxes. Defaults to enabled when there is enough space, disabled if not (typically mobile).
		/// </summary>
		public bool? InputEnabled { get; set; }
		private bool? InputEnabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Positioning for the input boxes. Allowed properties are <code>align</code>, <code>verticalAlign</code>, <code>x</code> and <code>y</code>.
		/// </summary>
		public Hashtable InputPosition { get; set; }
		private Hashtable InputPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS for the HTML inputs in the range selector.
		/// </summary>
		public Hashtable InputStyle { get; set; }
		private Hashtable InputStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the labels - the Zoom, From and To texts.
		/// </summary>
		public Hashtable LabelStyle { get; set; }
		private Hashtable LabelStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The index of the button to appear pre-selected.
		/// </summary>
		public double? Selected { get; set; }
		private double? Selected_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AllButtonsEnabled != AllButtonsEnabled_DefaultValue) h.Add("allButtonsEnabled",AllButtonsEnabled);
			if (ButtonSpacing != ButtonSpacing_DefaultValue) h.Add("buttonSpacing",ButtonSpacing);
			if (ButtonTheme != ButtonTheme_DefaultValue) h.Add("buttonTheme",ButtonTheme);
            if (Buttons != Buttons_DefaultValue) h.Add("buttons",Buttons);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (InputBoxBorderColor != InputBoxBorderColor_DefaultValue) h.Add("inputBoxBorderColor",InputBoxBorderColor);
			if (InputBoxHeight != InputBoxHeight_DefaultValue) h.Add("inputBoxHeight",InputBoxHeight);
			if (InputBoxWidth != InputBoxWidth_DefaultValue) h.Add("inputBoxWidth",InputBoxWidth);
			if (InputDateFormat != InputDateFormat_DefaultValue) h.Add("inputDateFormat",InputDateFormat);
			if (InputDateParser != InputDateParser_DefaultValue) { h.Add("inputDateParser",InputDateParser); Highstock.AddFunction("RangeSelectorInputDateParser.inputDateParser", InputDateParser); }  
			if (InputEditDateFormat != InputEditDateFormat_DefaultValue) h.Add("inputEditDateFormat",InputEditDateFormat);
			if (InputEnabled != InputEnabled_DefaultValue) h.Add("inputEnabled",InputEnabled);
			if (InputPosition != InputPosition_DefaultValue) h.Add("inputPosition",InputPosition);
			if (InputStyle != InputStyle_DefaultValue) h.Add("inputStyle",InputStyle);
			if (LabelStyle != LabelStyle_DefaultValue) h.Add("labelStyle",LabelStyle);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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