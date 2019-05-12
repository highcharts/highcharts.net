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
		public NavigationBindings()
		{
			ArrowInfinityLine = ArrowInfinityLine_DefaultValue = "";
			ArrowRay = ArrowRay_DefaultValue = "";
			ArrowSegment = ArrowSegment_DefaultValue = "";
			CircleAnnotation = CircleAnnotation_DefaultValue = "";
			Crooked3 = Crooked3_DefaultValue = "";
			Crooked5 = Crooked5_DefaultValue = "";
			CurrentPriceIndicator = CurrentPriceIndicator_DefaultValue = "";
			Elliott3 = Elliott3_DefaultValue = "";
			Elliott5 = Elliott5_DefaultValue = "";
			Fibonacci = Fibonacci_DefaultValue = "";
			FlagCirclepin = FlagCirclepin_DefaultValue = "";
			FlagDiamondpin = FlagDiamondpin_DefaultValue = "";
			FlagSimplepin = FlagSimplepin_DefaultValue = "";
			FlagSquarepin = FlagSquarepin_DefaultValue = "";
			FullScreen = FullScreen_DefaultValue = "";
			HorizontalLine = HorizontalLine_DefaultValue = "";
			Indicators = Indicators_DefaultValue = "";
			InfinityLine = InfinityLine_DefaultValue = "";
			LabelAnnotation = LabelAnnotation_DefaultValue = "";
			MeasureX = MeasureX_DefaultValue = "";
			MeasureXY = MeasureXY_DefaultValue = "";
			MeasureY = MeasureY_DefaultValue = "";
			ParallelChannel = ParallelChannel_DefaultValue = "";
			Pitchfork = Pitchfork_DefaultValue = "";
			Ray = Ray_DefaultValue = "";
			RectangleAnnotation = RectangleAnnotation_DefaultValue = "";
			SaveChart = SaveChart_DefaultValue = "";
			Segment = Segment_DefaultValue = "";
			SeriesTypeCandlestick = SeriesTypeCandlestick_DefaultValue = "";
			SeriesTypeLine = SeriesTypeLine_DefaultValue = "";
			SeriesTypeOhlc = SeriesTypeOhlc_DefaultValue = "";
			ToggleAnnotations = ToggleAnnotations_DefaultValue = "";
			VerticalArrow = VerticalArrow_DefaultValue = "";
			VerticalCounter = VerticalCounter_DefaultValue = "";
			VerticalLabel = VerticalLabel_DefaultValue = "";
			VerticalLine = VerticalLine_DefaultValue = "";
			ZoomX = ZoomX_DefaultValue = "";
			ZoomXY = ZoomXY_DefaultValue = "";
			ZoomY = ZoomY_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// A line with arrow annotation. Includes `start` and one event in `steps`array.
		/// </summary>
		public string ArrowInfinityLine { get; set; }
		private string ArrowInfinityLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// A ray with an arrow annotation bindings. Includes `start` and one eventin `steps` array.
		/// </summary>
		public string ArrowRay { get; set; }
		private string ArrowRay_DefaultValue { get; set; }
		 

		/// <summary>
		/// A segment with an arrow annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public string ArrowSegment { get; set; }
		private string ArrowSegment_DefaultValue { get; set; }
		 

		/// <summary>
		/// A circle annotation bindings. Includes `start` and one event in`steps` array.
		/// </summary>
		public string CircleAnnotation { get; set; }
		private string CircleAnnotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Crooked line (three points) annotation bindings. Includes `start` and twoevents in `steps` (for second and third points in crooked line) array.
		/// </summary>
		public string Crooked3 { get; set; }
		private string Crooked3_DefaultValue { get; set; }
		 

		/// <summary>
		/// Crooked line (five points) annotation bindings. Includes `start` and fourevents in `steps` (for all consequent points in crooked line) array.
		/// </summary>
		public string Crooked5 { get; set; }
		private string Crooked5_DefaultValue { get; set; }
		 

		/// <summary>
		/// Hides/shows two price indicators:- last price in the dataset- last price in the selected range
		/// </summary>
		public string CurrentPriceIndicator { get; set; }
		private string CurrentPriceIndicator_DefaultValue { get; set; }
		 

		/// <summary>
		/// Elliott wave (three points) annotation bindings. Includes `start` and twoevents in `steps` (for second and third points) array.
		/// </summary>
		public string Elliott3 { get; set; }
		private string Elliott3_DefaultValue { get; set; }
		 

		/// <summary>
		/// Elliott wave (five points) annotation bindings. Includes `start` and fourevent in `steps` (for all consequent points in Elliott wave) array.
		/// </summary>
		public string Elliott5 { get; set; }
		private string Elliott5_DefaultValue { get; set; }
		 

		/// <summary>
		/// A fibonacci annotation bindings. Includes `start` and two events in`steps` array (updates second point, then height).
		/// </summary>
		public string Fibonacci { get; set; }
		private string Fibonacci_DefaultValue { get; set; }
		 

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
		public string FullScreen { get; set; }
		private string FullScreen_DefaultValue { get; set; }
		 

		/// <summary>
		/// A horizontal line annotation. Includes `start` event.
		/// </summary>
		public string HorizontalLine { get; set; }
		private string HorizontalLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Indicators bindings. Includes `init` event to show a popup.
		/// </summary>
		public string Indicators { get; set; }
		private string Indicators_DefaultValue { get; set; }
		 

		/// <summary>
		/// A line annotation. Includes `start` and one event in `steps` array.
		/// </summary>
		public string InfinityLine { get; set; }
		private string InfinityLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// A label annotation bindings. Includes `start` event only.
		/// </summary>
		public string LabelAnnotation { get; set; }
		private string LabelAnnotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// A measure (x-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public string MeasureX { get; set; }
		private string MeasureX_DefaultValue { get; set; }
		 

		/// <summary>
		/// A measure (xy-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public string MeasureXY { get; set; }
		private string MeasureXY_DefaultValue { get; set; }
		 

		/// <summary>
		/// A measure (y-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public string MeasureY { get; set; }
		private string MeasureY_DefaultValue { get; set; }
		 

		/// <summary>
		/// A parallel channel (tunnel) annotation bindings. Includes `start` andtwo events in `steps` array (updates second point, then height).
		/// </summary>
		public string ParallelChannel { get; set; }
		private string ParallelChannel_DefaultValue { get; set; }
		 

		/// <summary>
		/// An Andrew's pitchfork annotation bindings. Includes `start` and twoevents in `steps` array (sets second and third control points).
		/// </summary>
		public string Pitchfork { get; set; }
		private string Pitchfork_DefaultValue { get; set; }
		 

		/// <summary>
		/// A ray annotation bindings. Includes `start` and one event in `steps`array.
		/// </summary>
		public string Ray { get; set; }
		private string Ray_DefaultValue { get; set; }
		 

		/// <summary>
		/// A rectangle annotation bindings. Includes `start` and one eventin `steps` array.
		/// </summary>
		public string RectangleAnnotation { get; set; }
		private string RectangleAnnotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Save a chart in localStorage under `highcharts-chart` key.Stored items:- annotations- indicators (with yAxes)- flags
		/// </summary>
		public string SaveChart { get; set; }
		private string SaveChart_DefaultValue { get; set; }
		 

		/// <summary>
		/// A segment annotation bindings. Includes `start` and one event in `steps`array.
		/// </summary>
		public string Segment { get; set; }
		private string Segment_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'candlestick'` type.
		/// </summary>
		public string SeriesTypeCandlestick { get; set; }
		private string SeriesTypeCandlestick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'line'` type.
		/// </summary>
		public string SeriesTypeLine { get; set; }
		private string SeriesTypeLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'ohlc'` type.
		/// </summary>
		public string SeriesTypeOhlc { get; set; }
		private string SeriesTypeOhlc_DefaultValue { get; set; }
		 

		/// <summary>
		/// Hides/shows all annotations on a chart.
		/// </summary>
		public string ToggleAnnotations { get; set; }
		private string ToggleAnnotations_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical arrow annotation bindings. Includes `start` event. On click,finds the closest point and marks it with an arrow. Green arrow whenpointing from above, red when pointing from below the point.
		/// </summary>
		public string VerticalArrow { get; set; }
		private string VerticalArrow_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical counter annotation bindings. Includes `start` event. On click,finds the closest point and marks it with a numeric annotation -incrementing counter on each add.
		/// </summary>
		public string VerticalCounter { get; set; }
		private string VerticalCounter_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical arrow annotation bindings. Includes `start` event. On click,finds the closest point and marks it with an arrow and a label withvalue.
		/// </summary>
		public string VerticalLabel { get; set; }
		private string VerticalLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical line annotation. Includes `start` event.
		/// </summary>
		public string VerticalLine { get; set; }
		private string VerticalLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables zooming in xAxis on a chart. Includes `start` event whichchanges [chart.zoomType](#chart.zoomType).
		/// </summary>
		public string ZoomX { get; set; }
		private string ZoomX_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables zooming in xAxis and yAxis on a chart. Includes `start` eventwhich changes [chart.zoomType](#chart.zoomType).
		/// </summary>
		public string ZoomXY { get; set; }
		private string ZoomXY_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables zooming in yAxis on a chart. Includes `start` event whichchanges [chart.zoomType](#chart.zoomType).
		/// </summary>
		public string ZoomY { get; set; }
		private string ZoomY_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ArrowInfinityLine != ArrowInfinityLine_DefaultValue) h.Add("arrowInfinityLine",ArrowInfinityLine);
			if (ArrowRay != ArrowRay_DefaultValue) h.Add("arrowRay",ArrowRay);
			if (ArrowSegment != ArrowSegment_DefaultValue) h.Add("arrowSegment",ArrowSegment);
			if (CircleAnnotation != CircleAnnotation_DefaultValue) h.Add("circleAnnotation",CircleAnnotation);
			if (Crooked3 != Crooked3_DefaultValue) h.Add("crooked3",Crooked3);
			if (Crooked5 != Crooked5_DefaultValue) h.Add("crooked5",Crooked5);
			if (CurrentPriceIndicator != CurrentPriceIndicator_DefaultValue) h.Add("currentPriceIndicator",CurrentPriceIndicator);
			if (Elliott3 != Elliott3_DefaultValue) h.Add("elliott3",Elliott3);
			if (Elliott5 != Elliott5_DefaultValue) h.Add("elliott5",Elliott5);
			if (Fibonacci != Fibonacci_DefaultValue) h.Add("fibonacci",Fibonacci);
			if (FlagCirclepin != FlagCirclepin_DefaultValue) h.Add("flagCirclepin",FlagCirclepin);
			if (FlagDiamondpin != FlagDiamondpin_DefaultValue) h.Add("flagDiamondpin",FlagDiamondpin);
			if (FlagSimplepin != FlagSimplepin_DefaultValue) h.Add("flagSimplepin",FlagSimplepin);
			if (FlagSquarepin != FlagSquarepin_DefaultValue) h.Add("flagSquarepin",FlagSquarepin);
			if (FullScreen != FullScreen_DefaultValue) h.Add("fullScreen",FullScreen);
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
			if (SaveChart != SaveChart_DefaultValue) h.Add("saveChart",SaveChart);
			if (Segment != Segment_DefaultValue) h.Add("segment",Segment);
			if (SeriesTypeCandlestick != SeriesTypeCandlestick_DefaultValue) h.Add("seriesTypeCandlestick",SeriesTypeCandlestick);
			if (SeriesTypeLine != SeriesTypeLine_DefaultValue) h.Add("seriesTypeLine",SeriesTypeLine);
			if (SeriesTypeOhlc != SeriesTypeOhlc_DefaultValue) h.Add("seriesTypeOhlc",SeriesTypeOhlc);
			if (ToggleAnnotations != ToggleAnnotations_DefaultValue) h.Add("toggleAnnotations",ToggleAnnotations);
			if (VerticalArrow != VerticalArrow_DefaultValue) h.Add("verticalArrow",VerticalArrow);
			if (VerticalCounter != VerticalCounter_DefaultValue) h.Add("verticalCounter",VerticalCounter);
			if (VerticalLabel != VerticalLabel_DefaultValue) h.Add("verticalLabel",VerticalLabel);
			if (VerticalLine != VerticalLine_DefaultValue) h.Add("verticalLine",VerticalLine);
			if (ZoomX != ZoomX_DefaultValue) h.Add("zoomX",ZoomX);
			if (ZoomXY != ZoomXY_DefaultValue) h.Add("zoomXY",ZoomXY);
			if (ZoomY != ZoomY_DefaultValue) h.Add("zoomY",ZoomY);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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