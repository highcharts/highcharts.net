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
	public partial class AxisItem  : BaseObject
	{
		public AxisItem()
		{
			Type = Type_DefaultValue = "";
			Show = Show_DefaultValue = null;
			Zlevel = Zlevel_DefaultValue = null;
			Z = Z_DefaultValue = null;
			Position = Position_DefaultValue = new NameValueCollection();
			Name = Name_DefaultValue = "";
			NameLocation = NameLocation_DefaultValue = end;
			NameTextStyle = NameTextStyle_DefaultValue = null;
			BoundaryGap = BoundaryGap_DefaultValue = null;
			Min = Min_DefaultValue = null;
			Max = Max_DefaultValue = null;
			Scale = Scale_DefaultValue = null;
			SplitNumber = SplitNumber_DefaultValue = null;
			LogLabelBase = LogLabelBase_DefaultValue = null;
			LogPositive = LogPositive_DefaultValue = null;
			AxisLine = AxisLine_DefaultValue = "";
			AxisTick = AxisTick_DefaultValue = "";
			AxisLabel = AxisLabel_DefaultValue = "";
			SplitLine = SplitLine_DefaultValue = "";
			SplitArea = SplitArea_DefaultValue = "";
			Data = Data_DefaultValue = new List<AxisItemData>();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public  Type { get; set; }
		private  Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether to show axis. Valid values are: true (show) | false (hide).
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
		/// position of the coordinate axis. For x-axis ('category'), defaults to 'bottom'. For y-axis ('value'), defaults to 'left'. Valid values are: 'bottom' | 'top' | 'left' | 'right'.
		/// </summary>
		public NameValueCollection Position { get; set; }
		private NameValueCollection Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// name of the value axis. Defaults to null.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// name location of the value axis. Defaults to 'end'. Valid values are: 'start' | 'end'.
		/// </summary>
		public string NameLocation { get; set; }
		private string NameLocation_DefaultValue { get; set; }
		 

		/// <summary>
		/// text style for the name of the value axis. Defaults to global options, takes the main color of axisLine. Can be specified.
		/// </summary>
		public Object NameTextStyle { get; set; }
		private Object NameTextStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// blank border on each side of the axis. the value within the array represents percentage, [the difference between the original minimum value and the final minimum value, the difference between the original maximum value and the final maximum value].
		/// </summary>
		public Array BoundaryGap { get; set; }
		private Array BoundaryGap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pecified minimum value, such as 0. Defaults to null. Further determined by specific values. Ignores boundaryGap[0] when specified.
		/// </summary>
		public number Min { get; set; }
		private number Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pecified maximum value, such as 100. Defaults to null. Further determined by specific values. Ignores boundaryGap[1] when specified.
		/// </summary>
		public number Max { get; set; }
		private number Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// If false, the value axis must start with 0. If true, you can set the minimum and maximum value of value axis as the starting and ending value of your value axis.
		/// </summary>
		public boolean Scale { get; set; }
		private boolean Scale_DefaultValue { get; set; }
		 

		/// <summary>
		/// Number of segments, defaults to auto split along with the min/max.
		/// </summary>
		public number SplitNumber { get; set; }
		private number SplitNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option works when axis.type === 'log'. If specified, axisLabel is drawn as exponent style. For example, when logLabelBase = 4, axisLabel is drawn like 4�, 4�. If not specified, axisLabel is drawn like 1,000,000 as usual.
		/// </summary>
		public number LogLabelBase { get; set; }
		private number LogLabelBase_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option works when axis.type === 'log'. If set to false, negative value is supported. It is self-adapting by default, which means that if all of the data is negative, logPositive will be set to false, otherwise true.
		/// </summary>
		public Object LogPositive { get; set; }
		private Object LogPositive_DefaultValue { get; set; }
		 

		/// <summary>
		/// Axis line. Default to show. See below.
		/// </summary>
		public Object AxisLine { get; set; }
		private Object AxisLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Axis tick. Defaults to hide. See below.
		/// </summary>
		public Object AxisTick { get; set; }
		private Object AxisTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Axis text label. See below.
		/// </summary>
		public Object AxisLabel { get; set; }
		private Object AxisLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// Split line. Defaults to show. See below.
		/// </summary>
		public Object SplitLine { get; set; }
		private Object SplitLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Split area. Defaults to hide. See below.
		/// </summary>
		public Object SplitArea { get; set; }
		private Object SplitArea_DefaultValue { get; set; }
		 

		/// <summary>
		///  the array of category axis text label, specifies label content. The array items are usually tex. '\n' represents a line feed, for example:                        <pre>['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', ..., 'Dec']</pre> When you need to customize individual labels, the array can use objects to accept textStyle to set custom labels, such as:                         <pre>[    'Jav', 'Feb', 'Mar',     {        value:'Apr',        //Text content, if the split name formatter is specified, this value will be passed in as a template variable value ??or parameter.        textStyle:{                 //see textStyle            color : 'red'            ...        }     },    'May', '...']</pre>
		/// </summary>
		public List<AxisItemData> Data { get; set; }
		private List<AxisItemData> Data_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (Show != Show_DefaultValue) h.Add("show",Show);
			if (Zlevel != Zlevel_DefaultValue) h.Add("zlevel",Zlevel);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (Position != Position_DefaultValue) h.Add("position",Position);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (NameLocation != NameLocation_DefaultValue) h.Add("nameLocation",NameLocation);
			if (NameTextStyle != NameTextStyle_DefaultValue) h.Add("nameTextStyle",NameTextStyle);
			if (BoundaryGap != BoundaryGap_DefaultValue) h.Add("boundaryGap",BoundaryGap);
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (Scale != Scale_DefaultValue) h.Add("scale",Scale);
			if (SplitNumber != SplitNumber_DefaultValue) h.Add("splitNumber",SplitNumber);
			if (LogLabelBase != LogLabelBase_DefaultValue) h.Add("logLabelBase",LogLabelBase);
			if (LogPositive != LogPositive_DefaultValue) h.Add("logPositive",LogPositive);
			if (AxisLine != AxisLine_DefaultValue) h.Add("axisLine",AxisLine);
			if (AxisTick != AxisTick_DefaultValue) h.Add("axisTick",AxisTick);
			if (AxisLabel != AxisLabel_DefaultValue) h.Add("axisLabel",AxisLabel);
			if (SplitLine != SplitLine_DefaultValue) h.Add("splitLine",SplitLine);
			if (SplitArea != SplitArea_DefaultValue) h.Add("splitArea",SplitArea);
			

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