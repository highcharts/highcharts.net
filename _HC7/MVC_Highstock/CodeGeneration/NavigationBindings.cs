using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class NavigationBindings  : BaseObject
	{
		public NavigationBindings()
		{
			ArrowInfinityLine = ArrowInfinityLine_DefaultValue = null;
			ArrowRay = ArrowRay_DefaultValue = null;
			ArrowSegment = ArrowSegment_DefaultValue = null;
			CircleAnnotation = CircleAnnotation_DefaultValue = null;
			Crooked3 = Crooked3_DefaultValue = null;
			Crooked5 = Crooked5_DefaultValue = null;
			CurrentPriceIndicator = CurrentPriceIndicator_DefaultValue = null;
			Elliott3 = Elliott3_DefaultValue = null;
			Elliott5 = Elliott5_DefaultValue = null;
			Fibonacci = Fibonacci_DefaultValue = null;
			FlagCirclepin = FlagCirclepin_DefaultValue = null;
			FlagDiamondpin = FlagDiamondpin_DefaultValue = null;
			FlagSimplepin = FlagSimplepin_DefaultValue = null;
			FlagSquarepin = FlagSquarepin_DefaultValue = null;
			FullScreen = FullScreen_DefaultValue = null;
			HorizontalLine = HorizontalLine_DefaultValue = null;
			Indicators = Indicators_DefaultValue = null;
			InfinityLine = InfinityLine_DefaultValue = null;
			LabelAnnotation = LabelAnnotation_DefaultValue = null;
			MeasureX = MeasureX_DefaultValue = null;
			MeasureXY = MeasureXY_DefaultValue = null;
			MeasureY = MeasureY_DefaultValue = null;
			ParallelChannel = ParallelChannel_DefaultValue = null;
			Pitchfork = Pitchfork_DefaultValue = null;
			Ray = Ray_DefaultValue = null;
			RectangleAnnotation = RectangleAnnotation_DefaultValue = null;
			SaveChart = SaveChart_DefaultValue = null;
			Segment = Segment_DefaultValue = null;
			SeriesTypeCandlestick = SeriesTypeCandlestick_DefaultValue = null;
			SeriesTypeLine = SeriesTypeLine_DefaultValue = null;
			SeriesTypeOhlc = SeriesTypeOhlc_DefaultValue = null;
			ToggleAnnotations = ToggleAnnotations_DefaultValue = null;
			VerticalArrow = VerticalArrow_DefaultValue = null;
			VerticalCounter = VerticalCounter_DefaultValue = null;
			VerticalLabel = VerticalLabel_DefaultValue = null;
			VerticalLine = VerticalLine_DefaultValue = null;
			ZoomX = ZoomX_DefaultValue = null;
			ZoomXY = ZoomXY_DefaultValue = null;
			ZoomY = ZoomY_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// A line with arrow annotation. Includes `start` and one event in `steps`array.
		/// </summary>
		public object ArrowInfinityLine { get; set; }
		private object ArrowInfinityLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// A ray with an arrow annotation bindings. Includes `start` and one eventin `steps` array.
		/// </summary>
		public object ArrowRay { get; set; }
		private object ArrowRay_DefaultValue { get; set; }
		 

		/// <summary>
		/// A segment with an arrow annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public object ArrowSegment { get; set; }
		private object ArrowSegment_DefaultValue { get; set; }
		 

		/// <summary>
		/// A circle annotation bindings. Includes `start` and one event in`steps` array.
		/// </summary>
		public object CircleAnnotation { get; set; }
		private object CircleAnnotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Crooked line (three points) annotation bindings. Includes `start` and twoevents in `steps` (for second and third points in crooked line) array.
		/// </summary>
		public object Crooked3 { get; set; }
		private object Crooked3_DefaultValue { get; set; }
		 

		/// <summary>
		/// Crooked line (five points) annotation bindings. Includes `start` and fourevents in `steps` (for all consequent points in crooked line) array.
		/// </summary>
		public object Crooked5 { get; set; }
		private object Crooked5_DefaultValue { get; set; }
		 

		/// <summary>
		/// Hides/shows two price indicators:- last price in the dataset- last price in the selected range
		/// </summary>
		public object CurrentPriceIndicator { get; set; }
		private object CurrentPriceIndicator_DefaultValue { get; set; }
		 

		/// <summary>
		/// Elliott wave (three points) annotation bindings. Includes `start` and twoevents in `steps` (for second and third points) array.
		/// </summary>
		public object Elliott3 { get; set; }
		private object Elliott3_DefaultValue { get; set; }
		 

		/// <summary>
		/// Elliott wave (five points) annotation bindings. Includes `start` and fourevent in `steps` (for all consequent points in Elliott wave) array.
		/// </summary>
		public object Elliott5 { get; set; }
		private object Elliott5_DefaultValue { get; set; }
		 

		/// <summary>
		/// A fibonacci annotation bindings. Includes `start` and two events in`steps` array (updates second point, then height).
		/// </summary>
		public object Fibonacci { get; set; }
		private object Fibonacci_DefaultValue { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event. On click, finds theclosest point and marks it with a flag with `'circlepin'` shape.
		/// </summary>
		public object FlagCirclepin { get; set; }
		private object FlagCirclepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event. On click, finds theclosest point and marks it with a flag with `'diamondpin'` shape.
		/// </summary>
		public object FlagDiamondpin { get; set; }
		private object FlagDiamondpin_DefaultValue { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event.On click, finds the closest point and marks it with a flag without pinshape.
		/// </summary>
		public object FlagSimplepin { get; set; }
		private object FlagSimplepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// A flag series bindings. Includes `start` event.On click, finds the closest point and marks it with a flag with`'squarepin'` shape.
		/// </summary>
		public object FlagSquarepin { get; set; }
		private object FlagSquarepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// Displays chart in fullscreen.
		/// </summary>
		public object FullScreen { get; set; }
		private object FullScreen_DefaultValue { get; set; }
		 

		/// <summary>
		/// A horizontal line annotation. Includes `start` event.
		/// </summary>
		public object HorizontalLine { get; set; }
		private object HorizontalLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Indicators bindings. Includes `init` event to show a popup.
		/// </summary>
		public object Indicators { get; set; }
		private object Indicators_DefaultValue { get; set; }
		 

		/// <summary>
		/// A line annotation. Includes `start` and one event in `steps` array.
		/// </summary>
		public object InfinityLine { get; set; }
		private object InfinityLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// A label annotation bindings. Includes `start` event only.
		/// </summary>
		public object LabelAnnotation { get; set; }
		private object LabelAnnotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// A measure (x-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public object MeasureX { get; set; }
		private object MeasureX_DefaultValue { get; set; }
		 

		/// <summary>
		/// A measure (xy-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public object MeasureXY { get; set; }
		private object MeasureXY_DefaultValue { get; set; }
		 

		/// <summary>
		/// A measure (y-dimension) annotation bindings. Includes `start` and oneevent in `steps` array.
		/// </summary>
		public object MeasureY { get; set; }
		private object MeasureY_DefaultValue { get; set; }
		 

		/// <summary>
		/// A parallel channel (tunnel) annotation bindings. Includes `start` andtwo events in `steps` array (updates second point, then height).
		/// </summary>
		public object ParallelChannel { get; set; }
		private object ParallelChannel_DefaultValue { get; set; }
		 

		/// <summary>
		/// An Andrew's pitchfork annotation bindings. Includes `start` and twoevents in `steps` array (sets second and third control points).
		/// </summary>
		public object Pitchfork { get; set; }
		private object Pitchfork_DefaultValue { get; set; }
		 

		/// <summary>
		/// A ray annotation bindings. Includes `start` and one event in `steps`array.
		/// </summary>
		public object Ray { get; set; }
		private object Ray_DefaultValue { get; set; }
		 

		/// <summary>
		/// A rectangle annotation bindings. Includes `start` and one eventin `steps` array.
		/// </summary>
		public object RectangleAnnotation { get; set; }
		private object RectangleAnnotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Save a chart in localStorage under `highcharts-chart` key.Stored items:- annotations- indicators (with yAxes)- flags
		/// </summary>
		public object SaveChart { get; set; }
		private object SaveChart_DefaultValue { get; set; }
		 

		/// <summary>
		/// A segment annotation bindings. Includes `start` and one event in `steps`array.
		/// </summary>
		public object Segment { get; set; }
		private object Segment_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'candlestick'` type.
		/// </summary>
		public object SeriesTypeCandlestick { get; set; }
		private object SeriesTypeCandlestick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'line'` type.
		/// </summary>
		public object SeriesTypeLine { get; set; }
		private object SeriesTypeLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Changes main series to `'ohlc'` type.
		/// </summary>
		public object SeriesTypeOhlc { get; set; }
		private object SeriesTypeOhlc_DefaultValue { get; set; }
		 

		/// <summary>
		/// Hides/shows all annotations on a chart.
		/// </summary>
		public object ToggleAnnotations { get; set; }
		private object ToggleAnnotations_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical arrow annotation bindings. Includes `start` event. On click,finds the closest point and marks it with an arrow. Green arrow whenpointing from above, red when pointing from below the point.
		/// </summary>
		public object VerticalArrow { get; set; }
		private object VerticalArrow_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical counter annotation bindings. Includes `start` event. On click,finds the closest point and marks it with a numeric annotation -incrementing counter on each add.
		/// </summary>
		public object VerticalCounter { get; set; }
		private object VerticalCounter_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical arrow annotation bindings. Includes `start` event. On click,finds the closest point and marks it with an arrow and a label withvalue.
		/// </summary>
		public object VerticalLabel { get; set; }
		private object VerticalLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical line annotation. Includes `start` event.
		/// </summary>
		public object VerticalLine { get; set; }
		private object VerticalLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables zooming in xAxis on a chart. Includes `start` event whichchanges [chart.zoomType](#chart.zoomType).
		/// </summary>
		public object ZoomX { get; set; }
		private object ZoomX_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables zooming in xAxis and yAxis on a chart. Includes `start` eventwhich changes [chart.zoomType](#chart.zoomType).
		/// </summary>
		public object ZoomXY { get; set; }
		private object ZoomXY_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables zooming in yAxis on a chart. Includes `start` event whichchanges [chart.zoomType](#chart.zoomType).
		/// </summary>
		public object ZoomY { get; set; }
		private object ZoomY_DefaultValue { get; set; }
		  

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