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
	public partial class Option  : BaseObject
	{
		public Option()
		{
			BackgroundColor = BackgroundColor_DefaultValue = rgba(0,0,0,0);
			Color = Color_DefaultValue = null;
			RenderAsImage = RenderAsImage_DefaultValue = null;
			Calculable = Calculable_DefaultValue = null;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Timeline = Timeline_DefaultValue = "";
			Title = Title_DefaultValue = "";
			Toolbox = Toolbox_DefaultValue = "";
			Tooltip = Tooltip_DefaultValue = "";
			Legend = Legend_DefaultValue = "";
			DataRange = DataRange_DefaultValue = "";
			DataZoom = DataZoom_DefaultValue = "";
			RoamController = RoamController_DefaultValue = "";
			Grid = Grid_DefaultValue = "";
			XAxis = XAxis_DefaultValue = "";
			YAxis = YAxis_DefaultValue = "";
			Series = Series_DefaultValue = "";
			Polar = Polar_DefaultValue = "";
			SymbolList = SymbolList_DefaultValue = null;
			CalculableColor = CalculableColor_DefaultValue = rgba(255,165,0,0.6);
			CalculableHolderColor = CalculableHolderColor_DefaultValue = #ccc;
			NameConnector = NameConnector_DefaultValue = &;
			ValueConnector = ValueConnector_DefaultValue = :;
			AddDataAnimation = AddDataAnimation_DefaultValue = null;
			AnimationThreshold = AnimationThreshold_DefaultValue = null;
			AnimationDuration = AnimationDuration_DefaultValue = null;
			AnimationDurationUpdate = AnimationDurationUpdate_DefaultValue = null;
			AnimationEasing = AnimationEasing_DefaultValue = ExponentialOut;
			NoDataLoadingOption = NoDataLoadingOption_DefaultValue = "";
			Line = Line_DefaultValue = "";
			Bar = Bar_DefaultValue = "";
			Stack = Stack_DefaultValue = "";
			Tiled = Tiled_DefaultValue = "";
			Force = Force_DefaultValue = "";
			Chord = Chord_DefaultValue = "";
			Pie = Pie_DefaultValue = "";
			Funnel = Funnel_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// The background color or gradient for the outer chart area. Support rgba and defaults to null, transprent.
		/// </summary>
		public color BackgroundColor { get; set; }
		private color BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// List of color for the array series, possible array is: ['#87cefa', 'rgba(123,123,123,0.5)','...']. When there are more series than colors in the list, new colors are pulled from the start again.
		/// </summary>
		public Array Color { get; set; }
		private Array Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allows rendering as image in any browser but IE8-.supports render as image in non-IE8- browsers, can be set to true or specify image formats (png | jpeg). After rendered as image, the instance is still available (such as setOption, resize, etc.), but its various interactions will become invalid.
		/// </summary>
		public string RenderAsImage { get; set; }
		private string RenderAsImage_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether the drag-recalculate feature will be enabled. Defaults to false. (See <a href="#calculable" title="">calculable</a>, and other related properties like                                <a href="#calculableColor" title="">calculableColor</a>,                                <a href="#calculableHolderColor" title="">calculableHolderColor</a>,                                <a href="#nameConnector" title="">nameConnector</a>,                                <a href="#valueConnector" title="">valueConnector</a>).
		/// </summary>
		public boolean Calculable { get; set; }
		private boolean Calculable_DefaultValue { get; set; }
		 

		/// <summary>
		/// specifies whether the initial animation will be enabled, defaults to true. It is suggested to disable the initial animation in IE8-
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Timeline, at most one timeline control is allowed in one chart.
		/// </summary>
		public Object Timeline { get; set; }
		private Object Timeline_DefaultValue { get; set; }
		 

		/// <summary>
		/// Title, at most one title control is allowed in one chart.
		/// </summary>
		public Object Title { get; set; }
		private Object Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// Toolbox, at most one toolbox is allowed in one chart.
		/// </summary>
		public Object Toolbox { get; set; }
		private Object Toolbox_DefaultValue { get; set; }
		 

		/// <summary>
		/// Tooltip,  A small "hover box" with detailed information about the item being hovered over.
		/// </summary>
		public Object Tooltip { get; set; }
		private Object Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// Legend, at most one legend is allowed in one single/combination chart.
		/// </summary>
		public Object Legend { get; set; }
		private Object Legend_DefaultValue { get; set; }
		 

		/// <summary>
		/// DataRange, data range.
		/// </summary>
		public Object DataRange { get; set; }
		private Object DataRange_DefaultValue { get; set; }
		 

		/// <summary>
		/// DataZoom, data zoom.
		/// </summary>
		public Object DataZoom { get; set; }
		private Object DataZoom_DefaultValue { get; set; }
		 

		/// <summary>
		/// zoom and roam controller, use for the map.
		/// </summary>
		public Object RoamController { get; set; }
		private Object RoamController_DefaultValue { get; set; }
		 

		/// <summary>
		/// A network of regularly spaced lines on a Cartesian coordinate system.
		/// </summary>
		public Object Grid { get; set; }
		private Object Grid_DefaultValue { get; set; }
		 

		/// <summary>
		/// The horizontal axis array of a two-dimensional plot in Cartesian coordinates, and each item in the array represents one horizontal axis. According to Standard (1.0), at most two horizontal axes are allowed in one chart.
		/// </summary>
		public string XAxis { get; set; }
		private string XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical axis array of a two-dimensional plot in Cartesian coordinates, and each item in the array represents one vertical axis. According to Standard (1.0), at most two vertical axes are allowed in one chart.
		/// </summary>
		public string YAxis { get; set; }
		private string YAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// The data array generated by data-driven chart. Each item in the array stands for a series' options and data.
		/// </summary>
		public Array Series { get; set; }
		private Array Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Object Polar { get; set; }
		private Object Polar_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array containing the default symbols. When all symbols are used, new symbols are pulled from the start again
		/// </summary>
		public Array SymbolList { get; set; }
		private Array SymbolList_DefaultValue { get; set; }
		 

		/// <summary>
		/// color of border around drag-recalculate
		/// </summary>
		public color CalculableColor { get; set; }
		private color CalculableColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// color of calculable holder.
		/// </summary>
		public color CalculableHolderColor { get; set; }
		private color CalculableHolderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// a connector that links the names of data seriestogether after the combination of data series
		/// </summary>
		public string NameConnector { get; set; }
		private string NameConnector_DefaultValue { get; set; }
		 

		/// <summary>
		///  a connector that links the name of data series with value when island appears after the combination of data series
		/// </summary>
		public string ValueConnector { get; set; }
		private string ValueConnector_DefaultValue { get; set; }
		 

		/// <summary>
		/// specifies whether the dynamic data interface animation will be enabled, defaults to true. It is suggested to disable animation in IE8-
		/// </summary>
		public boolean AddDataAnimation { get; set; }
		private boolean AddDataAnimation_DefaultValue { get; set; }
		 

		/// <summary>
		/// threshold of animated elements. No animation if the graphic elements generated are over 2500. It is suggested to disable animation in IE8-.
		/// </summary>
		public number AnimationThreshold { get; set; }
		private number AnimationThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// duration of the enter animation, in ms.
		/// </summary>
		public number AnimationDuration { get; set; }
		private number AnimationDuration_DefaultValue { get; set; }
		 

		/// <summary>
		/// duration of the update animation, in ms.
		/// </summary>
		public number AnimationDurationUpdate { get; set; }
		private number AnimationDurationUpdate_DefaultValue { get; set; }
		 

		/// <summary>
		/// easing effect of the main element. Supports multi-level control. See<a href="http://ecomfe.github.io/zrender/doc/doc.html#animation.easing" target="_blank">zrender.animation.easing</a>, Possible values are: <br>'Linear',<br>'QuadraticIn', 'QuadraticOut', 'QuadraticInOut',<br>'CubicIn', 'CubicOut', 'CubicInOut',<br>'QuarticIn', 'QuarticOut', 'QuarticInOut',<br>'QuinticIn', 'QuinticOut', 'QuinticInOut',<br>'SinusoidalIn', 'SinusoidalOut', 'SinusoidalInOut',<br>'ExponentialIn', 'ExponentialOut', 'ExponentialInOut',<br>'CircularIn', 'CircularOut', 'CircularInOut',<br>'ElasticIn', 'ElasticOut', 'ElasticInOut',<br>'BackIn', 'BackOut', 'BackInOut',<br>'BounceIn', 'BounceOut', 'BounceInOut'<br></p>
		/// </summary>
		public string AnimationEasing { get; set; }
		private string AnimationEasing_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Object NoDataLoadingOption { get; set; }
		private Object NoDataLoadingOption_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Object Line { get; set; }
		private Object Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Object Bar { get; set; }
		private Object Bar_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Stack { get; set; }
		private string Stack_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Object Tiled { get; set; }
		private Object Tiled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Object Force { get; set; }
		private Object Force_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Object Chord { get; set; }
		private Object Chord_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Object Pie { get; set; }
		private Object Pie_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Object Funnel { get; set; }
		private Object Funnel_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (RenderAsImage != RenderAsImage_DefaultValue) h.Add("renderAsImage",RenderAsImage);
			if (Calculable != Calculable_DefaultValue) h.Add("calculable",Calculable);
			if (Animation.IsDirty()) h.Add("animation",Animation.ToJSON());
			if (Timeline != Timeline_DefaultValue) h.Add("timeline",Timeline);
			if (Title != Title_DefaultValue) h.Add("title",Title);
			if (Toolbox != Toolbox_DefaultValue) h.Add("toolbox",Toolbox);
			if (Tooltip != Tooltip_DefaultValue) h.Add("tooltip",Tooltip);
			if (Legend != Legend_DefaultValue) h.Add("legend",Legend);
			if (DataRange != DataRange_DefaultValue) h.Add("dataRange",DataRange);
			if (DataZoom != DataZoom_DefaultValue) h.Add("dataZoom",DataZoom);
			if (RoamController != RoamController_DefaultValue) h.Add("roamController",RoamController);
			if (Grid != Grid_DefaultValue) h.Add("grid",Grid);
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			if (Series != Series_DefaultValue) h.Add("series",Series);
			if (Polar != Polar_DefaultValue) h.Add("polar",Polar);
			if (SymbolList != SymbolList_DefaultValue) h.Add("symbolList",SymbolList);
			if (CalculableColor != CalculableColor_DefaultValue) h.Add("calculableColor",CalculableColor);
			if (CalculableHolderColor != CalculableHolderColor_DefaultValue) h.Add("calculableHolderColor",CalculableHolderColor);
			if (NameConnector != NameConnector_DefaultValue) h.Add("nameConnector",NameConnector);
			if (ValueConnector != ValueConnector_DefaultValue) h.Add("valueConnector",ValueConnector);
			if (AddDataAnimation != AddDataAnimation_DefaultValue) h.Add("addDataAnimation",AddDataAnimation);
			if (AnimationThreshold != AnimationThreshold_DefaultValue) h.Add("animationThreshold",AnimationThreshold);
			if (AnimationDuration != AnimationDuration_DefaultValue) h.Add("animationDuration",AnimationDuration);
			if (AnimationDurationUpdate != AnimationDurationUpdate_DefaultValue) h.Add("animationDurationUpdate",AnimationDurationUpdate);
			if (AnimationEasing != AnimationEasing_DefaultValue) h.Add("animationEasing",AnimationEasing);
			if (NoDataLoadingOption != NoDataLoadingOption_DefaultValue) h.Add("noDataLoadingOption",NoDataLoadingOption);
			if (Line != Line_DefaultValue) h.Add("line",Line);
			if (Bar != Bar_DefaultValue) h.Add("bar",Bar);
			if (Stack != Stack_DefaultValue) h.Add("stack",Stack);
			if (Tiled != Tiled_DefaultValue) h.Add("tiled",Tiled);
			if (Force != Force_DefaultValue) h.Add("force",Force);
			if (Chord != Chord_DefaultValue) h.Add("chord",Chord);
			if (Pie != Pie_DefaultValue) h.Add("pie",Pie);
			if (Funnel != Funnel_DefaultValue) h.Add("funnel",Funnel);
			

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