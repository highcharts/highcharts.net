using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class LangNavigationPopup  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangNavigationPopup()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string AddButton { get; set; }
		private string AddButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Algorithm { get; set; }
		private string Algorithm_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ArrowInfinityLine { get; set; }
		private string ArrowInfinityLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ArrowRay { get; set; }
		private string ArrowRay_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ArrowSegment { get; set; }
		private string ArrowSegment_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Average { get; set; }
		private string Average_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Background { get; set; }
		private string Background_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BackgroundColors { get; set; }
		private string BackgroundColors_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BorderWidth { get; set; }
		private string BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BottomBand { get; set; }
		private string BottomBand_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Circle { get; set; }
		private string Circle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ClearFilter { get; set; }
		private string ClearFilter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Connector { get; set; }
		private string Connector_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Crooked3 { get; set; }
		private string Crooked3_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Crooked5 { get; set; }
		private string Crooked5_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string CrosshairX { get; set; }
		private string CrosshairX_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string CrosshairY { get; set; }
		private string CrosshairY_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Decimals { get; set; }
		private string Decimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Deviation { get; set; }
		private string Deviation_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string EditButton { get; set; }
		private string EditButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Elliott3 { get; set; }
		private string Elliott3_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Elliott5 { get; set; }
		private string Elliott5_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Ellipse { get; set; }
		private string Ellipse_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Factor { get; set; }
		private string Factor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FastAvgPeriod { get; set; }
		private string FastAvgPeriod_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Fibonacci { get; set; }
		private string Fibonacci_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FibonacciTimeZones { get; set; }
		private string FibonacciTimeZones_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Fill { get; set; }
		private string Fill_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Flags { get; set; }
		private string Flags_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FontSize { get; set; }
		private string FontSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Height { get; set; }
		private string Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string HighIndex { get; set; }
		private string HighIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string HorizontalLine { get; set; }
		private string HorizontalLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Increment { get; set; }
		private string Increment_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Index { get; set; }
		private string Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// Configure the aliases for indicator names.
		/// </summary>
		public LangNavigationPopupIndicatorAliases IndicatorAliases { get; set; }
		private LangNavigationPopupIndicatorAliases IndicatorAliases_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string InfinityLine { get; set; }
		private string InfinityLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string InitialAccelerationFactor { get; set; }
		private string InitialAccelerationFactor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string InnerBackground { get; set; }
		private string InnerBackground_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Label { get; set; }
		private string Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LabelOptions { get; set; }
		private string LabelOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Labels { get; set; }
		private string Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Line { get; set; }
		private string Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Lines { get; set; }
		private string Lines_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LongPeriod { get; set; }
		private string LongPeriod_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LowIndex { get; set; }
		private string LowIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MaxAccelerationFactor { get; set; }
		private string MaxAccelerationFactor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Measure { get; set; }
		private string Measure_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MeasureX { get; set; }
		private string MeasureX_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MeasureXY { get; set; }
		private string MeasureXY_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MeasureY { get; set; }
		private string MeasureY_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Multiplier { get; set; }
		private string Multiplier_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MultiplierATR { get; set; }
		private string MultiplierATR_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string NoFilterMatch { get; set; }
		private string NoFilterMatch_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string OuterBackground { get; set; }
		private string OuterBackground_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ParallelChannel { get; set; }
		private string ParallelChannel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Period { get; set; }
		private string Period_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PeriodATR { get; set; }
		private string PeriodATR_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Periods { get; set; }
		private string Periods_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PeriodSenkouSpanB { get; set; }
		private string PeriodSenkouSpanB_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PeriodTenkan { get; set; }
		private string PeriodTenkan_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Pitchfork { get; set; }
		private string Pitchfork_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Ranges { get; set; }
		private string Ranges_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Ray { get; set; }
		private string Ray_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Rectangle { get; set; }
		private string Rectangle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string RemoveButton { get; set; }
		private string RemoveButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SaveButton { get; set; }
		private string SaveButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SearchIndicators { get; set; }
		private string SearchIndicators_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Segment { get; set; }
		private string Segment_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<Series> Series { get; set; }
		private List<Series> Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ShapeOptions { get; set; }
		private string ShapeOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Shapes { get; set; }
		private string Shapes_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ShortPeriod { get; set; }
		private string ShortPeriod_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SignalPeriod { get; set; }
		private string SignalPeriod_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SimpleShapes { get; set; }
		private string SimpleShapes_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SlowAvgPeriod { get; set; }
		private string SlowAvgPeriod_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string StandardDeviation { get; set; }
		private string StandardDeviation_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Stroke { get; set; }
		private string Stroke_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string StrokeWidth { get; set; }
		private string StrokeWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TimeCycles { get; set; }
		private string TimeCycles_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Title { get; set; }
		private string Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TopBand { get; set; }
		private string TopBand_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Tunnel { get; set; }
		private string Tunnel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TypeOptions { get; set; }
		private string TypeOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string VerticalArrow { get; set; }
		private string VerticalArrow_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string VerticalCounter { get; set; }
		private string VerticalCounter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string VerticalLabel { get; set; }
		private string VerticalLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string VerticalLine { get; set; }
		private string VerticalLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Volume { get; set; }
		private string Volume_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? XAxisUnit { get; set; }
		private double? XAxisUnit_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (AddButton != null) h.Add("addButton",AddButton);
			if (Algorithm != null) h.Add("algorithm",Algorithm);
			if (ArrowInfinityLine != null) h.Add("arrowInfinityLine",ArrowInfinityLine);
			if (ArrowRay != null) h.Add("arrowRay",ArrowRay);
			if (ArrowSegment != null) h.Add("arrowSegment",ArrowSegment);
			if (Average != null) h.Add("average",Average);
			if (Background != null) h.Add("background",Background);
			if (BackgroundColor != null) h.Add("backgroundColor",BackgroundColor);
			if (BackgroundColors != null) h.Add("backgroundColors",BackgroundColors);
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderRadius != null) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (BottomBand != null) h.Add("bottomBand",BottomBand);
			if (Circle != null) h.Add("circle",Circle);
			if (ClearFilter != null) h.Add("clearFilter",ClearFilter);
			if (Color != null) h.Add("color",Color);
			if (Connector != null) h.Add("connector",Connector);
			if (Crooked3 != null) h.Add("crooked3",Crooked3);
			if (Crooked5 != null) h.Add("crooked5",Crooked5);
			if (CrosshairX != null) h.Add("crosshairX",CrosshairX);
			if (CrosshairY != null) h.Add("crosshairY",CrosshairY);
			if (Decimals != null) h.Add("decimals",Decimals);
			if (Deviation != null) h.Add("deviation",Deviation);
			if (EditButton != null) h.Add("editButton",EditButton);
			if (Elliott3 != null) h.Add("elliott3",Elliott3);
			if (Elliott5 != null) h.Add("elliott5",Elliott5);
			if (Ellipse != null) h.Add("ellipse",Ellipse);
			if (Factor != null) h.Add("factor",Factor);
			if (FastAvgPeriod != null) h.Add("fastAvgPeriod",FastAvgPeriod);
			if (Fibonacci != null) h.Add("fibonacci",Fibonacci);
			if (FibonacciTimeZones != null) h.Add("fibonacciTimeZones",FibonacciTimeZones);
			if (Fill != null) h.Add("fill",Fill);
			if (Flags != null) h.Add("flags",Flags);
			if (FontSize != null) h.Add("fontSize",FontSize);
			if (Format != null) h.Add("format",Format);
			if (Height != null) h.Add("height",Height);
			if (HighIndex != null) h.Add("highIndex",HighIndex);
			if (HorizontalLine != null) h.Add("horizontalLine",HorizontalLine);
			if (Increment != null) h.Add("increment",Increment);
			if (Index != null) h.Add("index",Index);
			if (IndicatorAliases != null) h.Add("indicatorAliases",IndicatorAliases.ToHashtable(highcharts));
			if (InfinityLine != null) h.Add("infinityLine",InfinityLine);
			if (InitialAccelerationFactor != null) h.Add("initialAccelerationFactor",InitialAccelerationFactor);
			if (InnerBackground != null) h.Add("innerBackground",InnerBackground);
			if (Label != null) h.Add("label",Label);
			if (LabelOptions != null) h.Add("labelOptions",LabelOptions);
			if (Labels != null) h.Add("labels",Labels);
			if (Line != null) h.Add("line",Line);
			if (Lines != null) h.Add("lines",Lines);
			if (LongPeriod != null) h.Add("longPeriod",LongPeriod);
			if (LowIndex != null) h.Add("lowIndex",LowIndex);
			if (MaxAccelerationFactor != null) h.Add("maxAccelerationFactor",MaxAccelerationFactor);
			if (Measure != null) h.Add("measure",Measure);
			if (MeasureX != null) h.Add("measureX",MeasureX);
			if (MeasureXY != null) h.Add("measureXY",MeasureXY);
			if (MeasureY != null) h.Add("measureY",MeasureY);
			if (Multiplier != null) h.Add("multiplier",Multiplier);
			if (MultiplierATR != null) h.Add("multiplierATR",MultiplierATR);
			if (Name != null) h.Add("name",Name);
			if (NoFilterMatch != null) h.Add("noFilterMatch",NoFilterMatch);
			if (OuterBackground != null) h.Add("outerBackground",OuterBackground);
			if (Padding != null) h.Add("padding",Padding);
			if (ParallelChannel != null) h.Add("parallelChannel",ParallelChannel);
			if (Period != null) h.Add("period",Period);
			if (PeriodATR != null) h.Add("periodATR",PeriodATR);
			if (Periods != null) h.Add("periods",Periods);
			if (PeriodSenkouSpanB != null) h.Add("periodSenkouSpanB",PeriodSenkouSpanB);
			if (PeriodTenkan != null) h.Add("periodTenkan",PeriodTenkan);
			if (Pitchfork != null) h.Add("pitchfork",Pitchfork);
			if (Ranges != null) h.Add("ranges",Ranges);
			if (Ray != null) h.Add("ray",Ray);
			if (Rectangle != null) h.Add("rectangle",Rectangle);
			if (RemoveButton != null) h.Add("removeButton",RemoveButton);
			if (SaveButton != null) h.Add("saveButton",SaveButton);
			if (SearchIndicators != null) h.Add("searchIndicators",SearchIndicators);
			if (Segment != null) h.Add("segment",Segment);
			if (Series != null) h.Add("series",Series);
			if (ShapeOptions != null) h.Add("shapeOptions",ShapeOptions);
			if (Shapes != null) h.Add("shapes",Shapes);
			if (ShortPeriod != null) h.Add("shortPeriod",ShortPeriod);
			if (SignalPeriod != null) h.Add("signalPeriod",SignalPeriod);
			if (SimpleShapes != null) h.Add("simpleShapes",SimpleShapes);
			if (SlowAvgPeriod != null) h.Add("slowAvgPeriod",SlowAvgPeriod);
			if (StandardDeviation != null) h.Add("standardDeviation",StandardDeviation);
			if (Stroke != null) h.Add("stroke",Stroke);
			if (StrokeWidth != null) h.Add("strokeWidth",StrokeWidth);
			if (Style != null) h.Add("style",Style);
			if (TimeCycles != null) h.Add("timeCycles",TimeCycles);
			if (Title != null) h.Add("title",Title);
			if (TopBand != null) h.Add("topBand",TopBand);
			if (Tunnel != null) h.Add("tunnel",Tunnel);
			if (TypeOptions != null) h.Add("typeOptions",TypeOptions);
			if (VerticalArrow != null) h.Add("verticalArrow",VerticalArrow);
			if (VerticalCounter != null) h.Add("verticalCounter",VerticalCounter);
			if (VerticalLabel != null) h.Add("verticalLabel",VerticalLabel);
			if (VerticalLine != null) h.Add("verticalLine",VerticalLine);
			if (Volume != null) h.Add("volume",Volume);
			if (XAxisUnit != null) h.Add("xAxisUnit",XAxisUnit);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}