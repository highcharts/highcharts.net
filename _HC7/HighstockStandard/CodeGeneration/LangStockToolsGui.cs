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
	public partial class LangStockToolsGui  : BaseObject
	{
		public LangStockToolsGui()
		{
			Advanced = Advanced_DefaultValue = "Advanced";
			ArrowLine = ArrowLine_DefaultValue = "Arrow line";
			ArrowRay = ArrowRay_DefaultValue = "Arrow ray";
			ArrowSegment = ArrowSegment_DefaultValue = "Arrow segment";
			Circle = Circle_DefaultValue = "Circle";
			Crooked3 = Crooked3_DefaultValue = "Crooked 3 line";
			Crooked5 = Crooked5_DefaultValue = "Crooked 5 line";
			CrookedLines = CrookedLines_DefaultValue = "Crooked lines";
			CurrentPriceIndicator = CurrentPriceIndicator_DefaultValue = "Current Price Indicators";
			Elliott3 = Elliott3_DefaultValue = "Elliott 3 line";
			Elliott5 = Elliott5_DefaultValue = "Elliott 5 line";
			Fibonacci = Fibonacci_DefaultValue = "Fibonacci";
			FlagCirclepin = FlagCirclepin_DefaultValue = "Flag circle";
			FlagDiamondpin = FlagDiamondpin_DefaultValue = "Flag diamond";
			Flags = Flags_DefaultValue = "Flags";
			FlagSimplepin = FlagSimplepin_DefaultValue = "Flag simple";
			FlagSquarepin = FlagSquarepin_DefaultValue = "Flag square";
			FullScreen = FullScreen_DefaultValue = "Fullscreen";
			HorizontalLine = HorizontalLine_DefaultValue = "Horizontal line";
			Indicators = Indicators_DefaultValue = "Indicators";
			InfinityLine = InfinityLine_DefaultValue = "Infinity line";
			Label = Label_DefaultValue = "Label";
			Line = Line_DefaultValue = "Line";
			Lines = Lines_DefaultValue = "Lines";
			Measure = Measure_DefaultValue = "Measure";
			MeasureX = MeasureX_DefaultValue = "Measure X";
			MeasureXY = MeasureXY_DefaultValue = "Measure XY";
			MeasureY = MeasureY_DefaultValue = "Measure Y";
			ParallelChannel = ParallelChannel_DefaultValue = "Parallel channel";
			Pitchfork = Pitchfork_DefaultValue = "Pitchfork";
			Ray = Ray_DefaultValue = "Ray";
			Rectangle = Rectangle_DefaultValue = "Rectangle";
			SaveChart = SaveChart_DefaultValue = "Save chart";
			Segment = Segment_DefaultValue = "Segment";
			SimpleShapes = SimpleShapes_DefaultValue = "Simple shapes";
			ToggleAnnotations = ToggleAnnotations_DefaultValue = "Toggle annotations";
			TypeCandlestick = TypeCandlestick_DefaultValue = "Candlestick";
			TypeChange = TypeChange_DefaultValue = "Type change";
			TypeLine = TypeLine_DefaultValue = "Line";
			TypeOHLC = TypeOHLC_DefaultValue = "OHLC";
			VerticalArrow = VerticalArrow_DefaultValue = "Vertical arrow";
			VerticalCounter = VerticalCounter_DefaultValue = "Vertical counter";
			VerticalLabel = VerticalLabel_DefaultValue = "Vertical label";
			VerticalLabels = VerticalLabels_DefaultValue = "Vertical labels";
			VerticalLine = VerticalLine_DefaultValue = "Vertical line";
			ZoomChange = ZoomChange_DefaultValue = "Zoom change";
			ZoomX = ZoomX_DefaultValue = "Zoom X";
			ZoomXY = ZoomXY_DefaultValue = "Zooom XY";
			ZoomY = ZoomY_DefaultValue = "Zoom Y";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Advanced { get; set; }
		private string Advanced_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ArrowLine { get; set; }
		private string ArrowLine_DefaultValue { get; set; }
		 

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
		public string Circle { get; set; }
		private string Circle_DefaultValue { get; set; }
		 

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
		public string CrookedLines { get; set; }
		private string CrookedLines_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string CurrentPriceIndicator { get; set; }
		private string CurrentPriceIndicator_DefaultValue { get; set; }
		 

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
		public string Fibonacci { get; set; }
		private string Fibonacci_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FlagCirclepin { get; set; }
		private string FlagCirclepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FlagDiamondpin { get; set; }
		private string FlagDiamondpin_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Flags { get; set; }
		private string Flags_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FlagSimplepin { get; set; }
		private string FlagSimplepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FlagSquarepin { get; set; }
		private string FlagSquarepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FullScreen { get; set; }
		private string FullScreen_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string HorizontalLine { get; set; }
		private string HorizontalLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Indicators { get; set; }
		private string Indicators_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string InfinityLine { get; set; }
		private string InfinityLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Label { get; set; }
		private string Label_DefaultValue { get; set; }
		 

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
		public string ParallelChannel { get; set; }
		private string ParallelChannel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Pitchfork { get; set; }
		private string Pitchfork_DefaultValue { get; set; }
		 

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
		public string SaveChart { get; set; }
		private string SaveChart_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Segment { get; set; }
		private string Segment_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SimpleShapes { get; set; }
		private string SimpleShapes_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ToggleAnnotations { get; set; }
		private string ToggleAnnotations_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TypeCandlestick { get; set; }
		private string TypeCandlestick_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TypeChange { get; set; }
		private string TypeChange_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TypeLine { get; set; }
		private string TypeLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TypeOHLC { get; set; }
		private string TypeOHLC_DefaultValue { get; set; }
		 

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
		public string VerticalLabels { get; set; }
		private string VerticalLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string VerticalLine { get; set; }
		private string VerticalLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ZoomChange { get; set; }
		private string ZoomChange_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ZoomX { get; set; }
		private string ZoomX_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ZoomXY { get; set; }
		private string ZoomXY_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ZoomY { get; set; }
		private string ZoomY_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Advanced != Advanced_DefaultValue) h.Add("advanced",Advanced);
			if (ArrowLine != ArrowLine_DefaultValue) h.Add("arrowLine",ArrowLine);
			if (ArrowRay != ArrowRay_DefaultValue) h.Add("arrowRay",ArrowRay);
			if (ArrowSegment != ArrowSegment_DefaultValue) h.Add("arrowSegment",ArrowSegment);
			if (Circle != Circle_DefaultValue) h.Add("circle",Circle);
			if (Crooked3 != Crooked3_DefaultValue) h.Add("crooked3",Crooked3);
			if (Crooked5 != Crooked5_DefaultValue) h.Add("crooked5",Crooked5);
			if (CrookedLines != CrookedLines_DefaultValue) h.Add("crookedLines",CrookedLines);
			if (CurrentPriceIndicator != CurrentPriceIndicator_DefaultValue) h.Add("currentPriceIndicator",CurrentPriceIndicator);
			if (Elliott3 != Elliott3_DefaultValue) h.Add("elliott3",Elliott3);
			if (Elliott5 != Elliott5_DefaultValue) h.Add("elliott5",Elliott5);
			if (Fibonacci != Fibonacci_DefaultValue) h.Add("fibonacci",Fibonacci);
			if (FlagCirclepin != FlagCirclepin_DefaultValue) h.Add("flagCirclepin",FlagCirclepin);
			if (FlagDiamondpin != FlagDiamondpin_DefaultValue) h.Add("flagDiamondpin",FlagDiamondpin);
			if (Flags != Flags_DefaultValue) h.Add("flags",Flags);
			if (FlagSimplepin != FlagSimplepin_DefaultValue) h.Add("flagSimplepin",FlagSimplepin);
			if (FlagSquarepin != FlagSquarepin_DefaultValue) h.Add("flagSquarepin",FlagSquarepin);
			if (FullScreen != FullScreen_DefaultValue) h.Add("fullScreen",FullScreen);
			if (HorizontalLine != HorizontalLine_DefaultValue) h.Add("horizontalLine",HorizontalLine);
			if (Indicators != Indicators_DefaultValue) h.Add("indicators",Indicators);
			if (InfinityLine != InfinityLine_DefaultValue) h.Add("infinityLine",InfinityLine);
			if (Label != Label_DefaultValue) h.Add("label",Label);
			if (Line != Line_DefaultValue) h.Add("line",Line);
			if (Lines != Lines_DefaultValue) h.Add("lines",Lines);
			if (Measure != Measure_DefaultValue) h.Add("measure",Measure);
			if (MeasureX != MeasureX_DefaultValue) h.Add("measureX",MeasureX);
			if (MeasureXY != MeasureXY_DefaultValue) h.Add("measureXY",MeasureXY);
			if (MeasureY != MeasureY_DefaultValue) h.Add("measureY",MeasureY);
			if (ParallelChannel != ParallelChannel_DefaultValue) h.Add("parallelChannel",ParallelChannel);
			if (Pitchfork != Pitchfork_DefaultValue) h.Add("pitchfork",Pitchfork);
			if (Ray != Ray_DefaultValue) h.Add("ray",Ray);
			if (Rectangle != Rectangle_DefaultValue) h.Add("rectangle",Rectangle);
			if (SaveChart != SaveChart_DefaultValue) h.Add("saveChart",SaveChart);
			if (Segment != Segment_DefaultValue) h.Add("segment",Segment);
			if (SimpleShapes != SimpleShapes_DefaultValue) h.Add("simpleShapes",SimpleShapes);
			if (ToggleAnnotations != ToggleAnnotations_DefaultValue) h.Add("toggleAnnotations",ToggleAnnotations);
			if (TypeCandlestick != TypeCandlestick_DefaultValue) h.Add("typeCandlestick",TypeCandlestick);
			if (TypeChange != TypeChange_DefaultValue) h.Add("typeChange",TypeChange);
			if (TypeLine != TypeLine_DefaultValue) h.Add("typeLine",TypeLine);
			if (TypeOHLC != TypeOHLC_DefaultValue) h.Add("typeOHLC",TypeOHLC);
			if (VerticalArrow != VerticalArrow_DefaultValue) h.Add("verticalArrow",VerticalArrow);
			if (VerticalCounter != VerticalCounter_DefaultValue) h.Add("verticalCounter",VerticalCounter);
			if (VerticalLabel != VerticalLabel_DefaultValue) h.Add("verticalLabel",VerticalLabel);
			if (VerticalLabels != VerticalLabels_DefaultValue) h.Add("verticalLabels",VerticalLabels);
			if (VerticalLine != VerticalLine_DefaultValue) h.Add("verticalLine",VerticalLine);
			if (ZoomChange != ZoomChange_DefaultValue) h.Add("zoomChange",ZoomChange);
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