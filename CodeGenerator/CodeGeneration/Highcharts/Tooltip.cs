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
	public partial class Tooltip  : BaseObject
	{
		public Tooltip()
		{
			Show = Show_DefaultValue = null;
			Zlevel = Zlevel_DefaultValue = null;
			Z = Z_DefaultValue = null;
			ShowContent = ShowContent_DefaultValue = null;
			Trigger = Trigger_DefaultValue = item;
			Position = Position_DefaultValue = new NameValueCollection();
			Formatter = Formatter_DefaultValue = null;
			IslandFormatter = IslandFormatter_DefaultValue = {a} < br/>{b} : {c};
			ShowDelay = ShowDelay_DefaultValue = null;
			HideDelay = HideDelay_DefaultValue = null;
			TransitionDuration = TransitionDuration_DefaultValue = null;
			Enterable = Enterable_DefaultValue = null;
			BackgroundColor = BackgroundColor_DefaultValue = rgba(0,0,0,0.7);
			BorderColor = BorderColor_DefaultValue = #333;
			BorderRadius = BorderRadius_DefaultValue = null;
			BorderWidth = BorderWidth_DefaultValue = null;
			Padding = Padding_DefaultValue = null;
			AxisPointer = AxisPointer_DefaultValue = new TooltipAxisPointer();
			TextStyle = TextStyle_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Specifies whether to show tooltip. Valid values are: true (show) | false (hide).
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
		/// Specifies whether to show the content of tooltip. Set it to false when you just need the tooltip to trigger events or show axisPointer. <br>. Valid values are: true (show) | false (hide).
		/// </summary>
		public boolean ShowContent { get; set; }
		private boolean ShowContent_DefaultValue { get; set; }
		 

		/// <summary>
		/// Type of trigger. Defaults to 'item'. See image below. Valid values are: 'item' | 'axis'.
		/// </summary>
		public string Trigger { get; set; }
		private string Trigger_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies position, pass in <b>{Array}</b>, like [x, y], fixed position [x, y]; pass in <b>{Function}</b>, like function([x, y]) {return [newX,newY]}. The default displayed coordinates are input parameters, the new user-specified coordinates are output return values.
		/// </summary>
		public NameValueCollection Position { get; set; }
		private NameValueCollection Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// content formatter: <b>{string}</b> (Template) | <b>{Function}</b>. Supports asynchronous callback. See below.<br>                        <li>                            <b>{string}</b>, Template, its variables are:                            <ul>                                <li>{a} | {a0}</li>                                <li>{b} | {b0}</li>                                <li>{c} | {c0}</li>                                <li>{d} | {d0} (some chart types do not have this variable)</li>                                <li>{e} | {e0} (some chart types do not have this variable)</li>                                <li> If there are multiple sets of data, there will be multiple sets of varaibles accordingly, like {a1}, {b1}, {c1}, {d1}, {a2}, {b2}, {c2}, {d2}, ...</li>                                <li> Here are what variable a, b, c and d reprensent in different chart types:                                    <ul>                                        <li><b>line & area</b>, <b>column & bar, <b>candlestick</b></b>: a (series name), b(category value), c (value), d(null)</li>                                        <li><b>scatter & bubble</b>:  a (series name), b (data name), c (value array), d(null)</li>                                        <li><b>map</b>: a (series name), b (area name), c(merged value), d(null)</li>                                        <li><b>pie</b>, <b>radar</b>, <b>gauge</b>, <b>funnel</b>: a (series name), b (data item name),c(value), d (pie: percent | radar: indicator name) </li>                                        <li><b>force, chord</b> :                                            <ul>                                                <li>node : a (series name),b (node name),c (node value), d (node index), e</li>                                                <li>link : a (series name),b (link name, default bigEndNodeName-smallEndNodeName),c(link.value), d(name or index of big end node), e(name or index of small end node)</li>                                            </ul>                                        </li>                                    </ul>                                </li>                            </ul>                        </li>                        <li>                            <b>{Function}</b>, the list of parameters passed in is [params, ticket, callback], detail as follows:                            <ul>                                <li><Array> params : array content and template varaibles are the same<pre>[    {        seriesIndex: 0,        seriesName: 'Sales',        name: 'Monday',        dataIndex: 0,        data: data,        name: name,        value: value,        percent: special,       // pie        indicator: special,     // radar, force, chord        value2: special2,       // force, chord        indicator2: special2    // force, chord    },    {..},    ...]</pre></li>                                <li><String> ticket: asynchronous callback marker</li>                                <li><Function> callback: asynchronous callback, the callback needs two parameters, the first one is the ticket that we mentioned earlier, the second is the fill content html. </li>                                <li><i>* When the function callbacks, 'this' pointer points to the current chart instance (myChart). </i></li>                            </ul>                        </li>                    
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// island content formatter. For Drag-Recalculate only: <b>{string}</b> (Template) | <b>{Function}</b>. See below.
		/// </summary>
		public string IslandFormatter { get; set; }
		private string IslandFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// The number of milliseconds to wait until the tooltip is shown when the mouse moves across a point or chart. Placing a delay on a tooltip before it is displayed can prevent frequent switch, especially when the tooltip text is requested asynchronously.
		/// </summary>
		public number ShowDelay { get; set; }
		private number ShowDelay_DefaultValue { get; set; }
		 

		/// <summary>
		/// The number of milliseconds to wait until the tooltip is hidden when mouse out from a point or chart.
		/// </summary>
		public number HideDelay { get; set; }
		private number HideDelay_DefaultValue { get; set; }
		 

		/// <summary>
		/// The duration in seconds of the animated transition. If you want the tooltip to follow the mouse as it moves across a point or chart, setting showDelay to 0 is the key, but setting transitionDuration to 0 can also make a difference in interactive experiences.
		/// </summary>
		public number TransitionDuration { get; set; }
		private number TransitionDuration_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether to let the mouse go into the tip dom, default to false. Let it be true if you need interaction like link | button etc.
		/// </summary>
		public boolean Enterable { get; set; }
		private boolean Enterable_DefaultValue { get; set; }
		 

		/// <summary>
		/// The background color for the tooltip. Defaults to a black color (opacity to 30%).
		/// </summary>
		public color BackgroundColor { get; set; }
		private color BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the tooltip border.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The radius of the rounded border corners, in px, defaults to 4.
		/// </summary>
		public number BorderRadius { get; set; }
		private number BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the tooltip border, defaults to 0 (no border).
		/// </summary>
		public number BorderWidth { get; set; }
		private number BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner padding of the tooltip, in px, defaults to 5. Can be set as array - [top, right, bottom, left], same as css.
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// axis pointer, triggered by axis. Default type is line. Valid types are: 'line' | 'cross' | 'shadow' | 'none'. Each type has its corresponding style, see below.                                 <br>lineStyle: style for line pointer, (see <a href="#tooltip.axisPointer.lineStyle" title="">lineStyle</a>),                                 <br>crossStyle: style for crosshairs pointer, (see <a href="#tooltip.axisPointer.crossStyle" title="">crossStyle</a>),                                 <br>shadowStyle: style for shadow pointer, (see <a href="#tooltip.axisPointer.shadowStyle" title="">shadowStyle</a>, areaStyle. Size is  set to 'auto' by default. Width can be specified.
		/// </summary>
		public TooltipAxisPointer AxisPointer { get; set; }
		private TooltipAxisPointer AxisPointer_DefaultValue { get; set; }
		 

		/// <summary>
		/// style for the tooltip text. Defaults to white.
		/// </summary>
		public Object TextStyle { get; set; }
		private Object TextStyle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Show != Show_DefaultValue) h.Add("show",Show);
			if (Zlevel != Zlevel_DefaultValue) h.Add("zlevel",Zlevel);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (ShowContent != ShowContent_DefaultValue) h.Add("showContent",ShowContent);
			if (Trigger != Trigger_DefaultValue) h.Add("trigger",Trigger);
			if (Position != Position_DefaultValue) h.Add("position",Position);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (IslandFormatter != IslandFormatter_DefaultValue) h.Add("islandFormatter",IslandFormatter);
			if (ShowDelay != ShowDelay_DefaultValue) h.Add("showDelay",ShowDelay);
			if (HideDelay != HideDelay_DefaultValue) h.Add("hideDelay",HideDelay);
			if (TransitionDuration != TransitionDuration_DefaultValue) h.Add("transitionDuration",TransitionDuration);
			if (Enterable != Enterable_DefaultValue) h.Add("enterable",Enterable);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (AxisPointer.IsDirty()) h.Add("axisPointer",AxisPointer.ToHashtable());
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