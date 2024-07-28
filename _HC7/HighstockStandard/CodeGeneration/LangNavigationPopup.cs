using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class LangNavigationPopup  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangNavigationPopup()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string AddButton { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Algorithm { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ArrowInfinityLine { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ArrowRay { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ArrowSegment { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Average { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Background { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BackgroundColor { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BackgroundColors { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? BorderRadius { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BorderWidth { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BottomBand { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Circle { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ClearFilter { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Connector { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Crooked3 { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Crooked5 { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string CrosshairX { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string CrosshairY { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Decimals { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Deviation { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string EditButton { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Elliott3 { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Elliott5 { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Ellipse { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Factor { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FastAvgPeriod { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Fibonacci { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FibonacciTimeZones { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Fill { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Flags { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FontSize { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Format { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Height { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string HighIndex { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string HorizontalLine { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Increment { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Index { get; set; }
		 

		/// <summary>
		/// Configure the aliases for indicator names.
		/// </summary>
		public LangNavigationPopupIndicatorAliases IndicatorAliases { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string InfinityLine { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string InitialAccelerationFactor { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string InnerBackground { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Label { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LabelOptions { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Labels { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Line { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Lines { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LongPeriod { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LowIndex { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MaxAccelerationFactor { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Measure { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MeasureX { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MeasureXY { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MeasureY { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Multiplier { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MultiplierATR { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Name { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string NoFilterMatch { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string OuterBackground { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Padding { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ParallelChannel { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Period { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PeriodATR { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Periods { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PeriodSenkouSpanB { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PeriodTenkan { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Pitchfork { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Ranges { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Ray { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Rectangle { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string RemoveButton { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SaveButton { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SearchIndicators { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Segment { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<Series> Series { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ShapeOptions { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Shapes { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ShortPeriod { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SignalPeriod { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SimpleShapes { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SlowAvgPeriod { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string StandardDeviation { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Stroke { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string StrokeWidth { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TimeCycles { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Title { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TopBand { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Tunnel { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TypeOptions { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string VerticalArrow { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string VerticalCounter { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string VerticalLabel { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string VerticalLine { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Volume { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? XAxisUnit { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
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
			if (IndicatorAliases != null) h.Add("indicatorAliases",IndicatorAliases.ToHashtable(highstock));
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
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}