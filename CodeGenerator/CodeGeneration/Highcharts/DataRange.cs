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
	public partial class DataRange  : BaseObject
	{
		public DataRange()
		{
			Show = Show_DefaultValue = null;
			Zlevel = Zlevel_DefaultValue = null;
			Z = Z_DefaultValue = null;
			Orient = Orient_DefaultValue = vertical;
			X = X_DefaultValue = left;
			Y = Y_DefaultValue = bottom;
			BackgroundColor = BackgroundColor_DefaultValue = rgba(0,0,0,0);
			BorderColor = BorderColor_DefaultValue = #ccc;
			BorderWidth = BorderWidth_DefaultValue = null;
			Padding = Padding_DefaultValue = null;
			ItemGap = ItemGap_DefaultValue = null;
			ItemWidth = ItemWidth_DefaultValue = null;
			ItemHeight = ItemHeight_DefaultValue = null;
			Min = Min_DefaultValue = null;
			Max = Max_DefaultValue = null;
			Precision = Precision_DefaultValue = null;
			SplitNumber = SplitNumber_DefaultValue = null;
			SplitList = SplitList_DefaultValue = null;
			Range = Range_DefaultValue = null;
			SelectedMode = SelectedMode_DefaultValue = null;
			Calculable = Calculable_DefaultValue = null;
			HoverLink = HoverLink_DefaultValue = null;
			Realtime = Realtime_DefaultValue = null;
			Color = Color_DefaultValue = null;
			Formatter = Formatter_DefaultValue = null;
			Text = Text_DefaultValue = null;
			TextStyle = TextStyle_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Specifies whether to show. Valid values are: true (show) | false (hide).
		/// </summary>
		public boolean Show { get; set; }
		private boolean Show_DefaultValue { get; set; }
		 

		/// <summary>
		/// The first grade cascading control. Every zlevel will be allocated to a independent canvas, charts and components with the same zlevel will be rendered in the same canvas. The higher zlevel the closer to the top. More canvas dom will need more memory and performance, so never set too many zlevel. Most of the time, the second grade cascading control 'z' is recommended.
		/// </summary>
		public number Zlevel { get; set; }
		private number Zlevel_DefaultValue { get; set; }
		 

		/// <summary>
		/// The second grade cascading control, In the same canvas (zlevel), the higher z the closer to the top.
		/// </summary>
		public number Z { get; set; }
		private number Z_DefaultValue { get; set; }
		 

		/// <summary>
		/// layout manner. Defaults to vertical. Valid values are: 'horizontal' | 'vertical'
		/// </summary>
		public string Orient { get; set; }
		private string Orient_DefaultValue { get; set; }
		 

		/// <summary>
		/// horizontal position. Defaults to left. Valid values are: 'center' | 'left' | 'right' | <b>{number}</b>}(x-coordinate, in px).
		/// </summary>
		public string X { get; set; }
		private string X_DefaultValue { get; set; }
		 

		/// <summary>
		/// vertical position. Defaults to bottom. Valid values are: 'top' | 'bottom' | 'center' | <b>{number}</b>(y-coordinate, in px).
		/// </summary>
		public string Y { get; set; }
		private string Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the dataRange's background. Defaults to transparent.
		/// </summary>
		public color BackgroundColor { get; set; }
		private color BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the drawn border around the dataRange.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the drawn border around the dataRange, in px, defaults to 0 (no border).
		/// </summary>
		public number BorderWidth { get; set; }
		private number BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner padding of the dataRange, in px, defaults to 5. Can be set as array - [top, right, bottom, left], same as css, see image below.
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel gap between each item. Defaults to 10. It is horizontal in the dataRange with horizontal layout, and vertical in the dataRange with vertical layout. See image below.
		/// </summary>
		public number ItemGap { get; set; }
		private number ItemGap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of dataRange item.
		/// </summary>
		public number ItemWidth { get; set; }
		private number ItemWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of dataRange item.
		/// </summary>
		public number ItemHeight { get; set; }
		private number ItemHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The specified minimum value, such as 0. Defaults to null. Required parameter. Only when splitList is used, min can be ignored.
		/// </summary>
		public number Min { get; set; }
		private number Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// The specified maximum value, such as 100. Defaults to null. Required parameter. Only when splitList is used, max can be ignored.
		/// </summary>
		public number Max { get; set; }
		private number Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decimal precision. Defaults to 0 (no decimal point). If the value of max - min is not divisible by splitNumber in the existing precision, the precision will be automatically increased for the sake of exact division. Inexact division is not supported.
		/// </summary>
		public number Precision { get; set; }
		private number Precision_DefaultValue { get; set; }
		 

		/// <summary>
		/// the number of segments. Defaults to 5. Linear gradient when set to 0. When calculable is true, it is equally split into 100 parts by default.
		/// </summary>
		public number SplitNumber { get; set; }
		private number SplitNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// Customizing that how to split dataRange. When splitList is specified, splitNumber is ignored. <br>                                splitList is an Array, which can not be empty. Each item of the Array is Object like: <br>                                { <br>                                ��start: 10 ��� The start of the domain of this item. <br>                                ��end: 30 ��� The end of the domain of this item. <br>                                ������ 'start' and 'end' can be set to the same value, <br>                                ������ in which case this item is coresponding to the single value rather than an interval. <br>                                ��label: '10 to 30' ��� text label of this item. If ignoring this attribute, Text label will be auto generated.  <br>                                ��color: '#333' ��� Color of this item. If ignoring attribute, color can be auto generated.  <br>                                } <br>                                example: <a href="./example/dataRange2.html" target="_blank">this �</a>
		/// </summary>
		public Array SplitList { get; set; }
		private Array SplitList_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option is used to set the initial selected range of dataRange. This option works when "calculable" is true. <br>                                The value of this option likes: {start: 10, end: 50}
		/// </summary>
		public Object Range { get; set; }
		private Object Range_DefaultValue { get; set; }
		 

		/// <summary>
		/// selection mode. Enable dataRange switch by default. Can be one of: single, multiple
		/// </summary>
		public string SelectedMode { get; set; }
		private string SelectedMode_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether the scale roaming feature will be enabled. When enabled, ignore splitNumber and splitList, dataRange shows as linear gradient.
		/// </summary>
		public boolean Calculable { get; set; }
		private boolean Calculable_DefaultValue { get; set; }
		 

		/// <summary>
		/// Hover link with the map.
		/// </summary>
		public boolean HoverLink { get; set; }
		private boolean HoverLink_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether the scale roaming feature will be displayed in real time. Default to false (CAN NOT be changed) in the explorer which does't support canvas, such as IE6/7/8.
		/// </summary>
		public boolean Realtime { get; set; }
		private boolean Realtime_DefaultValue { get; set; }
		 

		/// <summary>
		/// color list of the dataRange. Length of the color array must be > = 2. The color shows the change from high value to low value; that is, the low color array represents the high value color. Alpha ( rgba ) is supported.
		/// </summary>
		public Array Color { get; set; }
		private Array Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// content formatter:<b>{string}</b> (Template) | <b>{Function}</b>, the template's variables are {value}' and '{value2}', which stand for start value ??and end value. There are two function parameters, whose meanings are the same as template variables. One parameter '{value}' only when calculable is true. <a href="example/dataRange.html#-en" target="_blank">Try this �</a>
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// text of the dataRange, when splitNumber is valid, defaults to the calculated value. You can specify a text array with the length of 2 to show the brief dataRange text, like ['high', 'low']. '\n' represents a line feed.
		/// </summary>
		public Array Text { get; set; }
		private Array Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// We only set the default color of dataRange text.
		/// </summary>
		public Object TextStyle { get; set; }
		private Object TextStyle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Show != Show_DefaultValue) h.Add("show",Show);
			if (Zlevel != Zlevel_DefaultValue) h.Add("zlevel",Zlevel);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (Orient != Orient_DefaultValue) h.Add("orient",Orient);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (ItemGap != ItemGap_DefaultValue) h.Add("itemGap",ItemGap);
			if (ItemWidth != ItemWidth_DefaultValue) h.Add("itemWidth",ItemWidth);
			if (ItemHeight != ItemHeight_DefaultValue) h.Add("itemHeight",ItemHeight);
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (Precision != Precision_DefaultValue) h.Add("precision",Precision);
			if (SplitNumber != SplitNumber_DefaultValue) h.Add("splitNumber",SplitNumber);
			if (SplitList != SplitList_DefaultValue) h.Add("splitList",SplitList);
			if (Range != Range_DefaultValue) h.Add("range",Range);
			if (SelectedMode != SelectedMode_DefaultValue) h.Add("selectedMode",SelectedMode);
			if (Calculable != Calculable_DefaultValue) h.Add("calculable",Calculable);
			if (HoverLink != HoverLink_DefaultValue) h.Add("hoverLink",HoverLink);
			if (Realtime != Realtime_DefaultValue) h.Add("realtime",Realtime);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (TextStyle != TextStyle_DefaultValue) h.Add("textStyle",TextStyle);
			

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