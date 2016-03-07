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
	public partial class Polar  : BaseObject
	{
		public Polar()
		{
			Zlevel = Zlevel_DefaultValue = null;
			Z = Z_DefaultValue = null;
			Center = Center_DefaultValue = new string[] { null, null };
			Radius = Radius_DefaultValue = "";
			StartAngle = StartAngle_DefaultValue = null;
			SplitNumber = SplitNumber_DefaultValue = null;
			Name = Name_DefaultValue = null;
			BoundaryGap = BoundaryGap_DefaultValue = null;
			Scale = Scale_DefaultValue = null;
			AxisLine = AxisLine_DefaultValue = null;
			AxisLabel = AxisLabel_DefaultValue = null;
			SplitLine = SplitLine_DefaultValue = null;
			SplitArea = SplitArea_DefaultValue = null;
			Type = Type_DefaultValue = polygon;
			Indicator = Indicator_DefaultValue = null;
			
		}	
		

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
		/// coordinate of the center, in pixels or percent. The formula for calculating percent: min(width, height) * 50%.
		/// </summary>
		public new string[] Center { get; set; }
		private new string[] Center_DefaultValue { get; set; }
		 

		/// <summary>
		/// radius, in pixels or in percent. The formula for calculating percent: min(width, height) / 2 * 75%.
		/// </summary>
		public number Radius { get; set; }
		private number Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The start angle. Valid range is: [-180,180]
		/// </summary>
		public number StartAngle { get; set; }
		private number StartAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// the number of segments, defaults to 5
		/// </summary>
		public number SplitNumber { get; set; }
		private number SplitNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// name of coordinate axis.
		/// </summary>
		public Object Name { get; set; }
		private Object Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// blank border on each side of the value axis. the value within the array represents percentage, [the difference between the original minimum value and the final minimum value, the difference between the original maximum value and the final maximum value].
		/// </summary>
		public Array BoundaryGap { get; set; }
		private Array BoundaryGap_DefaultValue { get; set; }
		 

		/// <summary>
		/// If false, the value axis must start with 0. If true, you can set the minimum and maximum value of value axis as the starting and ending value of your value axis.
		/// </summary>
		public boolean Scale { get; set; }
		private boolean Scale_DefaultValue { get; set; }
		 

		/// <summary>
		/// axis line. Defaults to show. The property "show" specifies whether to show axisLine or not. The property "lineStyle" (see <a href="#polar.axisLine.lineStyle" title="">lineStyle</a>) controls line style for axisLine.
		/// </summary>
		public Object AxisLine { get; set; }
		private Object AxisLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// axis label.
		/// </summary>
		public Object AxisLabel { get; set; }
		private Object AxisLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// split line. Defaults to show. The property "show" specifies whether to show splitLine or not. The property "lineStyle" controls line style for splitLine.
		/// </summary>
		public Object SplitLine { get; set; }
		private Object SplitLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// split area. Defaults to hide. The property "show" specifies whether to show splitArea or not. The property "areaStyle" controls area style for splitArea.
		/// </summary>
		public Object SplitArea { get; set; }
		private Object SplitArea_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shape of polar coordinates. Valid values are: 'polygon'|'circle'.
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// radar indicator list, also label content, see the example below.
		/// </summary>
		public Array Indicator { get; set; }
		private Array Indicator_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Zlevel != Zlevel_DefaultValue) h.Add("zlevel",Zlevel);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (Center != Center_DefaultValue) h.Add("center",Center);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (StartAngle != StartAngle_DefaultValue) h.Add("startAngle",StartAngle);
			if (SplitNumber != SplitNumber_DefaultValue) h.Add("splitNumber",SplitNumber);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (BoundaryGap != BoundaryGap_DefaultValue) h.Add("boundaryGap",BoundaryGap);
			if (Scale != Scale_DefaultValue) h.Add("scale",Scale);
			if (AxisLine != AxisLine_DefaultValue) h.Add("axisLine",AxisLine);
			if (AxisLabel != AxisLabel_DefaultValue) h.Add("axisLabel",AxisLabel);
			if (SplitLine != SplitLine_DefaultValue) h.Add("splitLine",SplitLine);
			if (SplitArea != SplitArea_DefaultValue) h.Add("splitArea",SplitArea);
			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (Indicator != Indicator_DefaultValue) h.Add("indicator",Indicator);
			

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