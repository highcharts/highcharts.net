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
	public partial class Title  : BaseObject
	{
		public Title()
		{
			Show = Show_DefaultValue = null;
			Zlevel = Zlevel_DefaultValue = null;
			Z = Z_DefaultValue = null;
			Text = Text_DefaultValue = "";
			Link = Link_DefaultValue = "";
			Target = Target_DefaultValue = null;
			Subtext = Subtext_DefaultValue = "";
			Sublink = Sublink_DefaultValue = "";
			Subtarget = Subtarget_DefaultValue = null;
			X = X_DefaultValue = left;
			Y = Y_DefaultValue = top;
			TextAlign = TextAlign_DefaultValue = null;
			BackgroundColor = BackgroundColor_DefaultValue = rgba(0,0,0,0);
			BorderColor = BorderColor_DefaultValue = #ccc;
			BorderWidth = BorderWidth_DefaultValue = null;
			Padding = Padding_DefaultValue = null;
			ItemGap = ItemGap_DefaultValue = null;
			TextStyle = TextStyle_DefaultValue = null;
			SubtextStyle = SubtextStyle_DefaultValue = null;
			Mark = Mark_DefaultValue = ?????;
			MarkUndo = MarkUndo_DefaultValue = ?????;
			MarkClear = MarkClear_DefaultValue = ?????;
			DataZoom = DataZoom_DefaultValue = ????;
			DataZoomReset = DataZoomReset_DefaultValue = ??????;
			Line = Line_DefaultValue = ?????;
			Bar = Bar_DefaultValue = ?????;
			Stack = Stack_DefaultValue = ??;
			Tiled = Tiled_DefaultValue = ??;
			Force = Force_DefaultValue = ????????;
			Chord = Chord_DefaultValue = ?????;
			Pie = Pie_DefaultValue = ????;
			Funnel = Funnel_DefaultValue = ?????;
			Show = Show_DefaultValue = null;
			OffsetCenter = OffsetCenter_DefaultValue = null;
			TextStyle = TextStyle_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Specifies whether to show timeline. Valid values are: true (show) | false (hide).
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
		/// title text, '\n' represents a line feed.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// title text hyperlink.
		/// </summary>
		public string Link { get; set; }
		private string Link_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies a window to open the title hyperlink. Can be one of 'self' | 'blank'. If unspecified, equal to 'blank' (a new window).
		/// </summary>
		public string Target { get; set; }
		private string Target_DefaultValue { get; set; }
		 

		/// <summary>
		/// subtitle text, '\n' represents a line feed.
		/// </summary>
		public string Subtext { get; set; }
		private string Subtext_DefaultValue { get; set; }
		 

		/// <summary>
		/// subtitle text hyperlink.
		/// </summary>
		public string Sublink { get; set; }
		private string Sublink_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies a window to open the subtitle hyperlink. Can be one of 'self' | 'blank'. If unspecified, equal to 'blank' (a new window).
		/// </summary>
		public string Subtarget { get; set; }
		private string Subtarget_DefaultValue { get; set; }
		 

		/// <summary>
		/// horizontal position. Defaults to left. Valid values are: 'center' | 'left' | 'right' | <b>{number}</b>(x-coordinate, in px).
		/// </summary>
		public string X { get; set; }
		private string X_DefaultValue { get; set; }
		 

		/// <summary>
		/// vertical position. Defaults to top. Valid values are: 'top' | 'bottom' | 'center' | <b>{number}</b>(y-coordinate, in px).
		/// </summary>
		public string Y { get; set; }
		private string Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// horizontal alignment. It is further determined by the x option by default. Valid values are: left' | 'right' | 'center.
		/// </summary>
		public string TextAlign { get; set; }
		private string TextAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the title's background. Defaults to transparent.
		/// </summary>
		public color BackgroundColor { get; set; }
		private color BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the drawn border around the title.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the drawn border around the title, in px, defaults to 0 (no border).
		/// </summary>
		public number BorderWidth { get; set; }
		private number BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner padding of the title, in px, defaults to 5. Can be set as array - [top, right, bottom, left], same as css, see image below.
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical gap between each item in the title/subtitle, in px, defaults to 10.
		/// </summary>
		public number ItemGap { get; set; }
		private number ItemGap_DefaultValue { get; set; }
		 

		/// <summary>
		/// the style of title text.
		/// </summary>
		public Object TextStyle { get; set; }
		private Object TextStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// the style of subtitle text.
		/// </summary>
		public Object SubtextStyle { get; set; }
		private Object SubtextStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Mark { get; set; }
		private string Mark_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MarkUndo { get; set; }
		private string MarkUndo_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MarkClear { get; set; }
		private string MarkClear_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DataZoom { get; set; }
		private string DataZoom_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DataZoomReset { get; set; }
		private string DataZoomReset_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Line { get; set; }
		private string Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Bar { get; set; }
		private string Bar_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Stack { get; set; }
		private string Stack_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Tiled { get; set; }
		private string Tiled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Force { get; set; }
		private string Force_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Chord { get; set; }
		private string Chord_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Pie { get; set; }
		private string Pie_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Funnel { get; set; }
		private string Funnel_DefaultValue { get; set; }
		 

		/// <summary>
		/// The property "show" specifies whether to show title or not.
		/// </summary>
		public boolean Show { get; set; }
		private boolean Show_DefaultValue { get; set; }
		 

		/// <summary>
		/// The property "offsetCenter" is used to locate title. Offset to the center coordinates if the array is x-axis. If in percent, it is relative to the outer radius of the gauge. 
		/// </summary>
		public Array OffsetCenter { get; set; }
		private Array OffsetCenter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  TextStyle { get; set; }
		private  TextStyle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Show != Show_DefaultValue) h.Add("show",Show);
			if (Zlevel != Zlevel_DefaultValue) h.Add("zlevel",Zlevel);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Link != Link_DefaultValue) h.Add("link",Link);
			if (Target != Target_DefaultValue) h.Add("target",Target);
			if (Subtext != Subtext_DefaultValue) h.Add("subtext",Subtext);
			if (Sublink != Sublink_DefaultValue) h.Add("sublink",Sublink);
			if (Subtarget != Subtarget_DefaultValue) h.Add("subtarget",Subtarget);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (TextAlign != TextAlign_DefaultValue) h.Add("textAlign",TextAlign);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (ItemGap != ItemGap_DefaultValue) h.Add("itemGap",ItemGap);
			if (TextStyle != TextStyle_DefaultValue) h.Add("textStyle",TextStyle);
			if (SubtextStyle != SubtextStyle_DefaultValue) h.Add("subtextStyle",SubtextStyle);
			if (Mark != Mark_DefaultValue) h.Add("mark",Mark);
			if (MarkUndo != MarkUndo_DefaultValue) h.Add("markUndo",MarkUndo);
			if (MarkClear != MarkClear_DefaultValue) h.Add("markClear",MarkClear);
			if (DataZoom != DataZoom_DefaultValue) h.Add("dataZoom",DataZoom);
			if (DataZoomReset != DataZoomReset_DefaultValue) h.Add("dataZoomReset",DataZoomReset);
			if (Line != Line_DefaultValue) h.Add("line",Line);
			if (Bar != Bar_DefaultValue) h.Add("bar",Bar);
			if (Stack != Stack_DefaultValue) h.Add("stack",Stack);
			if (Tiled != Tiled_DefaultValue) h.Add("tiled",Tiled);
			if (Force != Force_DefaultValue) h.Add("force",Force);
			if (Chord != Chord_DefaultValue) h.Add("chord",Chord);
			if (Pie != Pie_DefaultValue) h.Add("pie",Pie);
			if (Funnel != Funnel_DefaultValue) h.Add("funnel",Funnel);
			if (Show != Show_DefaultValue) h.Add("show",Show);
			if (OffsetCenter != OffsetCenter_DefaultValue) h.Add("offsetCenter",OffsetCenter);
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