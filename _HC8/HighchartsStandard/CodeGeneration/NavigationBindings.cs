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
	public partial class NavigationBindings  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationBindings()
		{
			ArrowInfinityLine = ArrowInfinityLine_DefaultValue = new NavigationBindingsArrowInfinityLine();
			ArrowRay = ArrowRay_DefaultValue = new NavigationBindingsArrowRay();
			ArrowSegment = ArrowSegment_DefaultValue = new NavigationBindingsArrowSegment();
			CircleAnnotation = CircleAnnotation_DefaultValue = "";
			Crooked3 = Crooked3_DefaultValue = new NavigationBindingsCrooked3();
			Crooked5 = Crooked5_DefaultValue = new NavigationBindingsCrooked5();
			CurrentPriceIndicator = CurrentPriceIndicator_DefaultValue = new NavigationBindingsCurrentPriceIndicator();
			Elliott3 = Elliott3_DefaultValue = new NavigationBindingsElliott3();
			Elliott5 = Elliott5_DefaultValue = new NavigationBindingsElliott5();
			Fibonacci = Fibonacci_DefaultValue = new NavigationBindingsFibonacci();
			FlagCirclepin = FlagCirclepin_DefaultValue = "";
			FlagDiamondpin = FlagDiamondpin_DefaultValue = "";
			FlagSimplepin = FlagSimplepin_DefaultValue = "";
			FlagSquarepin = FlagSquarepin_DefaultValue = "";
			FullScreen = FullScreen_DefaultValue = new NavigationBindingsFullScreen();
			HorizontalLine = HorizontalLine_DefaultValue = new NavigationBindingsHorizontalLine();
			Indicators = Indicators_DefaultValue = new NavigationBindingsIndicators();
			InfinityLine = InfinityLine_DefaultValue = new NavigationBindingsInfinityLine();
			LabelAnnotation = LabelAnnotation_DefaultValue = "";
			MeasureX = MeasureX_DefaultValue = new NavigationBindingsMeasureX();
			MeasureXY = MeasureXY_DefaultValue = new NavigationBindingsMeasureXY();
			MeasureY = MeasureY_DefaultValue = new NavigationBindingsMeasureY();
			ParallelChannel = ParallelChannel_DefaultValue = new NavigationBindingsParallelChannel();
			Pitchfork = Pitchfork_DefaultValue = new NavigationBindingsPitchfork();
			Ray = Ray_DefaultValue = new NavigationBindingsRay();
			RectangleAnnotation = RectangleAnnotation_DefaultValue = "";
			SaveChart = SaveChart_DefaultValue = new NavigationBindingsSaveChart();
			Segment = Segment_DefaultValue = new NavigationBindingsSegment();
			SeriesTypeCandlestick = SeriesTypeCandlestick_DefaultValue = new NavigationBindingsSeriesTypeCandlestick();
			SeriesTypeLine = SeriesTypeLine_DefaultValue = new NavigationBindingsSeriesTypeLine();
			SeriesTypeOhlc = SeriesTypeOhlc_DefaultValue = new NavigationBindingsSeriesTypeOhlc();
			ToggleAnnotations = ToggleAnnotations_DefaultValue = new NavigationBindingsToggleAnnotations();
			VerticalArrow = VerticalArrow_DefaultValue = new NavigationBindingsVerticalArrow();
			VerticalCounter = VerticalCounter_DefaultValue = new NavigationBindingsVerticalCounter();
			VerticalLabel = VerticalLabel_DefaultValue = new NavigationBindingsVerticalLabel();
			VerticalLine = VerticalLine_DefaultValue = new NavigationBindingsVerticalLine();
			ZoomX = ZoomX_DefaultValue = new NavigationBindingsZoomX();
			ZoomXY = ZoomXY_DefaultValue = new NavigationBindingsZoomXY();
			ZoomY = ZoomY_DefaultValue = new NavigationBindingsZoomY();
			
		}	
		

		/// <summary>
		/// A line with arrow annotation. Includes `start` and one event in `steps`array.
		/// </summary>
		public NavigationBindingsArrowInfinityLine ArrowInfinityLine { get; set; }
		private NavigationBindingsArrowInfinityLine ArrowInfinityLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// A ray with an arrow annotation bindings. Includes `start` and one eventin `steps` array.
		/// </summary>
		public NavigationBindingsArrowRay ArrowRay { get; set; }
		private NavigationBindingsArrowRay ArrowRay_DefaultValue { get; set; }
		 

		/// <summary>
		/// A segment with an arrow annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public NavigationBindingsArrowSegment ArrowSegment { get; set; }
		private NavigationBindingsArrowSegment ArrowSegment_DefaultValue { get; set; }
		 

		/// <summary>
		/// A circle annotation bindings. Includes `start` and one event in`steps` array.
		/// </summary>
		public string CircleAnnotation { get; set; }
		private string CircleAnnotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Crooked line (three points) annotation bindings. Includes `start` and twoevents in `steps` (for second and third points in crooked line) array.
		/// </summary>
		public NavigationBindingsCrooked3 Crooked3 { get; set; }
		private NavigationBindingsCrooked3 Crooked3_DefaultValue { get; set; }
		 

		/// <summary>
		/// Crooked line (five points) annotation bindings. Includes `start` and fourevents in `steps` (for all consequent points in crooked line) array.
		/// </summary>
		public NavigationBindingsCrooked5 Crooked5 { get; set; }
		private NavigationBindingsCrooked5 Crooked5_DefaultValue { get; set; }
		 

		/// <summary>
		/// Hides/shows two price indicators:- last price in the dataset- last price in the selected range
		/// </summary>
		public NavigationBindingsCurrentPriceIndicator CurrentPriceIndicator { get; set; }
		private NavigationBindingsCurrentPriceIndicator CurrentPriceIndicator_DefaultValue { get; set; }
		 

		/// <summary>
		/// Elliott wave (three points) annotation bindings. Includes `start` and twoevents in `steps` (for second and third points) array.
		/// </summary>
		public NavigationBindingsElliott3 Elliott3 { get; set; }
		private NavigationBindingsElliott3 Elliott3_DefaultValue { get; set; }
		 

		/// <summary>
		/// Elliott wave (five points) annotation bindings. Includes `start` and fourevent in `steps` (for all consequent points in Elliott wave) array.
		/// </summary>
		public NavigationBindingsElliott5 Elliott5 { get; set; }
		private NavigationBindingsElliott5 Elliott5_DefaultValue { get; set; }
		 

		/// <summary>
		/// A fibonacci annotation bindings. Includes `start` and two events in`steps` array (updates second point, then height).
		/// </summary>
		public NavigationBindingsFibonacci Fibonacci { get; set; }
		private NavigationBindingsFibonacci Fibonacci_DefaultValue { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event. On click, finds theclosest point and marks it with a flag with `'circlepin'` shape.
		/// </summary>
		public string FlagCirclepin { get; set; }
		private string FlagCirclepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event. On click, finds theclosest point and marks it with a flag with `'diamondpin'` shape.
		/// </summary>
		public string FlagDiamondpin { get; set; }
		private string FlagDiamondpin_DefaultValue { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event.On click, finds the closest point and marks it with a flag without pinshape.
		/// </summary>
		public string FlagSimplepin { get; set; }
		private string FlagSimplepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event.On click, finds the closest point and marks it with a flag with`'squarepin'` shape.
		/// </summary>
		public string FlagSquarepin { get; set; }
		private string FlagSquarepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// Displays chart in fullscreen.
		/// </summary>
		public NavigationBindingsFullScreen FullScreen { get; set; }
		private NavigationBindingsFullScreen FullScreen_DefaultValue { get; set; }
		 

		/// <summary>
		/// A horizontal line annotation. Includes `start` event.
		/// </summary>
		public NavigationBindingsHorizontalLine HorizontalLine { get; set; }
		private NavigationBindingsHorizontalLine HorizontalLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Indicators bindings. Includes `init` event to show a popup.Note: In order to show base series from the chart in the popup'sdropdown each series requires[series.id](https://api.highcharts.com/highstock/series.line.id) to bedefined.
		/// </summary>
		public NavigationBindingsIndicators Indicators { get; set; }
		private NavigationBindingsIndicators Indicators_DefaultValue { get; set; }
		 

		/// <summary>
		/// A line annotation. Includes `start` and one event in `steps` array.
		/// </summary>
		public NavigationBindingsInfinityLine InfinityLine { get; set; }
		private NavigationBindingsInfinityLine InfinityLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// A label annotation bindings. Includes `start` event only.
		/// </summary>
		public string LabelAnnotation { get; set; }
		private string LabelAnnotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// A measure (x-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public NavigationBindingsMeasureX MeasureX { get; set; }
		private NavigationBindingsMeasureX MeasureX_DefaultValue { get; set; }
		 

		/// <summary>
		/// A measure (xy-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public NavigationBindingsMeasureXY MeasureXY { get; set; }
		private NavigationBindingsMeasureXY MeasureXY_DefaultValue { get; set; }
		 

		/// <summary>
		/// A measure (y-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public NavigationBindingsMeasureY MeasureY { get; set; }
		private NavigationBindingsMeasureY MeasureY_DefaultValue { get; set; }
		 

		/// <summary>
		/// A parallel channel (tunnel) annotation bindings. Includes `start` andtwo events in `steps` array (updates second point, then height).
		/// </summary>
		public NavigationBindingsParallelChannel ParallelChannel { get; set; }
		private NavigationBindingsParallelChannel ParallelChannel_DefaultValue { get; set; }
		 

		/// <summary>
		/// An Andrew's pitchfork annotation bindings. Includes `start` and twoevents in `steps` array (sets second and third control points).
		/// </summary>
		public NavigationBindingsPitchfork Pitchfork { get; set; }
		private NavigationBindingsPitchfork Pitchfork_DefaultValue { get; set; }
		 

		/// <summary>
		/// A ray annotation bindings. Includes `start` and one event in `steps`array.
		/// </summary>
		public NavigationBindingsRay Ray { get; set; }
		private NavigationBindingsRay Ray_DefaultValue { get; set; }
		 

		/// <summary>
		/// A rectangle annotation bindings. Includes `start` and one eventin `steps` array.
		/// </summary>
		public string RectangleAnnotation { get; set; }
		private string RectangleAnnotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Save a chart in localStorage under `highcharts-chart` key.Stored items:- annotations- indicators (with yAxes)- flags
		/// </summary>
		public NavigationBindingsSaveChart SaveChart { get; set; }
		private NavigationBindingsSaveChart SaveChart_DefaultValue { get; set; }
		 

		/// <summary>
		/// A segment annotation bindings. Includes `start` and one event in `steps`array.
		/// </summary>
		public NavigationBindingsSegment Segment { get; set; }
		private NavigationBindingsSegment Segment_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'candlestick'` type.
		/// </summary>
		public NavigationBindingsSeriesTypeCandlestick SeriesTypeCandlestick { get; set; }
		private NavigationBindingsSeriesTypeCandlestick SeriesTypeCandlestick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'line'` type.
		/// </summary>
		public NavigationBindingsSeriesTypeLine SeriesTypeLine { get; set; }
		private NavigationBindingsSeriesTypeLine SeriesTypeLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'ohlc'` type.
		/// </summary>
		public NavigationBindingsSeriesTypeOhlc SeriesTypeOhlc { get; set; }
		private NavigationBindingsSeriesTypeOhlc SeriesTypeOhlc_DefaultValue { get; set; }
		 

		/// <summary>
		/// Hides/shows all annotations on a chart.
		/// </summary>
		public NavigationBindingsToggleAnnotations ToggleAnnotations { get; set; }
		private NavigationBindingsToggleAnnotations ToggleAnnotations_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical arrow annotation bindings. Includes `start` event. On click,finds the closest point and marks it with an arrow. Green arrow whenpointing from above, red when pointing from below the point.
		/// </summary>
		public NavigationBindingsVerticalArrow VerticalArrow { get; set; }
		private NavigationBindingsVerticalArrow VerticalArrow_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical counter annotation bindings. Includes `start` event. On click,finds the closest point and marks it with a numeric annotation -incrementing counter on each add.
		/// </summary>
		public NavigationBindingsVerticalCounter VerticalCounter { get; set; }
		private NavigationBindingsVerticalCounter VerticalCounter_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical arrow annotation bindings. Includes `start` event. On click,finds the closest point and marks it with an arrow and a label withvalue.
		/// </summary>
		public NavigationBindingsVerticalLabel VerticalLabel { get; set; }
		private NavigationBindingsVerticalLabel VerticalLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical line annotation. Includes `start` event.
		/// </summary>
		public NavigationBindingsVerticalLine VerticalLine { get; set; }
		private NavigationBindingsVerticalLine VerticalLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables zooming in xAxis on a chart. Includes `start` event whichchanges [chart.zoomType](#chart.zoomType).
		/// </summary>
		public NavigationBindingsZoomX ZoomX { get; set; }
		private NavigationBindingsZoomX ZoomX_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables zooming in xAxis and yAxis on a chart. Includes `start` eventwhich changes [chart.zoomType](#chart.zoomType).
		/// </summary>
		public NavigationBindingsZoomXY ZoomXY { get; set; }
		private NavigationBindingsZoomXY ZoomXY_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables zooming in yAxis on a chart. Includes `start` event whichchanges [chart.zoomType](#chart.zoomType).
		/// </summary>
		public NavigationBindingsZoomY ZoomY { get; set; }
		private NavigationBindingsZoomY ZoomY_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (ArrowInfinityLine.IsDirty()) h.Add("arrowInfinityLine",ArrowInfinityLine.ToHashtable());
			if (ArrowRay.IsDirty()) h.Add("arrowRay",ArrowRay.ToHashtable());
			if (ArrowSegment.IsDirty()) h.Add("arrowSegment",ArrowSegment.ToHashtable());
			if (CircleAnnotation != CircleAnnotation_DefaultValue) h.Add("circleAnnotation",CircleAnnotation);
			if (Crooked3.IsDirty()) h.Add("crooked3",Crooked3.ToHashtable());
			if (Crooked5.IsDirty()) h.Add("crooked5",Crooked5.ToHashtable());
			if (CurrentPriceIndicator.IsDirty()) h.Add("currentPriceIndicator",CurrentPriceIndicator.ToHashtable());
			if (Elliott3.IsDirty()) h.Add("elliott3",Elliott3.ToHashtable());
			if (Elliott5.IsDirty()) h.Add("elliott5",Elliott5.ToHashtable());
			if (Fibonacci.IsDirty()) h.Add("fibonacci",Fibonacci.ToHashtable());
			if (FlagCirclepin != FlagCirclepin_DefaultValue) h.Add("flagCirclepin",FlagCirclepin);
			if (FlagDiamondpin != FlagDiamondpin_DefaultValue) h.Add("flagDiamondpin",FlagDiamondpin);
			if (FlagSimplepin != FlagSimplepin_DefaultValue) h.Add("flagSimplepin",FlagSimplepin);
			if (FlagSquarepin != FlagSquarepin_DefaultValue) h.Add("flagSquarepin",FlagSquarepin);
			if (FullScreen.IsDirty()) h.Add("fullScreen",FullScreen.ToHashtable());
			if (HorizontalLine.IsDirty()) h.Add("horizontalLine",HorizontalLine.ToHashtable());
			if (Indicators.IsDirty()) h.Add("indicators",Indicators.ToHashtable());
			if (InfinityLine.IsDirty()) h.Add("infinityLine",InfinityLine.ToHashtable());
			if (LabelAnnotation != LabelAnnotation_DefaultValue) h.Add("labelAnnotation",LabelAnnotation);
			if (MeasureX.IsDirty()) h.Add("measureX",MeasureX.ToHashtable());
			if (MeasureXY.IsDirty()) h.Add("measureXY",MeasureXY.ToHashtable());
			if (MeasureY.IsDirty()) h.Add("measureY",MeasureY.ToHashtable());
			if (ParallelChannel.IsDirty()) h.Add("parallelChannel",ParallelChannel.ToHashtable());
			if (Pitchfork.IsDirty()) h.Add("pitchfork",Pitchfork.ToHashtable());
			if (Ray.IsDirty()) h.Add("ray",Ray.ToHashtable());
			if (RectangleAnnotation != RectangleAnnotation_DefaultValue) h.Add("rectangleAnnotation",RectangleAnnotation);
			if (SaveChart.IsDirty()) h.Add("saveChart",SaveChart.ToHashtable());
			if (Segment.IsDirty()) h.Add("segment",Segment.ToHashtable());
			if (SeriesTypeCandlestick.IsDirty()) h.Add("seriesTypeCandlestick",SeriesTypeCandlestick.ToHashtable());
			if (SeriesTypeLine.IsDirty()) h.Add("seriesTypeLine",SeriesTypeLine.ToHashtable());
			if (SeriesTypeOhlc.IsDirty()) h.Add("seriesTypeOhlc",SeriesTypeOhlc.ToHashtable());
			if (ToggleAnnotations.IsDirty()) h.Add("toggleAnnotations",ToggleAnnotations.ToHashtable());
			if (VerticalArrow.IsDirty()) h.Add("verticalArrow",VerticalArrow.ToHashtable());
			if (VerticalCounter.IsDirty()) h.Add("verticalCounter",VerticalCounter.ToHashtable());
			if (VerticalLabel.IsDirty()) h.Add("verticalLabel",VerticalLabel.ToHashtable());
			if (VerticalLine.IsDirty()) h.Add("verticalLine",VerticalLine.ToHashtable());
			if (ZoomX.IsDirty()) h.Add("zoomX",ZoomX.ToHashtable());
			if (ZoomXY.IsDirty()) h.Add("zoomXY",ZoomXY.ToHashtable());
			if (ZoomY.IsDirty()) h.Add("zoomY",ZoomY.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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