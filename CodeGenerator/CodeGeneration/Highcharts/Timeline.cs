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
	public partial class Timeline  : BaseObject
	{
		public Timeline()
		{
			Show = Show_DefaultValue = null;
			Zlevel = Zlevel_DefaultValue = null;
			Z = Z_DefaultValue = null;
			Type = Type_DefaultValue = time;
			NotMerge = NotMerge_DefaultValue = null;
			Realtime = Realtime_DefaultValue = null;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			X2 = X2_DefaultValue = null;
			Y2 = Y2_DefaultValue = null;
			Width = Width_DefaultValue = "";
			Height = Height_DefaultValue = null;
			BackgroundColor = BackgroundColor_DefaultValue = rgba(0,0,0,0);
			BorderWidth = BorderWidth_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = #ccc;
			Padding = Padding_DefaultValue = null;
			ControlPosition = ControlPosition_DefaultValue = left;
			AutoPlay = AutoPlay_DefaultValue = null;
			Loop = Loop_DefaultValue = null;
			PlayInterval = PlayInterval_DefaultValue = null;
			LineStyle = LineStyle_DefaultValue = null;
			Label = Label_DefaultValue = new TimelineLabel();
			CheckpointStyle = CheckpointStyle_DefaultValue = new TimelineCheckpointStyle();
			ControlStyle = ControlStyle_DefaultValue = new TimelineControlStyle();
			Symbol = Symbol_DefaultValue = emptyDiamond;
			SymbolSize = SymbolSize_DefaultValue = null;
			CurrentIndex = CurrentIndex_DefaultValue = null;
			Data = Data_DefaultValue = new List<TimelineData>();
			
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
		/// When the type is time, interval of the timeline is calculated based on the time span. Can also be: 'number'.
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to merge the options for timeline When called multiple times, same as the second parameter of setOption. (See <a href="/doc/doc-en.html#Instance Methods"" title="">Instance Methods</a>).
		/// </summary>
		public boolean NotMerge { get; set; }
		private boolean NotMerge_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether the chart will be displayed in real time when you drag or click the timeline. Default to false (CAN NOT be changed) in the explorer which does't support canvas, such as IE6/7/8.
		/// </summary>
		public boolean Realtime { get; set; }
		private boolean Realtime_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set abscissa on the upper left corner of the timeline in px, or in percent (string) such as '50%' (horizontal center of the display area).
		/// </summary>
		public string X { get; set; }
		private string X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set ordinate on the upper left corner of the timeline in px, or in percent (string). Defaults to null. The position varies with y2, such as '50%' (vertical center of the display area).
		/// </summary>
		public string Y { get; set; }
		private string Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set abscissa on the lower right corner of the timeline in px, or in percent (string) such as '50%' (horizontal center of the display area).
		/// </summary>
		public string X2 { get; set; }
		private string X2_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set ordinate on the lower right corner of the timeline in px, or in percent (string) such as '50%' (vertical center of the display area).
		/// </summary>
		public string Y2 { get; set; }
		private string Y2_DefaultValue { get; set; }
		 

		/// <summary>
		/// Width of the timeline, defaults to the total width - x - x2, in px, ignore x2 after specifying width. See the image below.                                 <br>Can also be set in percent (string), such as '50%' (half the width of the display area).
		/// </summary>
		public number Width { get; set; }
		private number Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// Height of the timeline, in px, or in percent (string) such as '50%' (half the height of the display area).
		/// </summary>
		public number Height { get; set; }
		private number Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the background. Defaults to transparent.
		/// </summary>
		public color BackgroundColor { get; set; }
		private color BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the border.
		/// </summary>
		public number BorderWidth { get; set; }
		private number BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border.
		/// </summary>
		public color BorderColor { get; set; }
		private color BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner padding, in px, defaults to 5. Can be set as array - [top, right, bottom, left], same as css, see image below.
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The position of play controller. Valid values are: 'left' | 'right' | 'none'
		/// </summary>
		public string ControlPosition { get; set; }
		private string ControlPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether to play automatically.
		/// </summary>
		public boolean AutoPlay { get; set; }
		private boolean AutoPlay_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether to play in a loop.
		/// </summary>
		public boolean Loop { get; set; }
		private boolean Loop_DefaultValue { get; set; }
		 

		/// <summary>
		/// Play time interval, in ms.
		/// </summary>
		public number PlayInterval { get; set; }
		private number PlayInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sets the line style of the timeline.
		/// </summary>
		public Object LineStyle { get; set; }
		private Object LineStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// timeline label text<br>                                 <br>show: specifies whether to show.                                 <br>interval: sets interval. Defaults to 'auto'. Valid values are: 'auto' (automatically hide those that cannot be displayed) | 0 (unhide all) | {number}                                 <br>rotate: the angle of rotation, defaults to 0 (not rotate). Positive value for counterclockwise rotation, negative value for clockwise rotation. Valid values are: -90 ~ 90                                 <br>formatter: interval name formatter: {string} (Template) | {Function}                                 <br>textStyle: text style, (see textStyle).
		/// </summary>
		public TimelineLabel Label { get; set; }
		private TimelineLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// timeline checkpoint<br>                                 <br>symbol: symbol of the checkpoint, defaults to the symbol on timeline.                                 <br>symbolSize: size of the checkpoint symbol, defaults to the size of symbol on timeline.                                 <br>color: color of the checkpoint symbol, defaults to the color of the checkpoint. A specific color can be specified; If unspecified, defaults to '#1e90ff'.                                 <br>borderColor: the color of the checkpoint symbol border.                                 <br>borderWidth: the width of the checkpoint symbol border.                                 <br>label: see above.
		/// </summary>
		public TimelineCheckpointStyle CheckpointStyle { get; set; }
		private TimelineCheckpointStyle CheckpointStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// the style of timeline controller. ItemSize, itemGap and both normal and highlight color can be specified.
		/// </summary>
		public TimelineControlStyle ControlStyle { get; set; }
		private TimelineControlStyle ControlStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// the symbol for timeline tick, same as serie.symbol.
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// size of the symbol for timeline tick, same as serie.symbolSize.
		/// </summary>
		public number SymbolSize { get; set; }
		private number SymbolSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The current index position, corresponding to options array, used to display a specific series.
		/// </summary>
		public number CurrentIndex { get; set; }
		private number CurrentIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// timeline list, also the timeline label content.
		/// </summary>
		public List<TimelineData> Data { get; set; }
		private List<TimelineData> Data_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Show != Show_DefaultValue) h.Add("show",Show);
			if (Zlevel != Zlevel_DefaultValue) h.Add("zlevel",Zlevel);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (NotMerge != NotMerge_DefaultValue) h.Add("notMerge",NotMerge);
			if (Realtime != Realtime_DefaultValue) h.Add("realtime",Realtime);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (X2 != X2_DefaultValue) h.Add("x2",X2);
			if (Y2 != Y2_DefaultValue) h.Add("y2",Y2);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (ControlPosition != ControlPosition_DefaultValue) h.Add("controlPosition",ControlPosition);
			if (AutoPlay != AutoPlay_DefaultValue) h.Add("autoPlay",AutoPlay);
			if (Loop != Loop_DefaultValue) h.Add("loop",Loop);
			if (PlayInterval != PlayInterval_DefaultValue) h.Add("playInterval",PlayInterval);
			if (LineStyle != LineStyle_DefaultValue) h.Add("lineStyle",LineStyle);
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (CheckpointStyle.IsDirty()) h.Add("checkpointStyle",CheckpointStyle.ToHashtable());
			if (ControlStyle.IsDirty()) h.Add("controlStyle",ControlStyle.ToHashtable());
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (SymbolSize != SymbolSize_DefaultValue) h.Add("symbolSize",SymbolSize);
			if (CurrentIndex != CurrentIndex_DefaultValue) h.Add("currentIndex",CurrentIndex);
			

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