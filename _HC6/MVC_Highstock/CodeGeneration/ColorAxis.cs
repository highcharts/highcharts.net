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
	public partial class ColorAxis  : BaseObject
	{
		public ColorAxis()
		{
			StartOfWeek = StartOfWeek_DefaultValue = 1;
			Overscroll = Overscroll_DefaultValue = 0;
			MaxRange = MaxRange_DefaultValue = null;
			Ceiling = Ceiling_DefaultValue = null;
			Floor = Floor_DefaultValue = null;
			GridZIndex = GridZIndex_DefaultValue = 1;
			TickAmount = TickAmount_DefaultValue = null;
			Visible = Visible_DefaultValue = true;
			Ordinal = Ordinal_DefaultValue = true;
			Range = Range_DefaultValue = null;
			Stops = Stops_DefaultValue = null;
			Min = Min_DefaultValue = null;
			Max = Max_DefaultValue = null;
			StartOnTick = StartOnTick_DefaultValue = false;
			EndOnTick = EndOnTick_DefaultValue = false;
			MinColor = MinColor_DefaultValue = null;
			MaxColor = MaxColor_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>For datetime axes, this decides where to put the tick between weeks. 0 = Sunday, 1 = Monday.</p>
		/// </summary>
		public double? StartOfWeek { get; set; }
		private double? StartOfWeek_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Additional range on the right side of the xAxis. Works similar to<code>xAxis.maxPadding</code>, but value is set in milliseconds. Can be set for bothmain <code>xAxis</code> and the navigator&#39;s <code>xAxis</code>.</p>
		/// </summary>
		public double? Overscroll { get; set; }
		private double? Overscroll_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Maximum range which can be set using the navigator&#39;s handles.Opposite of <a href="#xAxis.minRange">xAxis.minRange</a>.</p>
		/// </summary>
		public double? MaxRange { get; set; }
		private double? MaxRange_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The highest allowed value for automatically computed axis extremes.</p>
		/// </summary>
		public double? Ceiling { get; set; }
		private double? Ceiling_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The lowest allowed value for automatically computed axis extremes.</p>
		/// </summary>
		public double? Floor { get; set; }
		private double? Floor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The Z index of the grid lines.</p>
		/// </summary>
		public double? GridZIndex { get; set; }
		private double? GridZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The amount of ticks to draw on the axis. This opens up for aligningthe ticks of multiple charts or panes within a chart. This optionoverrides the <code>tickPixelInterval</code> option.</p><p>This option only has an effect on linear axes. Datetime, logarithmicor category axes are not affected.</p>
		/// </summary>
		public double? TickAmount { get; set; }
		private double? TickAmount_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether axis, including axis title, line, ticks and labels, shouldbe visible.</p>
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>In an ordinal axis, the points are equally spaced in the chart regardlessof the actual time or x distance between them. This means that missingdata for nights or weekends will not take up space in the chart.</p>
		/// </summary>
		public bool? Ordinal { get; set; }
		private bool? Ordinal_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The zoomed range to display when only defining one or none of <code>min</code>or <code>max</code>. For example, to show the latest month, a range of one monthcan be set.</p>
		/// </summary>
		public double? Range { get; set; }
		private double? Range_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<Stop> Stops { get; set; }
		private List<Stop> Stops_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Min { get; set; }
		private double? Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Max { get; set; }
		private double? Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? StartOnTick { get; set; }
		private bool? StartOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? EndOnTick { get; set; }
		private bool? EndOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MinColor { get; set; }
		private string MinColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MaxColor { get; set; }
		private string MaxColor_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (StartOfWeek != StartOfWeek_DefaultValue) h.Add("startOfWeek",StartOfWeek);
			if (Overscroll != Overscroll_DefaultValue) h.Add("overscroll",Overscroll);
			if (MaxRange != MaxRange_DefaultValue) h.Add("maxRange",MaxRange);
			if (Ceiling != Ceiling_DefaultValue) h.Add("ceiling",Ceiling);
			if (Floor != Floor_DefaultValue) h.Add("floor",Floor);
			if (GridZIndex != GridZIndex_DefaultValue) h.Add("gridZIndex",GridZIndex);
			if (TickAmount != TickAmount_DefaultValue) h.Add("tickAmount",TickAmount);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (Ordinal != Ordinal_DefaultValue) h.Add("ordinal",Ordinal);
			if (Range != Range_DefaultValue) h.Add("range",Range);
			if (Stops != Stops_DefaultValue) h.Add("stops", HashifyList(Stops));
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (StartOnTick != StartOnTick_DefaultValue) h.Add("startOnTick",StartOnTick);
			if (EndOnTick != EndOnTick_DefaultValue) h.Add("endOnTick",EndOnTick);
			if (MinColor != MinColor_DefaultValue) h.Add("minColor",MinColor);
			if (MaxColor != MaxColor_DefaultValue) h.Add("maxColor",MaxColor);
			

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