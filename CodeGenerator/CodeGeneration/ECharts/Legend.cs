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
	public partial class Legend  : BaseObject
	{
		public Legend()
		{
			Show = Show_DefaultValue = null;
			Zlevel = Zlevel_DefaultValue = null;
			Z = Z_DefaultValue = null;
			Orient = Orient_DefaultValue = horizontal;
			X = X_DefaultValue = center;
			Y = Y_DefaultValue = top;
			BackgroundColor = BackgroundColor_DefaultValue = rgba(0,0,0,0);
			BorderColor = BorderColor_DefaultValue = #ccc;
			BorderWidth = BorderWidth_DefaultValue = null;
			Padding = Padding_DefaultValue = null;
			ItemGap = ItemGap_DefaultValue = null;
			ItemWidth = ItemWidth_DefaultValue = null;
			ItemHeight = ItemHeight_DefaultValue = null;
			TextStyle = TextStyle_DefaultValue = null;
			Formatter = Formatter_DefaultValue = null;
			SelectedMode = SelectedMode_DefaultValue = null;
			Selected = Selected_DefaultValue = null;
			Data = Data_DefaultValue = new List<LegendData>();
			
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
		/// layout manner, defaults to horizontal. Valid values are: 'horizontal' | 'vertical'.
		/// </summary>
		public string Orient { get; set; }
		private string Orient_DefaultValue { get; set; }
		 

		/// <summary>
		/// horizontal position. Defaults to center. Valid values are: 'center' | 'left' | 'right' | <b>{number}</b>}(x-coordinate, in px).
		/// </summary>
		public string X { get; set; }
		private string X_DefaultValue { get; set; }
		 

		/// <summary>
		/// vertical position. Defaults to top. Valid values are: 'top' | 'bottom' | 'center' | <b>{number}</b>(y-coordinate, in px).
		/// </summary>
		public string Y { get; set; }
		private string Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the legend's background. Defaults to transparent.
		/// </summary>
		public color BackgroundColor { get; set; }
		private color BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the drawn border around the legend.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the drawn border around the legend, in px, defaults to 0 (no border).
		/// </summary>
		public number BorderWidth { get; set; }
		private number BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner padding of the legend, in px, defaults to 5. Can be set as array - [top, right, bottom, left], same as css, see image below.
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel gap between each item. Defaults to 10. It is horizontal in a legend with horizontal layout, and vertical in a legend with vertical layout. See image below.
		/// </summary>
		public number ItemGap { get; set; }
		private number ItemGap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Legend shape's width.
		/// </summary>
		public number ItemWidth { get; set; }
		private number ItemWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Legend shape's height.
		/// </summary>
		public number ItemHeight { get; set; }
		private number ItemHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// We only set the default color of legend text. If you want the legend text to take the color of the legend, you can set color to 'auto'.
		/// </summary>
		public Object TextStyle { get; set; }
		private Object TextStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// text formatter: <b>{string}</b> (Template) | <b>{Function}</b>, template variable is '{name}', function paramater is name.
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// selection mode. Enable legend switch by default. Can be one of: single, multiple
		/// </summary>
		public string SelectedMode { get; set; }
		private string SelectedMode_DefaultValue { get; set; }
		 

		/// <summary>
		/// The default selected state, can be used to conduct dynamic data loading with LEGEND.SELECTED event, <a href="example/legend.html#-en" target="_blank">try this �</a>
		/// </summary>
		public Object Selected { get; set; }
		private Object Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// legend content array, the array items are usually <b>{string}</b>, each item represents a series name, auto line break in layout, but you can specify a '' for a new line break.                                <br>Use the value to index the chart type and itemStyle used by series with the same name in <a href="#series" title="">series</a>. If fails, the item will be in not enabled state by default.                                <br>If you need custom legend text style, you can change the array item to <b>{Object}</b>. With text style and custom icon, the format is:                                <br>{<br>��name : <b>{string}</b>, <br>��textStyle : <b>{Object}</b>, <br>��icon : <b>{string}</b><br>}
		/// </summary>
		public List<LegendData> Data { get; set; }
		private List<LegendData> Data_DefaultValue { get; set; }
		  

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
			if (TextStyle != TextStyle_DefaultValue) h.Add("textStyle",TextStyle);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (SelectedMode != SelectedMode_DefaultValue) h.Add("selectedMode",SelectedMode);
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