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
	public partial class DataZoom  : BaseObject
	{
		public DataZoom()
		{
			Show = Show_DefaultValue = null;
			Title = Title_DefaultValue = new DataZoomTitle();
			Zlevel = Zlevel_DefaultValue = null;
			Z = Z_DefaultValue = null;
			Show = Show_DefaultValue = null;
			Orient = Orient_DefaultValue = horizontal;
			X = X_DefaultValue = "";
			Y = Y_DefaultValue = "";
			Width = Width_DefaultValue = "";
			Height = Height_DefaultValue = "";
			BackgroundColor = BackgroundColor_DefaultValue = rgba(0,0,0,0);
			DataBackgroundColor = DataBackgroundColor_DefaultValue = #eee;
			FillerColor = FillerColor_DefaultValue = rgba(144,197,237,0.2);
			HandleColor = HandleColor_DefaultValue = rgba(70,130,180,0.8);
			HandleSize = HandleSize_DefaultValue = null;
			XAxisIndex = XAxisIndex_DefaultValue = null;
			YAxisIndex = YAxisIndex_DefaultValue = null;
			Start = Start_DefaultValue = null;
			End = End_DefaultValue = null;
			ShowDetail = ShowDetail_DefaultValue = null;
			Realtime = Realtime_DefaultValue = null;
			ZoomLock = ZoomLock_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public boolean Show { get; set; }
		private boolean Show_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public DataZoomTitle Title { get; set; }
		private DataZoomTitle Title_DefaultValue { get; set; }
		 

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
		/// Specifies whether to show dataZoom. If true, take over all the series of data using specified category axis. If unspecified, take over all the Cartesian coordinate system data.
		/// </summary>
		public boolean Show { get; set; }
		private boolean Show_DefaultValue { get; set; }
		 

		/// <summary>
		/// layout manner, defaults to horizontal. Valid values are: 'horizontal' | 'vertical'.
		/// </summary>
		public string Orient { get; set; }
		private string Orient_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal placement. By default it is adapted according to the grid's parameters. Vertical layout is left by default, can be specified. <b>{number}</b> (the x-coordinate, in pixels, of the upper-left corner.)
		/// </summary>
		public number X { get; set; }
		private number X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical placement. By default it is adapted according to the grid's parameters. Vertical layout is bottom by default, can be specified. <b>{number}</b> (the y-coordinate, in pixels, of the upper-left corner.)
		/// </summary>
		public number Y { get; set; }
		private number Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies width. In honrizontal layout, it is adapted according to the grid's parameters by default. In vertical layout, defaults to 30, can be specified. <b>{number}</b> (width, in px)
		/// </summary>
		public number Width { get; set; }
		private number Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies height. In vertical layout, it is adapted according to the grid's parameters by default. In honrizontal layout, defaults to 30, can be specified. <b>{number}</b> (height, in px)
		/// </summary>
		public number Height { get; set; }
		private number Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the background. Defaults to transparent.
		/// </summary>
		public color BackgroundColor { get; set; }
		private color BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the dataZoom's background. Only the first series would be rendered as data background.
		/// </summary>
		public color DataBackgroundColor { get; set; }
		private color DataBackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color of the selected area.
		/// </summary>
		public color FillerColor { get; set; }
		private color FillerColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the control handle.
		/// </summary>
		public color HandleColor { get; set; }
		private color HandleColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The size of the control handle.
		/// </summary>
		public number HandleSize { get; set; }
		private number HandleSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// If unspecified, it controls by default all the x-axes. You can use array to specify multiple x-axes Index that needs to be controlled, and number to specify one x-axis Index that needs to be controlled.
		/// </summary>
		public string XAxisIndex { get; set; }
		private string XAxisIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// If unspecified, it controls by default all the y-axes. You can use array to specify multiple y-axes Index that needs to be controlled, and number to specify one y-axis Index that needs to be controlled.
		/// </summary>
		public string YAxisIndex { get; set; }
		private string YAxisIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// The start percent of dataZoom. Defaults to 0 (%), starts with the first data.
		/// </summary>
		public number Start { get; set; }
		private number Start_DefaultValue { get; set; }
		 

		/// <summary>
		/// The end percent of dataZoom. Defaults to 100 (%), ends with the last data.
		/// </summary>
		public number End { get; set; }
		private number End_DefaultValue { get; set; }
		 

		/// <summary>
		/// Show detail when dragging.
		/// </summary>
		public boolean ShowDetail { get; set; }
		private boolean ShowDetail_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether dataZoom will be displayed in real time. It is suggested to disable the realtime effect when your browser is slow or data sets are large and complex. Default to false (CAN NOT be changed) in the explorer which does't support canvas, such as IE6/7/8.
		/// </summary>
		public boolean Realtime { get; set; }
		private boolean Realtime_DefaultValue { get; set; }
		 

		/// <summary>
		/// DataZoom lock. Defaults to false. When set to true, the selected area cannot be zoomed,  i.e. (end - start) value remains unchanged; only data roaming is applicable.
		/// </summary>
		public boolean ZoomLock { get; set; }
		private boolean ZoomLock_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Show != Show_DefaultValue) h.Add("show",Show);
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (Zlevel != Zlevel_DefaultValue) h.Add("zlevel",Zlevel);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (Show != Show_DefaultValue) h.Add("show",Show);
			if (Orient != Orient_DefaultValue) h.Add("orient",Orient);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (DataBackgroundColor != DataBackgroundColor_DefaultValue) h.Add("dataBackgroundColor",DataBackgroundColor);
			if (FillerColor != FillerColor_DefaultValue) h.Add("fillerColor",FillerColor);
			if (HandleColor != HandleColor_DefaultValue) h.Add("handleColor",HandleColor);
			if (HandleSize != HandleSize_DefaultValue) h.Add("handleSize",HandleSize);
			if (XAxisIndex != XAxisIndex_DefaultValue) h.Add("xAxisIndex",XAxisIndex);
			if (YAxisIndex != YAxisIndex_DefaultValue) h.Add("yAxisIndex",YAxisIndex);
			if (Start != Start_DefaultValue) h.Add("start",Start);
			if (End != End_DefaultValue) h.Add("end",End);
			if (ShowDetail != ShowDetail_DefaultValue) h.Add("showDetail",ShowDetail);
			if (Realtime != Realtime_DefaultValue) h.Add("realtime",Realtime);
			if (ZoomLock != ZoomLock_DefaultValue) h.Add("zoomLock",ZoomLock);
			

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