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
	public partial class NavigationBindings  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationBindings()
		{
			ArrowInfinityLine = ArrowInfinityLine_DefaultValue = new Hashtable();
			ArrowRay = ArrowRay_DefaultValue = new Hashtable();
			ArrowSegment = ArrowSegment_DefaultValue = new Hashtable();
			CircleAnnotation = CircleAnnotation_DefaultValue = new Hashtable();
			Crooked3 = Crooked3_DefaultValue = new Hashtable();
			Crooked5 = Crooked5_DefaultValue = new Hashtable();
			CurrentPriceIndicator = CurrentPriceIndicator_DefaultValue = new Hashtable();
			Elliott3 = Elliott3_DefaultValue = new Hashtable();
			Elliott5 = Elliott5_DefaultValue = new Hashtable();
			EllipseAnnotation = EllipseAnnotation_DefaultValue = new Hashtable();
			Fibonacci = Fibonacci_DefaultValue = new Hashtable();
			FibonacciTimeZones = FibonacciTimeZones_DefaultValue = new Hashtable();
			FlagCirclepin = FlagCirclepin_DefaultValue = new Hashtable();
			FlagDiamondpin = FlagDiamondpin_DefaultValue = new Hashtable();
			FlagSimplepin = FlagSimplepin_DefaultValue = new Hashtable();
			FlagSquarepin = FlagSquarepin_DefaultValue = new Hashtable();
			FullScreen = FullScreen_DefaultValue = new Hashtable();
			HorizontalLine = HorizontalLine_DefaultValue = new Hashtable();
			Indicators = Indicators_DefaultValue = new Hashtable();
			InfinityLine = InfinityLine_DefaultValue = new Hashtable();
			LabelAnnotation = LabelAnnotation_DefaultValue = new Hashtable();
			MeasureX = MeasureX_DefaultValue = new Hashtable();
			MeasureXY = MeasureXY_DefaultValue = new Hashtable();
			MeasureY = MeasureY_DefaultValue = new Hashtable();
			ParallelChannel = ParallelChannel_DefaultValue = new Hashtable();
			Pitchfork = Pitchfork_DefaultValue = new Hashtable();
			Ray = Ray_DefaultValue = new Hashtable();
			RectangleAnnotation = RectangleAnnotation_DefaultValue = new Hashtable();
			SaveChart = SaveChart_DefaultValue = new Hashtable();
			Segment = Segment_DefaultValue = new Hashtable();
			SeriesTypeCandlestick = SeriesTypeCandlestick_DefaultValue = new Hashtable();
			SeriesTypeHeikinAshi = SeriesTypeHeikinAshi_DefaultValue = new Hashtable();
			SeriesTypeHLC = SeriesTypeHLC_DefaultValue = new Hashtable();
			SeriesTypeHollowCandlestick = SeriesTypeHollowCandlestick_DefaultValue = new Hashtable();
			SeriesTypeLine = SeriesTypeLine_DefaultValue = new Hashtable();
			SeriesTypeOhlc = SeriesTypeOhlc_DefaultValue = new Hashtable();
			TimeCycles = TimeCycles_DefaultValue = new Hashtable();
			ToggleAnnotations = ToggleAnnotations_DefaultValue = new Hashtable();
			VerticalArrow = VerticalArrow_DefaultValue = new Hashtable();
			VerticalCounter = VerticalCounter_DefaultValue = new Hashtable();
			VerticalLine = VerticalLine_DefaultValue = new Hashtable();
			ZoomX = ZoomX_DefaultValue = new Hashtable();
			ZoomXY = ZoomXY_DefaultValue = new Hashtable();
			ZoomY = ZoomY_DefaultValue = new Hashtable();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// A line with arrow annotation. Includes `start` and one event in `steps`array.
		/// </summary>
		public Hashtable ArrowInfinityLine { get; set; }
		private Hashtable ArrowInfinityLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// A ray with an arrow annotation bindings. Includes `start` and one eventin `steps` array.
		/// </summary>
		public Hashtable ArrowRay { get; set; }
		private Hashtable ArrowRay_DefaultValue { get; set; }
		 

		/// <summary>
		/// A segment with an arrow annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public Hashtable ArrowSegment { get; set; }
		private Hashtable ArrowSegment_DefaultValue { get; set; }
		 

		/// <summary>
		/// A circle annotation bindings. Includes `start` and one event in`steps` array.
		/// </summary>
		public Hashtable CircleAnnotation { get; set; }
		private Hashtable CircleAnnotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Crooked line (three points) annotation bindings. Includes `start` and twoevents in `steps` (for second and third points in crooked line) array.
		/// </summary>
		public Hashtable Crooked3 { get; set; }
		private Hashtable Crooked3_DefaultValue { get; set; }
		 

		/// <summary>
		/// Crooked line (five points) annotation bindings. Includes `start` and fourevents in `steps` (for all consequent points in crooked line) array.
		/// </summary>
		public Hashtable Crooked5 { get; set; }
		private Hashtable Crooked5_DefaultValue { get; set; }
		 

		/// <summary>
		/// Hides/shows two price indicators:- last price in the dataset- last price in the selected range
		/// </summary>
		public Hashtable CurrentPriceIndicator { get; set; }
		private Hashtable CurrentPriceIndicator_DefaultValue { get; set; }
		 

		/// <summary>
		/// Elliott wave (three points) annotation bindings. Includes `start` and twoevents in `steps` (for second and third points) array.
		/// </summary>
		public Hashtable Elliott3 { get; set; }
		private Hashtable Elliott3_DefaultValue { get; set; }
		 

		/// <summary>
		/// Elliott wave (five points) annotation bindings. Includes `start` and fourevent in `steps` (for all consequent points in Elliott wave) array.
		/// </summary>
		public Hashtable Elliott5 { get; set; }
		private Hashtable Elliott5_DefaultValue { get; set; }
		 

		/// <summary>
		/// A ellipse annotation bindings. Includes `start` and two events in`steps` array. First updates the second point, responsible for arx width, and second updates the ry width.
		/// </summary>
		public Hashtable EllipseAnnotation { get; set; }
		private Hashtable EllipseAnnotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// A fibonacci annotation bindings. Includes `start` and two events in`steps` array (updates second point, then height).
		/// </summary>
		public Hashtable Fibonacci { get; set; }
		private Hashtable Fibonacci_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Fibonacci Time Zones annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public Hashtable FibonacciTimeZones { get; set; }
		private Hashtable FibonacciTimeZones_DefaultValue { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event. On click, finds theclosest point and marks it with a flag with `'circlepin'` shape.
		/// </summary>
		public Hashtable FlagCirclepin { get; set; }
		private Hashtable FlagCirclepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event. On click, finds theclosest point and marks it with a flag with `'diamondpin'` shape.
		/// </summary>
		public Hashtable FlagDiamondpin { get; set; }
		private Hashtable FlagDiamondpin_DefaultValue { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event.On click, finds the closest point and marks it with a flag without pinshape.
		/// </summary>
		public Hashtable FlagSimplepin { get; set; }
		private Hashtable FlagSimplepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event.On click, finds the closest point and marks it with a flag with`'squarepin'` shape.
		/// </summary>
		public Hashtable FlagSquarepin { get; set; }
		private Hashtable FlagSquarepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// Displays chart in fullscreen.**Note**: Fullscreen is not supported on iPhone due to iOS limitations.
		/// </summary>
		public Hashtable FullScreen { get; set; }
		private Hashtable FullScreen_DefaultValue { get; set; }
		 

		/// <summary>
		/// A horizontal line annotation. Includes `start` event.
		/// </summary>
		public Hashtable HorizontalLine { get; set; }
		private Hashtable HorizontalLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Indicators bindings. Includes `init` event to show a popup.Note: In order to show base series from the chart in the popup'sdropdown each series requires[series.id](https://api.highcharts.com/highstock/series.line.id) to bedefined.
		/// </summary>
		public Hashtable Indicators { get; set; }
		private Hashtable Indicators_DefaultValue { get; set; }
		 

		/// <summary>
		/// A line annotation. Includes `start` and one event in `steps` array.
		/// </summary>
		public Hashtable InfinityLine { get; set; }
		private Hashtable InfinityLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// A label annotation bindings. Includes `start` event only.
		/// </summary>
		public Hashtable LabelAnnotation { get; set; }
		private Hashtable LabelAnnotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// A measure (x-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public Hashtable MeasureX { get; set; }
		private Hashtable MeasureX_DefaultValue { get; set; }
		 

		/// <summary>
		/// A measure (xy-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public Hashtable MeasureXY { get; set; }
		private Hashtable MeasureXY_DefaultValue { get; set; }
		 

		/// <summary>
		/// A measure (y-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public Hashtable MeasureY { get; set; }
		private Hashtable MeasureY_DefaultValue { get; set; }
		 

		/// <summary>
		/// A parallel channel (tunnel) annotation bindings. Includes `start` andtwo events in `steps` array (updates second point, then height).
		/// </summary>
		public Hashtable ParallelChannel { get; set; }
		private Hashtable ParallelChannel_DefaultValue { get; set; }
		 

		/// <summary>
		/// An Andrew's pitchfork annotation bindings. Includes `start` and twoevents in `steps` array (sets second and third control points).
		/// </summary>
		public Hashtable Pitchfork { get; set; }
		private Hashtable Pitchfork_DefaultValue { get; set; }
		 

		/// <summary>
		/// A ray annotation bindings. Includes `start` and one event in `steps`array.
		/// </summary>
		public Hashtable Ray { get; set; }
		private Hashtable Ray_DefaultValue { get; set; }
		 

		/// <summary>
		/// A rectangle annotation bindings. Includes `start` and one eventin `steps` array.
		/// </summary>
		public Hashtable RectangleAnnotation { get; set; }
		private Hashtable RectangleAnnotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Save a chart in localStorage under `highcharts-chart` key.Stored items:- annotations- indicators (with yAxes)- flags
		/// </summary>
		public Hashtable SaveChart { get; set; }
		private Hashtable SaveChart_DefaultValue { get; set; }
		 

		/// <summary>
		/// A segment annotation bindings. Includes `start` and one event in `steps`array.
		/// </summary>
		public Hashtable Segment { get; set; }
		private Hashtable Segment_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'candlestick'` type.
		/// </summary>
		public Hashtable SeriesTypeCandlestick { get; set; }
		private Hashtable SeriesTypeCandlestick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'heikinashi'` type.
		/// </summary>
		public Hashtable SeriesTypeHeikinAshi { get; set; }
		private Hashtable SeriesTypeHeikinAshi_DefaultValue { get; set; }
		 

		/// <summary>
		/// Change main series to `'hlc'` type.
		/// </summary>
		public Hashtable SeriesTypeHLC { get; set; }
		private Hashtable SeriesTypeHLC_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'hollowcandlestick'` type.
		/// </summary>
		public Hashtable SeriesTypeHollowCandlestick { get; set; }
		private Hashtable SeriesTypeHollowCandlestick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'line'` type.
		/// </summary>
		public Hashtable SeriesTypeLine { get; set; }
		private Hashtable SeriesTypeLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'ohlc'` type.
		/// </summary>
		public Hashtable SeriesTypeOhlc { get; set; }
		private Hashtable SeriesTypeOhlc_DefaultValue { get; set; }
		 

		/// <summary>
		/// A time cycles annotation bindings. Includes `start` event and 1 `step`event. first click marks the beginning of the circle, and the second onesets its diameter.
		/// </summary>
		public Hashtable TimeCycles { get; set; }
		private Hashtable TimeCycles_DefaultValue { get; set; }
		 

		/// <summary>
		/// Hides/shows all annotations on a chart.
		/// </summary>
		public Hashtable ToggleAnnotations { get; set; }
		private Hashtable ToggleAnnotations_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical arrow annotation bindings. Includes `start` event. On click,finds the closest point and marks it with an arrow.`#06b535` is the color of the arrow whenpointing from above and `#f21313`when pointing from below the point.
		/// </summary>
		public Hashtable VerticalArrow { get; set; }
		private Hashtable VerticalArrow_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical counter annotation bindings. Includes `start` event. On click,finds the closest point and marks it with a numeric annotation -incrementing counter on each add.
		/// </summary>
		public Hashtable VerticalCounter { get; set; }
		private Hashtable VerticalCounter_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical line annotation. Includes `start` event.
		/// </summary>
		public Hashtable VerticalLine { get; set; }
		private Hashtable VerticalLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables zooming in xAxis on a chart. Includes `start` event whichchanges [chart.zoomType](#chart.zoomType).
		/// </summary>
		public Hashtable ZoomX { get; set; }
		private Hashtable ZoomX_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables zooming in xAxis and yAxis on a chart. Includes `start` eventwhich changes [chart.zoomType](#chart.zoomType).
		/// </summary>
		public Hashtable ZoomXY { get; set; }
		private Hashtable ZoomXY_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables zooming in yAxis on a chart. Includes `start` event whichchanges [chart.zoomType](#chart.zoomType).
		/// </summary>
		public Hashtable ZoomY { get; set; }
		private Hashtable ZoomY_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (ArrowInfinityLine != ArrowInfinityLine_DefaultValue) h.Add("arrowInfinityLine",ArrowInfinityLine);
			if (ArrowRay != ArrowRay_DefaultValue) h.Add("arrowRay",ArrowRay);
			if (ArrowSegment != ArrowSegment_DefaultValue) h.Add("arrowSegment",ArrowSegment);
			if (CircleAnnotation != CircleAnnotation_DefaultValue) h.Add("circleAnnotation",CircleAnnotation);
			if (Crooked3 != Crooked3_DefaultValue) h.Add("crooked3",Crooked3);
			if (Crooked5 != Crooked5_DefaultValue) h.Add("crooked5",Crooked5);
			if (CurrentPriceIndicator != CurrentPriceIndicator_DefaultValue) h.Add("currentPriceIndicator",CurrentPriceIndicator);
			if (Elliott3 != Elliott3_DefaultValue) h.Add("elliott3",Elliott3);
			if (Elliott5 != Elliott5_DefaultValue) h.Add("elliott5",Elliott5);
			if (EllipseAnnotation.IsDirty(highstock)) h.Add("ellipseAnnotation",EllipseAnnotation.ToHashtable(highstock));
			if (Fibonacci != Fibonacci_DefaultValue) h.Add("fibonacci",Fibonacci);
			if (FibonacciTimeZones != FibonacciTimeZones_DefaultValue) h.Add("fibonacciTimeZones",FibonacciTimeZones);
			if (FlagCirclepin != FlagCirclepin_DefaultValue) h.Add("flagCirclepin",FlagCirclepin);
			if (FlagDiamondpin != FlagDiamondpin_DefaultValue) h.Add("flagDiamondpin",FlagDiamondpin);
			if (FlagSimplepin != FlagSimplepin_DefaultValue) h.Add("flagSimplepin",FlagSimplepin);
			if (FlagSquarepin != FlagSquarepin_DefaultValue) h.Add("flagSquarepin",FlagSquarepin);
			if (FullScreen.IsDirty(highstock)) h.Add("fullScreen",FullScreen.ToHashtable(highstock));
			if (HorizontalLine != HorizontalLine_DefaultValue) h.Add("horizontalLine",HorizontalLine);
			if (Indicators != Indicators_DefaultValue) h.Add("indicators",Indicators);
			if (InfinityLine != InfinityLine_DefaultValue) h.Add("infinityLine",InfinityLine);
			if (LabelAnnotation != LabelAnnotation_DefaultValue) h.Add("labelAnnotation",LabelAnnotation);
			if (MeasureX != MeasureX_DefaultValue) h.Add("measureX",MeasureX);
			if (MeasureXY != MeasureXY_DefaultValue) h.Add("measureXY",MeasureXY);
			if (MeasureY != MeasureY_DefaultValue) h.Add("measureY",MeasureY);
			if (ParallelChannel != ParallelChannel_DefaultValue) h.Add("parallelChannel",ParallelChannel);
			if (Pitchfork != Pitchfork_DefaultValue) h.Add("pitchfork",Pitchfork);
			if (Ray != Ray_DefaultValue) h.Add("ray",Ray);
			if (RectangleAnnotation != RectangleAnnotation_DefaultValue) h.Add("rectangleAnnotation",RectangleAnnotation);
			if (SaveChart.IsDirty(highstock)) h.Add("saveChart",SaveChart.ToHashtable(highstock));
			if (Segment != Segment_DefaultValue) h.Add("segment",Segment);
			if (SeriesTypeCandlestick != SeriesTypeCandlestick_DefaultValue) h.Add("seriesTypeCandlestick",SeriesTypeCandlestick);
			if (SeriesTypeHeikinAshi != SeriesTypeHeikinAshi_DefaultValue) h.Add("seriesTypeHeikinAshi",SeriesTypeHeikinAshi);
			if (SeriesTypeHLC.IsDirty(highstock)) h.Add("seriesTypeHLC",SeriesTypeHLC.ToHashtable(highstock));
			if (SeriesTypeHollowCandlestick != SeriesTypeHollowCandlestick_DefaultValue) h.Add("seriesTypeHollowCandlestick",SeriesTypeHollowCandlestick);
			if (SeriesTypeLine != SeriesTypeLine_DefaultValue) h.Add("seriesTypeLine",SeriesTypeLine);
			if (SeriesTypeOhlc != SeriesTypeOhlc_DefaultValue) h.Add("seriesTypeOhlc",SeriesTypeOhlc);
			if (TimeCycles.IsDirty(highstock)) h.Add("timeCycles",TimeCycles.ToHashtable(highstock));
			if (ToggleAnnotations != ToggleAnnotations_DefaultValue) h.Add("toggleAnnotations",ToggleAnnotations);
			if (VerticalArrow != VerticalArrow_DefaultValue) h.Add("verticalArrow",VerticalArrow);
			if (VerticalCounter != VerticalCounter_DefaultValue) h.Add("verticalCounter",VerticalCounter);
			if (VerticalLine != VerticalLine_DefaultValue) h.Add("verticalLine",VerticalLine);
			if (ZoomX != ZoomX_DefaultValue) h.Add("zoomX",ZoomX);
			if (ZoomXY != ZoomXY_DefaultValue) h.Add("zoomXY",ZoomXY);
			if (ZoomY != ZoomY_DefaultValue) h.Add("zoomY",ZoomY);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}