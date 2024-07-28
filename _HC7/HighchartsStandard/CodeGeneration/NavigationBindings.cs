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
		}	
		

		/// <summary>
		/// A line with arrow annotation. Includes `start` and one event in `steps`array.
		/// </summary>
		public Object ArrowInfinityLine { get; set; }
		 

		/// <summary>
		/// A ray with an arrow annotation bindings. Includes `start` and one eventin `steps` array.
		/// </summary>
		public Object ArrowRay { get; set; }
		 

		/// <summary>
		/// A segment with an arrow annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public Object ArrowSegment { get; set; }
		 

		/// <summary>
		/// A circle annotation bindings. Includes `start` and one event in`steps` array.
		/// </summary>
		public Object CircleAnnotation { get; set; }
		 

		/// <summary>
		/// Crooked line (three points) annotation bindings. Includes `start` and twoevents in `steps` (for second and third points in crooked line) array.
		/// </summary>
		public Object Crooked3 { get; set; }
		 

		/// <summary>
		/// Crooked line (five points) annotation bindings. Includes `start` and fourevents in `steps` (for all consequent points in crooked line) array.
		/// </summary>
		public Object Crooked5 { get; set; }
		 

		/// <summary>
		/// Hides/shows two price indicators:- last price in the dataset- last price in the selected range
		/// </summary>
		public Object CurrentPriceIndicator { get; set; }
		 

		/// <summary>
		/// Elliott wave (three points) annotation bindings. Includes `start` and twoevents in `steps` (for second and third points) array.
		/// </summary>
		public Object Elliott3 { get; set; }
		 

		/// <summary>
		/// Elliott wave (five points) annotation bindings. Includes `start` and fourevent in `steps` (for all consequent points in Elliott wave) array.
		/// </summary>
		public Object Elliott5 { get; set; }
		 

		/// <summary>
		/// A ellipse annotation bindings. Includes `start` and two events in`steps` array. First updates the second point, responsible for arx width, and second updates the ry width.
		/// </summary>
		public NavigationBindingsEllipseAnnotation EllipseAnnotation { get; set; }
		 

		/// <summary>
		/// A fibonacci annotation bindings. Includes `start` and two events in`steps` array (updates second point, then height).
		/// </summary>
		public NavigationBindingsFibonacci Fibonacci { get; set; }
		 

		/// <summary>
		/// The Fibonacci Time Zones annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public Object FibonacciTimeZones { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event. On click, finds theclosest point and marks it with a flag with `'circlepin'` shape.
		/// </summary>
		public Object FlagCirclepin { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event. On click, finds theclosest point and marks it with a flag with `'diamondpin'` shape.
		/// </summary>
		public Object FlagDiamondpin { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event.On click, finds the closest point and marks it with a flag without pinshape.
		/// </summary>
		public Object FlagSimplepin { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event.On click, finds the closest point and marks it with a flag with`'squarepin'` shape.
		/// </summary>
		public Object FlagSquarepin { get; set; }
		 

		/// <summary>
		/// Displays chart in fullscreen.**Note**: Fullscreen is not supported on iPhone due to iOS limitations.
		/// </summary>
		public NavigationBindingsFullScreen FullScreen { get; set; }
		 

		/// <summary>
		/// A horizontal line annotation. Includes `start` event.
		/// </summary>
		public Object HorizontalLine { get; set; }
		 

		/// <summary>
		/// Indicators bindings. Includes `init` event to show a popup.Note: In order to show base series from the chart in the popup'sdropdown each series requires[series.id](https://api.highcharts.com/highstock/series.line.id) to bedefined.
		/// </summary>
		public Object Indicators { get; set; }
		 

		/// <summary>
		/// A line annotation. Includes `start` and one event in `steps` array.
		/// </summary>
		public Object InfinityLine { get; set; }
		 

		/// <summary>
		/// A label annotation bindings. Includes `start` event only.
		/// </summary>
		public Object LabelAnnotation { get; set; }
		 

		/// <summary>
		/// A measure (x-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public Object MeasureX { get; set; }
		 

		/// <summary>
		/// A measure (xy-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public Object MeasureXY { get; set; }
		 

		/// <summary>
		/// A measure (y-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public Object MeasureY { get; set; }
		 

		/// <summary>
		/// A parallel channel (tunnel) annotation bindings. Includes `start` andtwo events in `steps` array (updates second point, then height).
		/// </summary>
		public Object ParallelChannel { get; set; }
		 

		/// <summary>
		/// An Andrew's pitchfork annotation bindings. Includes `start` and twoevents in `steps` array (sets second and third control points).
		/// </summary>
		public Object Pitchfork { get; set; }
		 

		/// <summary>
		/// A ray annotation bindings. Includes `start` and one event in `steps`array.
		/// </summary>
		public Object Ray { get; set; }
		 

		/// <summary>
		/// A rectangle annotation bindings. Includes `start` and one eventin `steps` array.
		/// </summary>
		public Object RectangleAnnotation { get; set; }
		 

		/// <summary>
		/// Save a chart in localStorage under `highcharts-chart` key.Stored items:- annotations- indicators (with yAxes)- flags
		/// </summary>
		public NavigationBindingsSaveChart SaveChart { get; set; }
		 

		/// <summary>
		/// A segment annotation bindings. Includes `start` and one event in `steps`array.
		/// </summary>
		public Object Segment { get; set; }
		 

		/// <summary>
		/// Changes main series to `'candlestick'` type.
		/// </summary>
		public Object SeriesTypeCandlestick { get; set; }
		 

		/// <summary>
		/// Changes main series to `'heikinashi'` type.
		/// </summary>
		public Object SeriesTypeHeikinAshi { get; set; }
		 

		/// <summary>
		/// Change main series to `'hlc'` type.
		/// </summary>
		public NavigationBindingsSeriesTypeHLC SeriesTypeHLC { get; set; }
		 

		/// <summary>
		/// Changes main series to `'hollowcandlestick'` type.
		/// </summary>
		public Object SeriesTypeHollowCandlestick { get; set; }
		 

		/// <summary>
		/// Changes main series to `'line'` type.
		/// </summary>
		public Object SeriesTypeLine { get; set; }
		 

		/// <summary>
		/// Changes main series to `'ohlc'` type.
		/// </summary>
		public Object SeriesTypeOhlc { get; set; }
		 

		/// <summary>
		/// A time cycles annotation bindings. Includes `start` event and 1 `step`event. first click marks the beginning of the circle, and the second onesets its diameter.
		/// </summary>
		public NavigationBindingsTimeCycles TimeCycles { get; set; }
		 

		/// <summary>
		/// Hides/shows all annotations on a chart.
		/// </summary>
		public Object ToggleAnnotations { get; set; }
		 

		/// <summary>
		/// A vertical arrow annotation bindings. Includes `start` event. On click,finds the closest point and marks it with an arrow.`#06b535` is the color of the arrow whenpointing from above and `#f21313`when pointing from below the point.
		/// </summary>
		public Object VerticalArrow { get; set; }
		 

		/// <summary>
		/// A vertical counter annotation bindings. Includes `start` event. On click,finds the closest point and marks it with a numeric annotation -incrementing counter on each add.
		/// </summary>
		public Object VerticalCounter { get; set; }
		 

		/// <summary>
		/// A vertical line annotation. Includes `start` event.
		/// </summary>
		public Object VerticalLine { get; set; }
		 

		/// <summary>
		/// Enables zooming in xAxis on a chart. Includes `start` event whichchanges [chart.zoomType](#chart.zoomType).
		/// </summary>
		public Object ZoomX { get; set; }
		 

		/// <summary>
		/// Enables zooming in xAxis and yAxis on a chart. Includes `start` eventwhich changes [chart.zoomType](#chart.zoomType).
		/// </summary>
		public Object ZoomXY { get; set; }
		 

		/// <summary>
		/// Enables zooming in yAxis on a chart. Includes `start` event whichchanges [chart.zoomType](#chart.zoomType).
		/// </summary>
		public Object ZoomY { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (ArrowInfinityLine != null) h.Add("arrowInfinityLine",ArrowInfinityLine);
			if (ArrowRay != null) h.Add("arrowRay",ArrowRay);
			if (ArrowSegment != null) h.Add("arrowSegment",ArrowSegment);
			if (CircleAnnotation != null) h.Add("circleAnnotation",CircleAnnotation);
			if (Crooked3 != null) h.Add("crooked3",Crooked3);
			if (Crooked5 != null) h.Add("crooked5",Crooked5);
			if (CurrentPriceIndicator != null) h.Add("currentPriceIndicator",CurrentPriceIndicator);
			if (Elliott3 != null) h.Add("elliott3",Elliott3);
			if (Elliott5 != null) h.Add("elliott5",Elliott5);
			if (EllipseAnnotation != null) h.Add("ellipseAnnotation",EllipseAnnotation.ToHashtable(highcharts));
			if (Fibonacci != null) h.Add("fibonacci",Fibonacci.ToHashtable(highcharts));
			if (FibonacciTimeZones != null) h.Add("fibonacciTimeZones",FibonacciTimeZones);
			if (FlagCirclepin != null) h.Add("flagCirclepin",FlagCirclepin);
			if (FlagDiamondpin != null) h.Add("flagDiamondpin",FlagDiamondpin);
			if (FlagSimplepin != null) h.Add("flagSimplepin",FlagSimplepin);
			if (FlagSquarepin != null) h.Add("flagSquarepin",FlagSquarepin);
			if (FullScreen != null) h.Add("fullScreen",FullScreen.ToHashtable(highcharts));
			if (HorizontalLine != null) h.Add("horizontalLine",HorizontalLine);
			if (Indicators != null) h.Add("indicators",Indicators);
			if (InfinityLine != null) h.Add("infinityLine",InfinityLine);
			if (LabelAnnotation != null) h.Add("labelAnnotation",LabelAnnotation);
			if (MeasureX != null) h.Add("measureX",MeasureX);
			if (MeasureXY != null) h.Add("measureXY",MeasureXY);
			if (MeasureY != null) h.Add("measureY",MeasureY);
			if (ParallelChannel != null) h.Add("parallelChannel",ParallelChannel);
			if (Pitchfork != null) h.Add("pitchfork",Pitchfork);
			if (Ray != null) h.Add("ray",Ray);
			if (RectangleAnnotation != null) h.Add("rectangleAnnotation",RectangleAnnotation);
			if (SaveChart != null) h.Add("saveChart",SaveChart.ToHashtable(highcharts));
			if (Segment != null) h.Add("segment",Segment);
			if (SeriesTypeCandlestick != null) h.Add("seriesTypeCandlestick",SeriesTypeCandlestick);
			if (SeriesTypeHeikinAshi != null) h.Add("seriesTypeHeikinAshi",SeriesTypeHeikinAshi);
			if (SeriesTypeHLC != null) h.Add("seriesTypeHLC",SeriesTypeHLC.ToHashtable(highcharts));
			if (SeriesTypeHollowCandlestick != null) h.Add("seriesTypeHollowCandlestick",SeriesTypeHollowCandlestick);
			if (SeriesTypeLine != null) h.Add("seriesTypeLine",SeriesTypeLine);
			if (SeriesTypeOhlc != null) h.Add("seriesTypeOhlc",SeriesTypeOhlc);
			if (TimeCycles != null) h.Add("timeCycles",TimeCycles.ToHashtable(highcharts));
			if (ToggleAnnotations != null) h.Add("toggleAnnotations",ToggleAnnotations);
			if (VerticalArrow != null) h.Add("verticalArrow",VerticalArrow);
			if (VerticalCounter != null) h.Add("verticalCounter",VerticalCounter);
			if (VerticalLine != null) h.Add("verticalLine",VerticalLine);
			if (ZoomX != null) h.Add("zoomX",ZoomX);
			if (ZoomXY != null) h.Add("zoomXY",ZoomXY);
			if (ZoomY != null) h.Add("zoomY",ZoomY);
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