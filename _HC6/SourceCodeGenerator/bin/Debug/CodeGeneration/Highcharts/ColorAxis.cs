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
	public partial class ColorAxis  : BaseObject
	{
		public ColorAxis()
		{
			MinPadding = MinPadding_DefaultValue = 0;
			MaxPadding = MaxPadding_DefaultValue = 0;
			GridLineWidth = GridLineWidth_DefaultValue = 1;
			TickPixelInterval = TickPixelInterval_DefaultValue = 72;
			StartOnTick = StartOnTick_DefaultValue = true;
			EndOnTick = EndOnTick_DefaultValue = true;
			Marker = Marker_DefaultValue = null;
			Labels = Labels_DefaultValue = null;
			MinColor = MinColor_DefaultValue = "#e6ebf5";
			MaxColor = MaxColor_DefaultValue = "#003399";
			TickLength = TickLength_DefaultValue = 5;
			ShowInLegend = ShowInLegend_DefaultValue = true;
			AllowDecimals = AllowDecimals_DefaultValue = true;
			DataClassColor = DataClassColor_DefaultValue = "tween";
			DataClasses = DataClasses_DefaultValue = new List<ColorAxisDataClasses>();
			Max = Max_DefaultValue = null;
			Min = Min_DefaultValue = null;
			GridLineColor = GridLineColor_DefaultValue = "#e6e6e6";
			TickInterval = TickInterval_DefaultValue = null;
			Stops = Stops_DefaultValue = new List<Stop>();
			Type = Type_DefaultValue = "linear";
			Reversed = Reversed_DefaultValue = null;
			MinPadding = MinPadding_DefaultValue = 0;
			MaxPadding = MaxPadding_DefaultValue = 0;
			GridLineWidth = GridLineWidth_DefaultValue = 1;
			TickPixelInterval = TickPixelInterval_DefaultValue = 72;
			StartOnTick = StartOnTick_DefaultValue = true;
			EndOnTick = EndOnTick_DefaultValue = true;
			Marker = Marker_DefaultValue = "";
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Duration = Duration_DefaultValue = 50;
			Color = Color_DefaultValue = "#999999";
			Labels = Labels_DefaultValue = "";
			Overflow = Overflow_DefaultValue = "justify";
			Rotation = Rotation_DefaultValue = 0;
			MinColor = MinColor_DefaultValue = "#e6ebf5";
			MaxColor = MaxColor_DefaultValue = "#003399";
			TickLength = TickLength_DefaultValue = 5;
			ShowInLegend = ShowInLegend_DefaultValue = true;
			DataClassColor = DataClassColor_DefaultValue = "tween";
			DataClasses = DataClasses_DefaultValue = new List<ColorAxisDataClasses>();
			Color = Color_DefaultValue = "";
			From = From_DefaultValue = null;
			Name = Name_DefaultValue = "";
			To = To_DefaultValue = null;
			Max = Max_DefaultValue = null;
			Min = Min_DefaultValue = null;
			GridLineColor = GridLineColor_DefaultValue = "#e6e6e6";
			TickInterval = TickInterval_DefaultValue = null;
			Stops = Stops_DefaultValue = new List<Stop>();
			Type = Type_DefaultValue = "linear";
			Reversed = Reversed_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Padding of the min value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer.
		/// </summary>
		public double? MinPadding { get; set; }
		private double? MinPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding of the max value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer.
		/// </summary>
		public double? MaxPadding { get; set; }
		private double? MaxPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the grid lines extending from the axis across thegradient of a scalar color axis.
		/// </summary>
		public double? GridLineWidth { get; set; }
		private double? GridLineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// If [tickInterval](#colorAxis.tickInterval) is `null` this optionsets the approximate pixel interval of the tick marks.
		/// </summary>
		public double? TickPixelInterval { get; set; }
		private double? TickPixelInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to start on a tick. Use this option withthe `maxPadding` option to control the axis start.
		/// </summary>
		public bool? StartOnTick { get; set; }
		private bool? StartOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to end on a tick. Use this option withthe [maxPadding](#colorAxis.maxPadding) option to control the axisend.
		/// </summary>
		public bool? EndOnTick { get; set; }
		private bool? EndOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// The triangular marker on a scalar color axis that points to thevalue of the hovered area. To disable the marker, set `marker:null`.
		/// </summary>
		public ColorAxisMarker Marker { get; set; }
		private ColorAxisMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// The axis labels show the number for each tick.For more live examples on label options, see [xAxis.labels in theHighcharts API.](/highcharts#xAxis.labels)
		/// </summary>
		public ColorAxisLabels Labels { get; set; }
		private ColorAxisLabels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color to represent the minimum of the color axis. Unless [dataClasses](#colorAxis.dataClasses) or [stops](#colorAxis.stops) are set, the gradientstarts at this value.If dataClasses are set, the color is based on minColor and maxColorunless a color is set for each data class, or the [dataClassColor](#colorAxis.dataClassColor) is set.
		/// </summary>
		public string MinColor { get; set; }
		private string MinColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color to represent the maximum of the color axis. Unless [dataClasses](#colorAxis.dataClasses) or [stops](#colorAxis.stops) are set, the gradientends at this value.If dataClasses are set, the color is based on minColor and maxColorunless a color is set for each data class, or the [dataClassColor](#colorAxis.dataClassColor) is set.
		/// </summary>
		public string MaxColor { get; set; }
		private string MaxColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel length of the main tick marks on the color axis.
		/// </summary>
		public ColorAxisTickLength TickLength { get; set; }
		private ColorAxisTickLength TickLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display the colorAxis in the legend.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to allow decimals on the color axis.
		/// </summary>
		public bool? AllowDecimals { get; set; }
		private bool? AllowDecimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// Determines how to set each data class' color if no individual coloris set. The default value, `tween`, computes intermediate colorsbetween `minColor` and `maxColor`. The other possible value, `category`,pulls colors from the global or chart specific [colors](#colors)array.
		/// </summary>
		public string DataClassColor { get; set; }
		private string DataClassColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data classes or ranges for the choropleth map. If nonegiven, the color axis is scalar and values are distributed as a gradientbetween the minimum and maximum colors.
		/// </summary>
		public List<ColorAxisDataClasses> DataClasses { get; set; }
		private List<ColorAxisDataClasses> DataClasses_DefaultValue { get; set; }
		 

		/// <summary>
		/// The maximum value of the axis in terms of map point values. If `null`,the max value is automatically calculated. If the `endOnTick` optionis true, the max value might be rounded up.
		/// </summary>
		public double? Max { get; set; }
		private double? Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum value of the axis in terms of map point values. If `null`,the min value is automatically calculated. If the `startOnTick`option is true, the min value might be rounded down.
		/// </summary>
		public double? Min { get; set; }
		private double? Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the grid lines extending from the axis across the gradient.
		/// </summary>
		public string GridLineColor { get; set; }
		private string GridLineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The interval of the tick marks in axis units. When `null`, the tickinterval is computed to approximately follow the `tickPixelInterval`.
		/// </summary>
		public double? TickInterval { get; set; }
		private double? TickInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color stops for the gradient of a scalar color axis. Use this incases where a linear gradient between a `minColor` and `maxColor`is not sufficient. The stops is an array of tuples, where the firstitem is a float between 0 and 1 assigning the relative position inthe gradient, and the second item is the color.
		/// </summary>
		public List<Stop> Stops { get; set; }
		private List<Stop> Stops_DefaultValue { get; set; }
		 

		/// <summary>
		/// The type of interpolation to use for the color axis. Can be `linear`or `logarithmic`.
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to reverse the axis so that the highest number is closestto the origin. Defaults to `false` in a horizontal legend and `true`in a vertical legend, where the smallest value starts on top.
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding of the min value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer.
		/// </summary>
		public double? MinPadding { get; set; }
		private double? MinPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding of the max value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer.
		/// </summary>
		public double? MaxPadding { get; set; }
		private double? MaxPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the grid lines extending from the axis across thegradient of a scalar color axis.
		/// </summary>
		public double? GridLineWidth { get; set; }
		private double? GridLineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// If [tickInterval](#colorAxis.tickInterval) is `null` this optionsets the approximate pixel interval of the tick marks.
		/// </summary>
		public double? TickPixelInterval { get; set; }
		private double? TickPixelInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to start on a tick. Use this option withthe `maxPadding` option to control the axis start.
		/// </summary>
		public bool? StartOnTick { get; set; }
		private bool? StartOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to end on a tick. Use this option withthe [maxPadding](#colorAxis.maxPadding) option to control the axisend.
		/// </summary>
		public bool? EndOnTick { get; set; }
		private bool? EndOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// The triangular marker on a scalar color axis that points to thevalue of the hovered area. To disable the marker, set `marker:null`.
		/// </summary>
		public ColorAxisMarker Marker { get; set; }
		private ColorAxisMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// Animation for the marker as it moves between values. Set to `false`to disable animation. Defaults to `{ duration: 50 }`.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColorAxisDuration Duration { get; set; }
		private ColorAxisDuration Duration_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the marker.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The axis labels show the number for each tick.For more live examples on label options, see [xAxis.labels in theHighcharts API.](/highcharts#xAxis.labels)
		/// </summary>
		public ColorAxisLabels Labels { get; set; }
		private ColorAxisLabels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to handle overflowing labels on horizontal color axis. Can beundefined or "justify". If "justify", labels will not renderoutside the legend area. If there is room to move it, it will bealigned to the edge, else it will be removed.
		/// </summary>
		public string Overflow { get; set; }
		private string Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColorAxisRotation Rotation { get; set; }
		private ColorAxisRotation Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color to represent the minimum of the color axis. Unless [dataClasses](#colorAxis.dataClasses) or [stops](#colorAxis.stops) are set, the gradientstarts at this value.If dataClasses are set, the color is based on minColor and maxColorunless a color is set for each data class, or the [dataClassColor](#colorAxis.dataClassColor) is set.
		/// </summary>
		public string MinColor { get; set; }
		private string MinColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color to represent the maximum of the color axis. Unless [dataClasses](#colorAxis.dataClasses) or [stops](#colorAxis.stops) are set, the gradientends at this value.If dataClasses are set, the color is based on minColor and maxColorunless a color is set for each data class, or the [dataClassColor](#colorAxis.dataClassColor) is set.
		/// </summary>
		public string MaxColor { get; set; }
		private string MaxColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel length of the main tick marks on the color axis.
		/// </summary>
		public ColorAxisTickLength TickLength { get; set; }
		private ColorAxisTickLength TickLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display the colorAxis in the legend.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// Determines how to set each data class' color if no individual coloris set. The default value, `tween`, computes intermediate colorsbetween `minColor` and `maxColor`. The other possible value, `category`,pulls colors from the global or chart specific [colors](#colors)array.
		/// </summary>
		public string DataClassColor { get; set; }
		private string DataClassColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data classes or ranges for the choropleth map. If nonegiven, the color axis is scalar and values are distributed as a gradientbetween the minimum and maximum colors.
		/// </summary>
		public List<ColorAxisDataClasses> DataClasses { get; set; }
		private List<ColorAxisDataClasses> DataClasses_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of each data class. If not set, the color is pulled fromthe global or chart-specific [colors](#colors) array. In styled mode, this option is ignored. Instead, use colors defined inCSS.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The start of the value range that the data class represents, relatingto the point value.
		/// </summary>
		public double? From { get; set; }
		private double? From_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the data class as it appears in the legend. If no nameis given, it is automatically created based on the `from` and `to`values. For full programmatic control, [legend.labelFormatter](#legend.labelFormatter) can be used. In the formatter, `this.from` and `this.to` can be accessed.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// The end of the value range that the data class represents, relatingto the point value.
		/// </summary>
		public double? To { get; set; }
		private double? To_DefaultValue { get; set; }
		 

		/// <summary>
		/// The maximum value of the axis in terms of map point values. If `null`,the max value is automatically calculated. If the `endOnTick` optionis true, the max value might be rounded up.
		/// </summary>
		public double? Max { get; set; }
		private double? Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum value of the axis in terms of map point values. If `null`,the min value is automatically calculated. If the `startOnTick`option is true, the min value might be rounded down.
		/// </summary>
		public double? Min { get; set; }
		private double? Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the grid lines extending from the axis across the gradient.
		/// </summary>
		public string GridLineColor { get; set; }
		private string GridLineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The interval of the tick marks in axis units. When `null`, the tickinterval is computed to approximately follow the `tickPixelInterval`.
		/// </summary>
		public double? TickInterval { get; set; }
		private double? TickInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color stops for the gradient of a scalar color axis. Use this incases where a linear gradient between a `minColor` and `maxColor`is not sufficient. The stops is an array of tuples, where the firstitem is a float between 0 and 1 assigning the relative position inthe gradient, and the second item is the color.
		/// </summary>
		public List<Stop> Stops { get; set; }
		private List<Stop> Stops_DefaultValue { get; set; }
		 

		/// <summary>
		/// The type of interpolation to use for the color axis. Can be `linear`or `logarithmic`.
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to reverse the axis so that the highest number is closestto the origin. Defaults to `false` in a horizontal legend and `true`in a vertical legend, where the smallest value starts on top.
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (MinPadding != MinPadding_DefaultValue) h.Add("minPadding",MinPadding);
			if (MaxPadding != MaxPadding_DefaultValue) h.Add("maxPadding",MaxPadding);
			if (GridLineWidth != GridLineWidth_DefaultValue) h.Add("gridLineWidth",GridLineWidth);
			if (TickPixelInterval != TickPixelInterval_DefaultValue) h.Add("tickPixelInterval",TickPixelInterval);
			if (StartOnTick != StartOnTick_DefaultValue) h.Add("startOnTick",StartOnTick);
			if (EndOnTick != EndOnTick_DefaultValue) h.Add("endOnTick",EndOnTick);
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (MinColor != MinColor_DefaultValue) h.Add("minColor",MinColor);
			if (MaxColor != MaxColor_DefaultValue) h.Add("maxColor",MaxColor);
			if (TickLength != TickLength_DefaultValue) h.Add("tickLength",TickLength);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (AllowDecimals != AllowDecimals_DefaultValue) h.Add("allowDecimals",AllowDecimals);
			if (DataClassColor != DataClassColor_DefaultValue) h.Add("dataClassColor",DataClassColor);
			if (DataClasses != DataClasses_DefaultValue) h.Add("dataClasses", HashifyList(DataClasses));
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (GridLineColor != GridLineColor_DefaultValue) h.Add("gridLineColor",GridLineColor);
			if (TickInterval != TickInterval_DefaultValue) h.Add("tickInterval",TickInterval);
			if (Stops.Any()) h.Add("stops", GetLists(Stops));
			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (MinPadding != MinPadding_DefaultValue) h.Add("minPadding",MinPadding);
			if (MaxPadding != MaxPadding_DefaultValue) h.Add("maxPadding",MaxPadding);
			if (GridLineWidth != GridLineWidth_DefaultValue) h.Add("gridLineWidth",GridLineWidth);
			if (TickPixelInterval != TickPixelInterval_DefaultValue) h.Add("tickPixelInterval",TickPixelInterval);
			if (StartOnTick != StartOnTick_DefaultValue) h.Add("startOnTick",StartOnTick);
			if (EndOnTick != EndOnTick_DefaultValue) h.Add("endOnTick",EndOnTick);
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Duration != Duration_DefaultValue) h.Add("duration",Duration);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (Overflow != Overflow_DefaultValue) h.Add("overflow",Overflow);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (MinColor != MinColor_DefaultValue) h.Add("minColor",MinColor);
			if (MaxColor != MaxColor_DefaultValue) h.Add("maxColor",MaxColor);
			if (TickLength != TickLength_DefaultValue) h.Add("tickLength",TickLength);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (DataClassColor != DataClassColor_DefaultValue) h.Add("dataClassColor",DataClassColor);
			if (DataClasses != DataClasses_DefaultValue) h.Add("dataClasses", HashifyList(DataClasses));
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (From != From_DefaultValue) h.Add("from",From);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (To != To_DefaultValue) h.Add("to",To);
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (GridLineColor != GridLineColor_DefaultValue) h.Add("gridLineColor",GridLineColor);
			if (TickInterval != TickInterval_DefaultValue) h.Add("tickInterval",TickInterval);
			if (Stops.Any()) h.Add("stops", GetLists(Stops));
			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			

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