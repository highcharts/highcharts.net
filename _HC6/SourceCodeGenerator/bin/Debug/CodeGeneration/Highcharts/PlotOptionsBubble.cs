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
	public partial class PlotOptionsBubble  : BaseObject
	{
		public PlotOptionsBubble()
		{
			Marker = Marker_DefaultValue = null;
			MinSize = MinSize_DefaultValue = "8";
			MaxSize = MaxSize_DefaultValue = "20%";
			SoftThreshold = SoftThreshold_DefaultValue = false;
			States = States_DefaultValue = null;
			Tooltip = Tooltip_DefaultValue = null;
			TurboThreshold = TurboThreshold_DefaultValue = 0;
			ZThreshold = ZThreshold_DefaultValue = 0;
			ZoneAxis = ZoneAxis_DefaultValue = z;
			DisplayNegative = DisplayNegative_DefaultValue = true;
			NegativeColor = NegativeColor_DefaultValue = "null";
			SizeBy = SizeBy_DefaultValue = "area";
			SizeByAbsoluteValue = SizeByAbsoluteValue_DefaultValue = false;
			ZMax = ZMax_DefaultValue = null;
			ZMin = ZMin_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = "";
			Formatter = Formatter_DefaultValue = "";
			Inside = Inside_DefaultValue = True;
			VerticalAlign = VerticalAlign_DefaultValue = middle;
			Marker = Marker_DefaultValue = "";
			LineColor = LineColor_DefaultValue = "";
			LineWidth = LineWidth_DefaultValue = 1;
			Radius = Radius_DefaultValue = "";
			States = States_DefaultValue = "";
			Hover = Hover_DefaultValue = "";
			RadiusPlus = RadiusPlus_DefaultValue = 0;
			Symbol = Symbol_DefaultValue = "circle";
			MinSize = MinSize_DefaultValue = "8";
			MaxSize = MaxSize_DefaultValue = "20%";
			SoftThreshold = SoftThreshold_DefaultValue = false;
			States = States_DefaultValue = "";
			Hover = Hover_DefaultValue = "";
			Halo = Halo_DefaultValue = "";
			Size = Size_DefaultValue = 5;
			Tooltip = Tooltip_DefaultValue = "";
			PointFormat = PointFormat_DefaultValue = ({point.x}, {point.y}), Size: {point.z};
			TurboThreshold = TurboThreshold_DefaultValue = 0;
			ZThreshold = ZThreshold_DefaultValue = 0;
			ZoneAxis = ZoneAxis_DefaultValue = z;
			DisplayNegative = DisplayNegative_DefaultValue = true;
			NegativeColor = NegativeColor_DefaultValue = "null";
			SizeBy = SizeBy_DefaultValue = "area";
			SizeByAbsoluteValue = SizeByAbsoluteValue_DefaultValue = false;
			ZMax = ZMax_DefaultValue = null;
			ZMin = ZMin_DefaultValue = null;
			LineColor = LineColor_DefaultValue = "";
			LineWidth = LineWidth_DefaultValue = 1;
			States = States_DefaultValue = "";
			Hover = Hover_DefaultValue = "";
			RadiusPlus = RadiusPlus_DefaultValue = 0;
			Symbol = Symbol_DefaultValue = "circle";
			
		}	
		

		/// <summary>
		/// Options for the point markers of line-like series. Properties like`fillColor`, `lineColor` and `lineWidth` define the visual appearanceof the markers. Other series types, like column series, don't havemarkers, but have visual options on the series level instead.In styled mode, the markers can be styled with the `.highcharts-point`, `.highcharts-point-hover` and `.highcharts-point-select`class names.
		/// </summary>
		public PlotOptionsBubbleMarker Marker { get; set; }
		private PlotOptionsBubbleMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// Minimum bubble size. Bubbles will automatically size between the`minSize` and `maxSize` to reflect the `z` value of each bubble.Can be either pixels (when no unit is given), or a percentage ofthe smallest one of the plot width and height.
		/// </summary>
		public string MinSize { get; set; }
		private string MinSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Maximum bubble size. Bubbles will automatically size between the`minSize` and `maxSize` to reflect the `z` value of each bubble.Can be either pixels (when no unit is given), or a percentage ofthe smallest one of the plot width and height.
		/// </summary>
		public string MaxSize { get; set; }
		private string MaxSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this is true, the series will not cause the Y axis to crossthe zero plane (or [threshold](#plotOptions.series.threshold) option)unless the data actually crosses the plane.For example, if `softThreshold` is `false`, a series of 0, 1, 2,3 will make the Y axis show negative values according to the `minPadding`option. If `softThreshold` is `true`, the Y axis starts at 0.
		/// </summary>
		public bool? SoftThreshold { get; set; }
		private bool? SoftThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleStates States { get; set; }
		private PlotOptionsBubbleStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleTooltip Tooltip { get; set; }
		private PlotOptionsBubbleTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleTurboThreshold TurboThreshold { get; set; }
		private PlotOptionsBubbleTurboThreshold TurboThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// When [displayNegative](#plotOptions.bubble.displayNegative) is `false`,bubbles with lower Z values are skipped. When `displayNegative`is `true` and a [negativeColor](#plotOptions.bubble.negativeColor)is given, points with lower Z is colored.
		/// </summary>
		public double? ZThreshold { get; set; }
		private double? ZThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleZoneAxis ZoneAxis { get; set; }
		private PlotOptionsBubbleZoneAxis ZoneAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display negative sized bubbles. The threshold is givenby the [zThreshold](#plotOptions.bubble.zThreshold) option, and negativebubbles can be visualized by setting [negativeColor](#plotOptions.bubble.negativeColor).
		/// </summary>
		public bool? DisplayNegative { get; set; }
		private bool? DisplayNegative_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a point's Z value is below the [zThreshold](#plotOptions.bubble.zThreshold) setting, this color is used.
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the bubble's value should be represented by the area or thewidth of the bubble. The default, `area`, corresponds best to thehuman perception of the size of each bubble.
		/// </summary>
		public string SizeBy { get; set; }
		private string SizeBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this is true, the absolute value of z determines the size ofthe bubble. This means that with the default `zThreshold` of 0, abubble of value -1 will have the same size as a bubble of value 1,while a bubble of value 0 will have a smaller size according to`minSize`.
		/// </summary>
		public bool? SizeByAbsoluteValue { get; set; }
		private bool? SizeByAbsoluteValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum for the Z value range. Defaults to the highest Z valuein the data.
		/// </summary>
		public double? ZMax { get; set; }
		private double? ZMax_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum for the Z value range. Defaults to the lowest Z valuein the data.
		/// </summary>
		public double? ZMin { get; set; }
		private double? ZMin_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleDataLabels DataLabels { get; set; }
		private PlotOptionsBubbleDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleFormatter Formatter { get; set; }
		private PlotOptionsBubbleFormatter Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleInside Inside { get; set; }
		private PlotOptionsBubbleInside Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsBubbleVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the point markers of line-like series. Properties like`fillColor`, `lineColor` and `lineWidth` define the visual appearanceof the markers. Other series types, like column series, don't havemarkers, but have visual options on the series level instead.In styled mode, the markers can be styled with the `.highcharts-point`, `.highcharts-point-hover` and `.highcharts-point-select`class names.
		/// </summary>
		public PlotOptionsBubbleMarker Marker { get; set; }
		private PlotOptionsBubbleMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleLineColor LineColor { get; set; }
		private PlotOptionsBubbleLineColor LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleLineWidth LineWidth { get; set; }
		private PlotOptionsBubbleLineWidth LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// In bubble charts, the radius is overridden and determined based on the point's data value.
		/// </summary>
		public PlotOptionsBubbleRadius Radius { get; set; }
		private PlotOptionsBubbleRadius Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleStates States { get; set; }
		private PlotOptionsBubbleStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleHover Hover { get; set; }
		private PlotOptionsBubbleHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleRadiusPlus RadiusPlus { get; set; }
		private PlotOptionsBubbleRadiusPlus RadiusPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// A predefined shape or symbol for the marker. Possible values are"circle", "square", "diamond", "triangle" and "triangle-down".Additionally, the URL to a graphic can be given on the form`url(graphic.png)`. Note that for the image to be applied to exportedcharts, its URL needs to be accessible by the export server.Custom callbacks for symbol path generation can also be added to`Highcharts.SVGRenderer.prototype.symbols`. The callback is thenused by its method name, as shown in the demo.
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// Minimum bubble size. Bubbles will automatically size between the`minSize` and `maxSize` to reflect the `z` value of each bubble.Can be either pixels (when no unit is given), or a percentage ofthe smallest one of the plot width and height.
		/// </summary>
		public string MinSize { get; set; }
		private string MinSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Maximum bubble size. Bubbles will automatically size between the`minSize` and `maxSize` to reflect the `z` value of each bubble.Can be either pixels (when no unit is given), or a percentage ofthe smallest one of the plot width and height.
		/// </summary>
		public string MaxSize { get; set; }
		private string MaxSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this is true, the series will not cause the Y axis to crossthe zero plane (or [threshold](#plotOptions.series.threshold) option)unless the data actually crosses the plane.For example, if `softThreshold` is `false`, a series of 0, 1, 2,3 will make the Y axis show negative values according to the `minPadding`option. If `softThreshold` is `true`, the Y axis starts at 0.
		/// </summary>
		public bool? SoftThreshold { get; set; }
		private bool? SoftThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleStates States { get; set; }
		private PlotOptionsBubbleStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleHover Hover { get; set; }
		private PlotOptionsBubbleHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleHalo Halo { get; set; }
		private PlotOptionsBubbleHalo Halo_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleSize Size { get; set; }
		private PlotOptionsBubbleSize Size_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleTooltip Tooltip { get; set; }
		private PlotOptionsBubbleTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubblePointFormat PointFormat { get; set; }
		private PlotOptionsBubblePointFormat PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleTurboThreshold TurboThreshold { get; set; }
		private PlotOptionsBubbleTurboThreshold TurboThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// When [displayNegative](#plotOptions.bubble.displayNegative) is `false`,bubbles with lower Z values are skipped. When `displayNegative`is `true` and a [negativeColor](#plotOptions.bubble.negativeColor)is given, points with lower Z is colored.
		/// </summary>
		public double? ZThreshold { get; set; }
		private double? ZThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleZoneAxis ZoneAxis { get; set; }
		private PlotOptionsBubbleZoneAxis ZoneAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display negative sized bubbles. The threshold is givenby the [zThreshold](#plotOptions.bubble.zThreshold) option, and negativebubbles can be visualized by setting [negativeColor](#plotOptions.bubble.negativeColor).
		/// </summary>
		public bool? DisplayNegative { get; set; }
		private bool? DisplayNegative_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a point's Z value is below the [zThreshold](#plotOptions.bubble.zThreshold) setting, this color is used.
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the bubble's value should be represented by the area or thewidth of the bubble. The default, `area`, corresponds best to thehuman perception of the size of each bubble.
		/// </summary>
		public string SizeBy { get; set; }
		private string SizeBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this is true, the absolute value of z determines the size ofthe bubble. This means that with the default `zThreshold` of 0, abubble of value -1 will have the same size as a bubble of value 1,while a bubble of value 0 will have a smaller size according to`minSize`.
		/// </summary>
		public bool? SizeByAbsoluteValue { get; set; }
		private bool? SizeByAbsoluteValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum for the Z value range. Defaults to the highest Z valuein the data.
		/// </summary>
		public double? ZMax { get; set; }
		private double? ZMax_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum for the Z value range. Defaults to the lowest Z valuein the data.
		/// </summary>
		public double? ZMin { get; set; }
		private double? ZMin_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleLineColor LineColor { get; set; }
		private PlotOptionsBubbleLineColor LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleLineWidth LineWidth { get; set; }
		private PlotOptionsBubbleLineWidth LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleStates States { get; set; }
		private PlotOptionsBubbleStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleHover Hover { get; set; }
		private PlotOptionsBubbleHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleRadiusPlus RadiusPlus { get; set; }
		private PlotOptionsBubbleRadiusPlus RadiusPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// A predefined shape or symbol for the marker. Possible values are"circle", "square", "diamond", "triangle" and "triangle-down".Additionally, the URL to a graphic can be given on the form`url(graphic.png)`. Note that for the image to be applied to exportedcharts, its URL needs to be accessible by the export server.Custom callbacks for symbol path generation can also be added to`Highcharts.SVGRenderer.prototype.symbols`. The callback is thenused by its method name, as shown in the demo.
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (MinSize != MinSize_DefaultValue) h.Add("minSize",MinSize);
			if (MaxSize != MaxSize_DefaultValue) h.Add("maxSize",MaxSize);
			if (SoftThreshold != SoftThreshold_DefaultValue) h.Add("softThreshold",SoftThreshold);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (ZThreshold != ZThreshold_DefaultValue) h.Add("zThreshold",ZThreshold);
			if (ZoneAxis != ZoneAxis_DefaultValue) h.Add("zoneAxis",ZoneAxis);
			if (DisplayNegative != DisplayNegative_DefaultValue) h.Add("displayNegative",DisplayNegative);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (SizeBy != SizeBy_DefaultValue) h.Add("sizeBy",SizeBy);
			if (SizeByAbsoluteValue != SizeByAbsoluteValue_DefaultValue) h.Add("sizeByAbsoluteValue",SizeByAbsoluteValue);
			if (ZMax != ZMax_DefaultValue) h.Add("zMax",ZMax);
			if (ZMin != ZMin_DefaultValue) h.Add("zMin",ZMin);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (RadiusPlus != RadiusPlus_DefaultValue) h.Add("radiusPlus",RadiusPlus);
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (MinSize != MinSize_DefaultValue) h.Add("minSize",MinSize);
			if (MaxSize != MaxSize_DefaultValue) h.Add("maxSize",MaxSize);
			if (SoftThreshold != SoftThreshold_DefaultValue) h.Add("softThreshold",SoftThreshold);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (Halo.IsDirty()) h.Add("halo",Halo.ToHashtable());
			if (Size != Size_DefaultValue) h.Add("size",Size);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (ZThreshold != ZThreshold_DefaultValue) h.Add("zThreshold",ZThreshold);
			if (ZoneAxis != ZoneAxis_DefaultValue) h.Add("zoneAxis",ZoneAxis);
			if (DisplayNegative != DisplayNegative_DefaultValue) h.Add("displayNegative",DisplayNegative);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (SizeBy != SizeBy_DefaultValue) h.Add("sizeBy",SizeBy);
			if (SizeByAbsoluteValue != SizeByAbsoluteValue_DefaultValue) h.Add("sizeByAbsoluteValue",SizeByAbsoluteValue);
			if (ZMax != ZMax_DefaultValue) h.Add("zMax",ZMax);
			if (ZMin != ZMin_DefaultValue) h.Add("zMin",ZMin);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (RadiusPlus != RadiusPlus_DefaultValue) h.Add("radiusPlus",RadiusPlus);
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			

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