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
			ArrowInfinityLine = ArrowInfinityLine_DefaultValue = new Object();
			ArrowRay = ArrowRay_DefaultValue = new Object();
			ArrowSegment = ArrowSegment_DefaultValue = new Object();
			CircleAnnotation = CircleAnnotation_DefaultValue = new Object();
			Crooked3 = Crooked3_DefaultValue = new Object();
			Crooked5 = Crooked5_DefaultValue = new Object();
			CurrentPriceIndicator = CurrentPriceIndicator_DefaultValue = new Object();
			Elliott3 = Elliott3_DefaultValue = new Object();
			Elliott5 = Elliott5_DefaultValue = new Object();
			EllipseAnnotation = EllipseAnnotation_DefaultValue = new NavigationBindingsEllipseAnnotation();
			Fibonacci = Fibonacci_DefaultValue = new Object();
			FibonacciTimeZones = FibonacciTimeZones_DefaultValue = null;
			FlagCirclepin = FlagCirclepin_DefaultValue = new Object();
			FlagDiamondpin = FlagDiamondpin_DefaultValue = new Object();
			FlagSimplepin = FlagSimplepin_DefaultValue = new Object();
			FlagSquarepin = FlagSquarepin_DefaultValue = new Object();
			FullScreen = FullScreen_DefaultValue = new Object();
			HorizontalLine = HorizontalLine_DefaultValue = new Object();
			Indicators = Indicators_DefaultValue = new Object();
			InfinityLine = InfinityLine_DefaultValue = new Object();
			LabelAnnotation = LabelAnnotation_DefaultValue = new Object();
			MeasureX = MeasureX_DefaultValue = new Object();
			MeasureXY = MeasureXY_DefaultValue = new Object();
			MeasureY = MeasureY_DefaultValue = new Object();
			ParallelChannel = ParallelChannel_DefaultValue = new Object();
			Pitchfork = Pitchfork_DefaultValue = new Object();
			Ray = Ray_DefaultValue = new Object();
			RectangleAnnotation = RectangleAnnotation_DefaultValue = new Object();
			SaveChart = SaveChart_DefaultValue = new Object();
			Segment = Segment_DefaultValue = new Object();
			SeriesTypeCandlestick = SeriesTypeCandlestick_DefaultValue = new Object();
			SeriesTypeHeikinAshi = SeriesTypeHeikinAshi_DefaultValue = null;
			SeriesTypeHLC = SeriesTypeHLC_DefaultValue = new NavigationBindingsSeriesTypeHLC();
			SeriesTypeHollowCandlestick = SeriesTypeHollowCandlestick_DefaultValue = null;
			SeriesTypeLine = SeriesTypeLine_DefaultValue = new Object();
			SeriesTypeOhlc = SeriesTypeOhlc_DefaultValue = new Object();
			TimeCycles = TimeCycles_DefaultValue = new NavigationBindingsTimeCycles();
			ToggleAnnotations = ToggleAnnotations_DefaultValue = new Object();
			VerticalArrow = VerticalArrow_DefaultValue = new Object();
			VerticalCounter = VerticalCounter_DefaultValue = new Object();
			VerticalLine = VerticalLine_DefaultValue = new Object();
			ZoomX = ZoomX_DefaultValue = new Object();
			ZoomXY = ZoomXY_DefaultValue = new Object();
			ZoomY = ZoomY_DefaultValue = new Object();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// A line with arrow annotation. Includes `start` and one event in `steps`array.
		/// </summary>
		public Object ArrowInfinityLine { get; set; }
		private Object ArrowInfinityLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// A ray with an arrow annotation bindings. Includes `start` and one eventin `steps` array.
		/// </summary>
		public Object ArrowRay { get; set; }
		private Object ArrowRay_DefaultValue { get; set; }
		 

		/// <summary>
		/// A segment with an arrow annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public Object ArrowSegment { get; set; }
		private Object ArrowSegment_DefaultValue { get; set; }
		 

		/// <summary>
		/// A circle annotation bindings. Includes `start` and one event in`steps` array.
		/// </summary>
		public Object CircleAnnotation { get; set; }
		private Object CircleAnnotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Crooked line (three points) annotation bindings. Includes `start` and twoevents in `steps` (for second and third points in crooked line) array.
		/// </summary>
		public Object Crooked3 { get; set; }
		private Object Crooked3_DefaultValue { get; set; }
		 

		/// <summary>
		/// Crooked line (five points) annotation bindings. Includes `start` and fourevents in `steps` (for all consequent points in crooked line) array.
		/// </summary>
		public Object Crooked5 { get; set; }
		private Object Crooked5_DefaultValue { get; set; }
		 

		/// <summary>
		/// Hides/shows two price indicators:- last price in the dataset- last price in the selected range
		/// </summary>
		public Object CurrentPriceIndicator { get; set; }
		private Object CurrentPriceIndicator_DefaultValue { get; set; }
		 

		/// <summary>
		/// Elliott wave (three points) annotation bindings. Includes `start` and twoevents in `steps` (for second and third points) array.
		/// </summary>
		public Object Elliott3 { get; set; }
		private Object Elliott3_DefaultValue { get; set; }
		 

		/// <summary>
		/// Elliott wave (five points) annotation bindings. Includes `start` and fourevent in `steps` (for all consequent points in Elliott wave) array.
		/// </summary>
		public Object Elliott5 { get; set; }
		private Object Elliott5_DefaultValue { get; set; }
		 

		/// <summary>
		/// A ellipse annotation bindings. Includes `start` and two events in`steps` array. First updates the second point, responsible for arx width, and second updates the ry width.
		/// </summary>
		public NavigationBindingsEllipseAnnotation EllipseAnnotation { get; set; }
		private NavigationBindingsEllipseAnnotation EllipseAnnotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// A fibonacci annotation bindings. Includes `start` and two events in`steps` array (updates second point, then height).
		/// </summary>
		public Object Fibonacci { get; set; }
		private Object Fibonacci_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Fibonacci Time Zones annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public Object FibonacciTimeZones { get; set; }
		private Object FibonacciTimeZones_DefaultValue { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event. On click, finds theclosest point and marks it with a flag with `'circlepin'` shape.
		/// </summary>
		public Object FlagCirclepin { get; set; }
		private Object FlagCirclepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event. On click, finds theclosest point and marks it with a flag with `'diamondpin'` shape.
		/// </summary>
		public Object FlagDiamondpin { get; set; }
		private Object FlagDiamondpin_DefaultValue { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event.On click, finds the closest point and marks it with a flag without pinshape.
		/// </summary>
		public Object FlagSimplepin { get; set; }
		private Object FlagSimplepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event.On click, finds the closest point and marks it with a flag with`'squarepin'` shape.
		/// </summary>
		public Object FlagSquarepin { get; set; }
		private Object FlagSquarepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// Displays chart in fullscreen.**Note**: Fullscreen is not supported on iPhone due to iOS limitations.
		/// </summary>
		public NavigationBindingsFullScreen FullScreen { get; set; }
		private NavigationBindingsFullScreen FullScreen_DefaultValue { get; set; }
		 

		/// <summary>
		/// A horizontal line annotation. Includes `start` event.
		/// </summary>
		public Object HorizontalLine { get; set; }
		private Object HorizontalLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Indicators bindings. Includes `init` event to show a popup.Note: In order to show base series from the chart in the popup'sdropdown each series requires[series.id](https://api.highcharts.com/highstock/series.line.id) to bedefined.
		/// </summary>
		public Object Indicators { get; set; }
		private Object Indicators_DefaultValue { get; set; }
		 

		/// <summary>
		/// A line annotation. Includes `start` and one event in `steps` array.
		/// </summary>
		public Object InfinityLine { get; set; }
		private Object InfinityLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// A label annotation bindings. Includes `start` event only.
		/// </summary>
		public Object LabelAnnotation { get; set; }
		private Object LabelAnnotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// A measure (x-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public Object MeasureX { get; set; }
		private Object MeasureX_DefaultValue { get; set; }
		 

		/// <summary>
		/// A measure (xy-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public Object MeasureXY { get; set; }
		private Object MeasureXY_DefaultValue { get; set; }
		 

		/// <summary>
		/// A measure (y-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public Object MeasureY { get; set; }
		private Object MeasureY_DefaultValue { get; set; }
		 

		/// <summary>
		/// A parallel channel (tunnel) annotation bindings. Includes `start` andtwo events in `steps` array (updates second point, then height).
		/// </summary>
		public Object ParallelChannel { get; set; }
		private Object ParallelChannel_DefaultValue { get; set; }
		 

		/// <summary>
		/// An Andrew's pitchfork annotation bindings. Includes `start` and twoevents in `steps` array (sets second and third control points).
		/// </summary>
		public Object Pitchfork { get; set; }
		private Object Pitchfork_DefaultValue { get; set; }
		 

		/// <summary>
		/// A ray annotation bindings. Includes `start` and one event in `steps`array.
		/// </summary>
		public Object Ray { get; set; }
		private Object Ray_DefaultValue { get; set; }
		 

		/// <summary>
		/// A rectangle annotation bindings. Includes `start` and one eventin `steps` array.
		/// </summary>
		public Object RectangleAnnotation { get; set; }
		private Object RectangleAnnotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Save a chart in localStorage under `highcharts-chart` key.Stored items:- annotations- indicators (with yAxes)- flags
		/// </summary>
		public NavigationBindingsSaveChart SaveChart { get; set; }
		private NavigationBindingsSaveChart SaveChart_DefaultValue { get; set; }
		 

		/// <summary>
		/// A segment annotation bindings. Includes `start` and one event in `steps`array.
		/// </summary>
		public Object Segment { get; set; }
		private Object Segment_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'candlestick'` type.
		/// </summary>
		public Object SeriesTypeCandlestick { get; set; }
		private Object SeriesTypeCandlestick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'heikinashi'` type.
		/// </summary>
		public Object SeriesTypeHeikinAshi { get; set; }
		private Object SeriesTypeHeikinAshi_DefaultValue { get; set; }
		 

		/// <summary>
		/// Change main series to `'hlc'` type.
		/// </summary>
		public NavigationBindingsSeriesTypeHLC SeriesTypeHLC { get; set; }
		private NavigationBindingsSeriesTypeHLC SeriesTypeHLC_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'hollowcandlestick'` type.
		/// </summary>
		public Object SeriesTypeHollowCandlestick { get; set; }
		private Object SeriesTypeHollowCandlestick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'line'` type.
		/// </summary>
		public Object SeriesTypeLine { get; set; }
		private Object SeriesTypeLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'ohlc'` type.
		/// </summary>
		public Object SeriesTypeOhlc { get; set; }
		private Object SeriesTypeOhlc_DefaultValue { get; set; }
		 

		/// <summary>
		/// A time cycles annotation bindings. Includes `start` event and 1 `step`event. first click marks the beginning of the circle, and the second onesets its diameter.
		/// </summary>
		public NavigationBindingsTimeCycles TimeCycles { get; set; }
		private NavigationBindingsTimeCycles TimeCycles_DefaultValue { get; set; }
		 

		/// <summary>
		/// Hides/shows all annotations on a chart.
		/// </summary>
		public Object ToggleAnnotations { get; set; }
		private Object ToggleAnnotations_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical arrow annotation bindings. Includes `start` event. On click,finds the closest point and marks it with an arrow.`#06b535` is the color of the arrow whenpointing from above and `#f21313`when pointing from below the point.
		/// </summary>
		public Object VerticalArrow { get; set; }
		private Object VerticalArrow_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical counter annotation bindings. Includes `start` event. On click,finds the closest point and marks it with a numeric annotation -incrementing counter on each add.
		/// </summary>
		public Object VerticalCounter { get; set; }
		private Object VerticalCounter_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical line annotation. Includes `start` event.
		/// </summary>
		public Object VerticalLine { get; set; }
		private Object VerticalLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables zooming in xAxis on a chart. Includes `start` event whichchanges [chart.zoomType](#chart.zoomType).
		/// </summary>
		public Object ZoomX { get; set; }
		private Object ZoomX_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables zooming in xAxis and yAxis on a chart. Includes `start` eventwhich changes [chart.zoomType](#chart.zoomType).
		/// </summary>
		public Object ZoomXY { get; set; }
		private Object ZoomXY_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables zooming in yAxis on a chart. Includes `start` event whichchanges [chart.zoomType](#chart.zoomType).
		/// </summary>
		public Object ZoomY { get; set; }
		private Object ZoomY_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
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
			if (EllipseAnnotation.IsDirty(ref highcharts)) h.Add("ellipseAnnotation",EllipseAnnotation.ToHashtable(ref highcharts));
			if (Fibonacci != Fibonacci_DefaultValue) h.Add("fibonacci",Fibonacci);
			if (FibonacciTimeZones != FibonacciTimeZones_DefaultValue) h.Add("fibonacciTimeZones",FibonacciTimeZones);
			if (FlagCirclepin != FlagCirclepin_DefaultValue) h.Add("flagCirclepin",FlagCirclepin);
			if (FlagDiamondpin != FlagDiamondpin_DefaultValue) h.Add("flagDiamondpin",FlagDiamondpin);
			if (FlagSimplepin != FlagSimplepin_DefaultValue) h.Add("flagSimplepin",FlagSimplepin);
			if (FlagSquarepin != FlagSquarepin_DefaultValue) h.Add("flagSquarepin",FlagSquarepin);
			if (FullScreen.IsDirty(ref highcharts)) h.Add("fullScreen",FullScreen.ToHashtable(ref highcharts));
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
			if (SaveChart.IsDirty(ref highcharts)) h.Add("saveChart",SaveChart.ToHashtable(ref highcharts));
			if (Segment != Segment_DefaultValue) h.Add("segment",Segment);
			if (SeriesTypeCandlestick != SeriesTypeCandlestick_DefaultValue) h.Add("seriesTypeCandlestick",SeriesTypeCandlestick);
			if (SeriesTypeHeikinAshi != SeriesTypeHeikinAshi_DefaultValue) h.Add("seriesTypeHeikinAshi",SeriesTypeHeikinAshi);
			if (SeriesTypeHLC.IsDirty(ref highcharts)) h.Add("seriesTypeHLC",SeriesTypeHLC.ToHashtable(ref highcharts));
			if (SeriesTypeHollowCandlestick != SeriesTypeHollowCandlestick_DefaultValue) h.Add("seriesTypeHollowCandlestick",SeriesTypeHollowCandlestick);
			if (SeriesTypeLine != SeriesTypeLine_DefaultValue) h.Add("seriesTypeLine",SeriesTypeLine);
			if (SeriesTypeOhlc != SeriesTypeOhlc_DefaultValue) h.Add("seriesTypeOhlc",SeriesTypeOhlc);
			if (TimeCycles.IsDirty(ref highcharts)) h.Add("timeCycles",TimeCycles.ToHashtable(ref highcharts));
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

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}