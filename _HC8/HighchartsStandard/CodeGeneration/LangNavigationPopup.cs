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
			AddButton = AddButton_DefaultValue = "add";
			Algorithm = Algorithm_DefaultValue = "Algorithm";
			ArrowInfinityLine = ArrowInfinityLine_DefaultValue = "Arrow line";
			ArrowRay = ArrowRay_DefaultValue = "Arrow ray";
			ArrowSegment = ArrowSegment_DefaultValue = "Arrow segment";
			Average = Average_DefaultValue = "Average";
			Background = Background_DefaultValue = "Background";
			BackgroundColor = BackgroundColor_DefaultValue = "Background color";
			BackgroundColors = BackgroundColors_DefaultValue = "Background colors";
			BorderColor = BorderColor_DefaultValue = "Border color";
			BorderRadius = BorderRadius_DefaultValue = null;
			BorderWidth = BorderWidth_DefaultValue = "Border width";
			BottomBand = BottomBand_DefaultValue = "Bottom band";
			Circle = Circle_DefaultValue = "Circle";
			ClearFilter = ClearFilter_DefaultValue = "✕ clear filter";
			Color = Color_DefaultValue = "Color";
			Connector = Connector_DefaultValue = "Connector";
			Crooked3 = Crooked3_DefaultValue = "Crooked 3 line";
			Crooked5 = Crooked5_DefaultValue = "Crooked 5 line";
			CrosshairX = CrosshairX_DefaultValue = "Crosshair X";
			CrosshairY = CrosshairY_DefaultValue = "Crosshair Y";
			Decimals = Decimals_DefaultValue = "Decimals";
			Deviation = Deviation_DefaultValue = "Deviation";
			EditButton = EditButton_DefaultValue = "edit";
			Elliott3 = Elliott3_DefaultValue = "Elliott 3 line";
			Elliott5 = Elliott5_DefaultValue = "Elliott 5 line";
			Ellipse = Ellipse_DefaultValue = "Ellipse";
			Factor = Factor_DefaultValue = "Factor";
			FastAvgPeriod = FastAvgPeriod_DefaultValue = "Fast average period";
			Fibonacci = Fibonacci_DefaultValue = "Fibonacci";
			FibonacciTimeZones = FibonacciTimeZones_DefaultValue = "Fibonacci Time Zones";
			Fill = Fill_DefaultValue = "Fill";
			Flags = Flags_DefaultValue = "Flags";
			FontSize = FontSize_DefaultValue = "Font size";
			Format = Format_DefaultValue = "Text";
			Height = Height_DefaultValue = "Height";
			HighIndex = HighIndex_DefaultValue = "High index";
			HorizontalLine = HorizontalLine_DefaultValue = "Horizontal line";
			Increment = Increment_DefaultValue = "Increment";
			Index = Index_DefaultValue = "Index";
			IndicatorAliases = IndicatorAliases_DefaultValue = new LangNavigationPopupIndicatorAliases();
			InfinityLine = InfinityLine_DefaultValue = "Infinity line";
			InitialAccelerationFactor = InitialAccelerationFactor_DefaultValue = "Initial acceleration factor";
			InnerBackground = InnerBackground_DefaultValue = "Inner background";
			Label = Label_DefaultValue = "Label";
			LabelOptions = LabelOptions_DefaultValue = "Label options";
			Labels = Labels_DefaultValue = "Labels";
			Line = Line_DefaultValue = "Line";
			Lines = Lines_DefaultValue = "Lines";
			LongPeriod = LongPeriod_DefaultValue = "Long period";
			LowIndex = LowIndex_DefaultValue = "Low index";
			MaxAccelerationFactor = MaxAccelerationFactor_DefaultValue = "Max acceleration factor";
			Measure = Measure_DefaultValue = "Measure";
			MeasureX = MeasureX_DefaultValue = "Measure X";
			MeasureXY = MeasureXY_DefaultValue = "Measure XY";
			MeasureY = MeasureY_DefaultValue = "Measure Y";
			Multiplier = Multiplier_DefaultValue = "Multiplier";
			MultiplierATR = MultiplierATR_DefaultValue = "ATR multiplier";
			Name = Name_DefaultValue = "Name";
			NoFilterMatch = NoFilterMatch_DefaultValue = "No match";
			OuterBackground = OuterBackground_DefaultValue = "Outer background";
			Padding = Padding_DefaultValue = "Padding";
			ParallelChannel = ParallelChannel_DefaultValue = "Parallel channel";
			Period = Period_DefaultValue = "Period";
			PeriodATR = PeriodATR_DefaultValue = "ATR period";
			Periods = Periods_DefaultValue = "Periods";
			PeriodSenkouSpanB = PeriodSenkouSpanB_DefaultValue = "Senkou Span B period";
			PeriodTenkan = PeriodTenkan_DefaultValue = "Tenkan period";
			Pitchfork = Pitchfork_DefaultValue = "Pitchfork";
			Ranges = Ranges_DefaultValue = "Ranges";
			Ray = Ray_DefaultValue = "Ray";
			Rectangle = Rectangle_DefaultValue = "Rectangle";
			RemoveButton = RemoveButton_DefaultValue = "remove";
			SaveButton = SaveButton_DefaultValue = "save";
			SearchIndicators = SearchIndicators_DefaultValue = "Search Indicators";
			Segment = Segment_DefaultValue = "Segment";
			Series = Series_DefaultValue = new List<Series>();
			ShapeOptions = ShapeOptions_DefaultValue = "Shape options";
			Shapes = Shapes_DefaultValue = "Shape options";
			ShortPeriod = ShortPeriod_DefaultValue = "Short period";
			SignalPeriod = SignalPeriod_DefaultValue = "Signal period";
			SimpleShapes = SimpleShapes_DefaultValue = "Simple shapes";
			SlowAvgPeriod = SlowAvgPeriod_DefaultValue = "Slow average period";
			StandardDeviation = StandardDeviation_DefaultValue = "Standard deviation";
			Stroke = Stroke_DefaultValue = "Line color";
			StrokeWidth = StrokeWidth_DefaultValue = "Line width";
			Style = Style_DefaultValue = new Hashtable();
			TimeCycles = TimeCycles_DefaultValue = "Time Cycles";
			Title = Title_DefaultValue = "Title";
			TopBand = TopBand_DefaultValue = "Top band";
			Tunnel = Tunnel_DefaultValue = "Tunnel";
			TypeOptions = TypeOptions_DefaultValue = "Details";
			VerticalArrow = VerticalArrow_DefaultValue = "Vertical arrow";
			VerticalCounter = VerticalCounter_DefaultValue = "Vertical counter";
			VerticalLabel = VerticalLabel_DefaultValue = "Vertical label";
			VerticalLine = VerticalLine_DefaultValue = "Vertical line";
			Volume = Volume_DefaultValue = "Volume";
			XAxisUnit = XAxisUnit_DefaultValue = null;
			
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

			if (AddButton != AddButton_DefaultValue) h.Add("addButton",AddButton);
			if (Algorithm != Algorithm_DefaultValue) h.Add("algorithm",Algorithm);
			if (ArrowInfinityLine != ArrowInfinityLine_DefaultValue) h.Add("arrowInfinityLine",ArrowInfinityLine);
			if (ArrowRay != ArrowRay_DefaultValue) h.Add("arrowRay",ArrowRay);
			if (ArrowSegment != ArrowSegment_DefaultValue) h.Add("arrowSegment",ArrowSegment);
			if (Average != Average_DefaultValue) h.Add("average",Average);
			if (Background != Background_DefaultValue) h.Add("background",Background);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BackgroundColors != BackgroundColors_DefaultValue) h.Add("backgroundColors",BackgroundColors);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BottomBand != BottomBand_DefaultValue) h.Add("bottomBand",BottomBand);
			if (Circle != Circle_DefaultValue) h.Add("circle",Circle);
			if (ClearFilter != ClearFilter_DefaultValue) h.Add("clearFilter",ClearFilter);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Connector != Connector_DefaultValue) h.Add("connector",Connector);
			if (Crooked3 != Crooked3_DefaultValue) h.Add("crooked3",Crooked3);
			if (Crooked5 != Crooked5_DefaultValue) h.Add("crooked5",Crooked5);
			if (CrosshairX != CrosshairX_DefaultValue) h.Add("crosshairX",CrosshairX);
			if (CrosshairY != CrosshairY_DefaultValue) h.Add("crosshairY",CrosshairY);
			if (Decimals != Decimals_DefaultValue) h.Add("decimals",Decimals);
			if (Deviation != Deviation_DefaultValue) h.Add("deviation",Deviation);
			if (EditButton != EditButton_DefaultValue) h.Add("editButton",EditButton);
			if (Elliott3 != Elliott3_DefaultValue) h.Add("elliott3",Elliott3);
			if (Elliott5 != Elliott5_DefaultValue) h.Add("elliott5",Elliott5);
			if (Ellipse != Ellipse_DefaultValue) h.Add("ellipse",Ellipse);
			if (Factor != Factor_DefaultValue) h.Add("factor",Factor);
			if (FastAvgPeriod != FastAvgPeriod_DefaultValue) h.Add("fastAvgPeriod",FastAvgPeriod);
			if (Fibonacci != Fibonacci_DefaultValue) h.Add("fibonacci",Fibonacci);
			if (FibonacciTimeZones != FibonacciTimeZones_DefaultValue) h.Add("fibonacciTimeZones",FibonacciTimeZones);
			if (Fill != Fill_DefaultValue) h.Add("fill",Fill);
			if (Flags != Flags_DefaultValue) h.Add("flags",Flags);
			if (FontSize != FontSize_DefaultValue) h.Add("fontSize",FontSize);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (HighIndex != HighIndex_DefaultValue) h.Add("highIndex",HighIndex);
			if (HorizontalLine != HorizontalLine_DefaultValue) h.Add("horizontalLine",HorizontalLine);
			if (Increment != Increment_DefaultValue) h.Add("increment",Increment);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (IndicatorAliases.IsDirty(ref highcharts)) h.Add("indicatorAliases",IndicatorAliases.ToHashtable(ref highcharts));
			if (InfinityLine != InfinityLine_DefaultValue) h.Add("infinityLine",InfinityLine);
			if (InitialAccelerationFactor != InitialAccelerationFactor_DefaultValue) h.Add("initialAccelerationFactor",InitialAccelerationFactor);
			if (InnerBackground != InnerBackground_DefaultValue) h.Add("innerBackground",InnerBackground);
			if (Label != Label_DefaultValue) h.Add("label",Label);
			if (LabelOptions != LabelOptions_DefaultValue) h.Add("labelOptions",LabelOptions);
			if (Labels != Labels_DefaultValue) h.Add("labels",Labels);
			if (Line != Line_DefaultValue) h.Add("line",Line);
			if (Lines != Lines_DefaultValue) h.Add("lines",Lines);
			if (LongPeriod != LongPeriod_DefaultValue) h.Add("longPeriod",LongPeriod);
			if (LowIndex != LowIndex_DefaultValue) h.Add("lowIndex",LowIndex);
			if (MaxAccelerationFactor != MaxAccelerationFactor_DefaultValue) h.Add("maxAccelerationFactor",MaxAccelerationFactor);
			if (Measure != Measure_DefaultValue) h.Add("measure",Measure);
			if (MeasureX != MeasureX_DefaultValue) h.Add("measureX",MeasureX);
			if (MeasureXY != MeasureXY_DefaultValue) h.Add("measureXY",MeasureXY);
			if (MeasureY != MeasureY_DefaultValue) h.Add("measureY",MeasureY);
			if (Multiplier != Multiplier_DefaultValue) h.Add("multiplier",Multiplier);
			if (MultiplierATR != MultiplierATR_DefaultValue) h.Add("multiplierATR",MultiplierATR);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (NoFilterMatch != NoFilterMatch_DefaultValue) h.Add("noFilterMatch",NoFilterMatch);
			if (OuterBackground != OuterBackground_DefaultValue) h.Add("outerBackground",OuterBackground);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (ParallelChannel != ParallelChannel_DefaultValue) h.Add("parallelChannel",ParallelChannel);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (PeriodATR != PeriodATR_DefaultValue) h.Add("periodATR",PeriodATR);
			if (Periods != Periods_DefaultValue) h.Add("periods",Periods);
			if (PeriodSenkouSpanB != PeriodSenkouSpanB_DefaultValue) h.Add("periodSenkouSpanB",PeriodSenkouSpanB);
			if (PeriodTenkan != PeriodTenkan_DefaultValue) h.Add("periodTenkan",PeriodTenkan);
			if (Pitchfork != Pitchfork_DefaultValue) h.Add("pitchfork",Pitchfork);
			if (Ranges != Ranges_DefaultValue) h.Add("ranges",Ranges);
			if (Ray != Ray_DefaultValue) h.Add("ray",Ray);
			if (Rectangle != Rectangle_DefaultValue) h.Add("rectangle",Rectangle);
			if (RemoveButton != RemoveButton_DefaultValue) h.Add("removeButton",RemoveButton);
			if (SaveButton != SaveButton_DefaultValue) h.Add("saveButton",SaveButton);
			if (SearchIndicators != SearchIndicators_DefaultValue) h.Add("searchIndicators",SearchIndicators);
			if (Segment != Segment_DefaultValue) h.Add("segment",Segment);
			if (Series != Series_DefaultValue) h.Add("series",Series);
			if (ShapeOptions != ShapeOptions_DefaultValue) h.Add("shapeOptions",ShapeOptions);
			if (Shapes != Shapes_DefaultValue) h.Add("shapes",Shapes);
			if (ShortPeriod != ShortPeriod_DefaultValue) h.Add("shortPeriod",ShortPeriod);
			if (SignalPeriod != SignalPeriod_DefaultValue) h.Add("signalPeriod",SignalPeriod);
			if (SimpleShapes != SimpleShapes_DefaultValue) h.Add("simpleShapes",SimpleShapes);
			if (SlowAvgPeriod != SlowAvgPeriod_DefaultValue) h.Add("slowAvgPeriod",SlowAvgPeriod);
			if (StandardDeviation != StandardDeviation_DefaultValue) h.Add("standardDeviation",StandardDeviation);
			if (Stroke != Stroke_DefaultValue) h.Add("stroke",Stroke);
			if (StrokeWidth != StrokeWidth_DefaultValue) h.Add("strokeWidth",StrokeWidth);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (TimeCycles != TimeCycles_DefaultValue) h.Add("timeCycles",TimeCycles);
			if (Title != Title_DefaultValue) h.Add("title",Title);
			if (TopBand != TopBand_DefaultValue) h.Add("topBand",TopBand);
			if (Tunnel != Tunnel_DefaultValue) h.Add("tunnel",Tunnel);
			if (TypeOptions != TypeOptions_DefaultValue) h.Add("typeOptions",TypeOptions);
			if (VerticalArrow != VerticalArrow_DefaultValue) h.Add("verticalArrow",VerticalArrow);
			if (VerticalCounter != VerticalCounter_DefaultValue) h.Add("verticalCounter",VerticalCounter);
			if (VerticalLabel != VerticalLabel_DefaultValue) h.Add("verticalLabel",VerticalLabel);
			if (VerticalLine != VerticalLine_DefaultValue) h.Add("verticalLine",VerticalLine);
			if (Volume != Volume_DefaultValue) h.Add("volume",Volume);
			if (XAxisUnit != XAxisUnit_DefaultValue) h.Add("xAxisUnit",XAxisUnit);
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