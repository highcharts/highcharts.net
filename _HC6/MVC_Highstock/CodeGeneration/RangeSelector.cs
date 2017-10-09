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
			Floating = Floating_DefaultValue = null;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			Height = Height_DefaultValue = null;
			InputPosition = InputPosition_DefaultValue = new Hashtable();
			ButtonPosition = ButtonPosition_DefaultValue = new RangeSelectorButtonPosition();
			LabelStyle = LabelStyle_DefaultValue = new Hashtable();
			AllButtonsEnabled = AllButtonsEnabled_DefaultValue = false;
			ButtonSpacing = ButtonSpacing_DefaultValue = 0;
			Enabled = Enabled_DefaultValue = true;
			InputBoxBorderColor = InputBoxBorderColor_DefaultValue = "#cccccc";
			InputBoxHeight = InputBoxHeight_DefaultValue = 17;
			InputBoxWidth = InputBoxWidth_DefaultValue = 90;
			InputDateFormat = InputDateFormat_DefaultValue = "%b %e %Y,";
			InputDateParser = InputDateParser_DefaultValue = "";
			InputEditDateFormat = InputEditDateFormat_DefaultValue = "%Y-%m-%d";
			InputEnabled = InputEnabled_DefaultValue = null;
			InputStyle = InputStyle_DefaultValue = new Hashtable();
			Selected = Selected_DefaultValue = null;
			Buttons = Buttons_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The vertical alignment of the rangeselector box. Allowed properties are <code>top</code>,<code>middle</code>, <code>bottom</code>.</p>
		/// </summary>
		public string VerticalAlign { get; set; }
		private string VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A collection of attributes for the buttons. The object takes SVGattributes like <code>fill</code>, <code>stroke</code>, <code>stroke-width</code>, as well as <code>style</code>,a collection of CSS properties for the text.</p><p>The object can also be extended with states, so you can set presentationaloptions for <code>hover</code>, <code>select</code> or <code>disabled</code> button states.</p><p>CSS styles for the text label.</p><p>In styled mode, the buttons are styled by the <code>.highcharts-range-selector-buttons .highcharts-button</code> rule with its differentstates.</p>
		/// </summary>
		public RangeSelectorButtonTheme ButtonTheme { get; set; }
		private RangeSelectorButtonTheme ButtonTheme_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When the rangeselector is floating, the plot area does not reserve space for it. This opens for positioning anywhere on the chart.</p>
		/// </summary>
		public bool? Floating { get; set; }
		private bool? Floating_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The x offset of the range selector relative to its horizontalalignment within <code>chart.spacingLeft</code> and <code>chart.spacingRight</code>.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The y offset of the range selector relative to its horizontalalignment within <code>chart.spacingLeft</code> and <code>chart.spacingRight</code>.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Deprecated. The height of the range selector. Currently it iscalculated dynamically.</p>
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Positioning for the input boxes. Allowed properties are <code>align</code>, <code>x</code> and <code>y</code>.</p>
		/// </summary>
		public Hashtable InputPosition { get; set; }
		private Hashtable InputPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Positioning for the button row.</p>
		/// </summary>
		public RangeSelectorButtonPosition ButtonPosition { get; set; }
		private RangeSelectorButtonPosition ButtonPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS styles for the labels - the Zoom, From and To texts.</p><p>In styled mode, the labels are styled by the <code>.highcharts-range-label</code> class.</p>
		/// </summary>
		public Hashtable LabelStyle { get; set; }
		private Hashtable LabelStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to enable all buttons from the start. By default buttonsare only enabled if the corresponding time range exists on the Xaxis, but enabling all buttons allows for dynamically loading differenttime ranges.</p>
		/// </summary>
		public bool? AllButtonsEnabled { get; set; }
		private bool? AllButtonsEnabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The space in pixels between the buttons in the range selector.</p>
		/// </summary>
		public double? ButtonSpacing { get; set; }
		private double? ButtonSpacing_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable the range selector.</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The border color of the date input boxes.</p>
		/// </summary>
		public string InputBoxBorderColor { get; set; }
		private string InputBoxBorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel height of the date input boxes.</p>
		/// </summary>
		public double? InputBoxHeight { get; set; }
		private double? InputBoxHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel width of the date input boxes.</p>
		/// </summary>
		public double? InputBoxWidth { get; set; }
		private double? InputBoxWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The date format in the input boxes when not selected for editing. Defaults to <code>%b %e, %Y</code>.</p>
		/// </summary>
		public string InputDateFormat { get; set; }
		private string InputDateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A custom callback function to parse values entered in the input boxesand return a valid JavaScript time as milliseconds since 1970.</p>
		/// </summary>
		public string InputDateParser { get; set; }
		private string InputDateParser_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The date format in the input boxes when they are selected for editing.This must be a format that is recognized by JavaScript Date.parse.</p>
		/// </summary>
		public string InputEditDateFormat { get; set; }
		private string InputEditDateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable the date input boxes. Defaults to enabled whenthere is enough space, disabled if not (typically mobile).</p>
		/// </summary>
		public bool? InputEnabled { get; set; }
		private bool? InputEnabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS for the HTML inputs in the range selector.</p><p>In styled mode, the inputs are styled by the <code>.highcharts-range-input text</code> rule in SVG mode, and <code>input.highcharts-range-selector</code>when active.</p>
		/// </summary>
		public Hashtable InputStyle { get; set; }
		private Hashtable InputStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The index of the button to appear pre-selected.</p>
		/// </summary>
		public double? Selected { get; set; }
		private double? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array of configuration objects for the buttons.</p><p>Defaults to</p><pre>buttons: [{    type: 'month',    count: 1,    text: '1m'}, {    type: 'month',    count: 3,    text: '3m'}, {    type: 'month',    count: 6,    text: '6m'}, {    type: 'ytd',    text: 'YTD'}, {    type: 'year',    count: 1,    text: '1y'}, {    type: 'all',    text: 'All'}]</pre>
		/// </summary>
		public List<RangeSelectorButton> Buttons { get; set; }
		private List<RangeSelectorButton> Buttons_DefaultValue { get; set; }
		  

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
			if (InputBoxWidth != InputBoxWidth_DefaultValue) h.Add("inputBoxWidth",InputBoxWidth);
			if (InputDateFormat != InputDateFormat_DefaultValue) h.Add("inputDateFormat",InputDateFormat);
			if (InputDateParser != InputDateParser_DefaultValue) h.Add("inputDateParser",InputDateParser);
			if (InputEditDateFormat != InputEditDateFormat_DefaultValue) h.Add("inputEditDateFormat",InputEditDateFormat);
			if (InputEnabled != InputEnabled_DefaultValue) h.Add("inputEnabled",InputEnabled);
			if (InputStyle != InputStyle_DefaultValue) h.Add("inputStyle",InputStyle);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Buttons != Buttons_DefaultValue)
			{
				List<Hashtable> buttons = new List<Hashtable>();
				foreach (var item in Buttons)
					buttons.Add(item.ToHashtable());

				h.Add("buttons", buttons);
			}
			

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