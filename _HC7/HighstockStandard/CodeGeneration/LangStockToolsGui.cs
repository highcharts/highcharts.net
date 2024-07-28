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
		Hashtable h = new Hashtable();

		public LangStockToolsGui()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Advanced { get; set; }
		 

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
		public string Circle { get; set; }
		 

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
		public string CrookedLines { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string CurrentPriceIndicator { get; set; }
		 

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
		public string Fibonacci { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FibonacciTimeZones { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FlagCirclepin { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FlagDiamondpin { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Flags { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FlagSimplepin { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FlagSquarepin { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FullScreen { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string HorizontalLine { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Indicators { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string InfinityLine { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Label { get; set; }
		 

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
		public string ParallelChannel { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Pitchfork { get; set; }
		 

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
		public string SaveChart { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Segment { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SimpleShapes { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TimeCycles { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ToggleAnnotations { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TypeCandlestick { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TypeChange { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TypeHeikinAshi { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TypeHLC { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TypeHollowCandlestick { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TypeLine { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TypeOHLC { get; set; }
		 

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
		public string VerticalLabels { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string VerticalLine { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ZoomChange { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ZoomX { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ZoomXY { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ZoomY { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Advanced != null) h.Add("advanced",Advanced);
			if (ArrowInfinityLine != null) h.Add("arrowInfinityLine",ArrowInfinityLine);
			if (ArrowRay != null) h.Add("arrowRay",ArrowRay);
			if (ArrowSegment != null) h.Add("arrowSegment",ArrowSegment);
			if (Circle != null) h.Add("circle",Circle);
			if (Crooked3 != null) h.Add("crooked3",Crooked3);
			if (Crooked5 != null) h.Add("crooked5",Crooked5);
			if (CrookedLines != null) h.Add("crookedLines",CrookedLines);
			if (CurrentPriceIndicator != null) h.Add("currentPriceIndicator",CurrentPriceIndicator);
			if (Elliott3 != null) h.Add("elliott3",Elliott3);
			if (Elliott5 != null) h.Add("elliott5",Elliott5);
			if (Ellipse != null) h.Add("ellipse",Ellipse);
			if (Fibonacci != null) h.Add("fibonacci",Fibonacci);
			if (FibonacciTimeZones != null) h.Add("fibonacciTimeZones",FibonacciTimeZones);
			if (FlagCirclepin != null) h.Add("flagCirclepin",FlagCirclepin);
			if (FlagDiamondpin != null) h.Add("flagDiamondpin",FlagDiamondpin);
			if (Flags != null) h.Add("flags",Flags);
			if (FlagSimplepin != null) h.Add("flagSimplepin",FlagSimplepin);
			if (FlagSquarepin != null) h.Add("flagSquarepin",FlagSquarepin);
			if (FullScreen != null) h.Add("fullScreen",FullScreen);
			if (HorizontalLine != null) h.Add("horizontalLine",HorizontalLine);
			if (Indicators != null) h.Add("indicators",Indicators);
			if (InfinityLine != null) h.Add("infinityLine",InfinityLine);
			if (Label != null) h.Add("label",Label);
			if (Line != null) h.Add("line",Line);
			if (Lines != null) h.Add("lines",Lines);
			if (Measure != null) h.Add("measure",Measure);
			if (MeasureX != null) h.Add("measureX",MeasureX);
			if (MeasureXY != null) h.Add("measureXY",MeasureXY);
			if (MeasureY != null) h.Add("measureY",MeasureY);
			if (ParallelChannel != null) h.Add("parallelChannel",ParallelChannel);
			if (Pitchfork != null) h.Add("pitchfork",Pitchfork);
			if (Ray != null) h.Add("ray",Ray);
			if (Rectangle != null) h.Add("rectangle",Rectangle);
			if (SaveChart != null) h.Add("saveChart",SaveChart);
			if (Segment != null) h.Add("segment",Segment);
			if (SimpleShapes != null) h.Add("simpleShapes",SimpleShapes);
			if (TimeCycles != null) h.Add("timeCycles",TimeCycles);
			if (ToggleAnnotations != null) h.Add("toggleAnnotations",ToggleAnnotations);
			if (TypeCandlestick != null) h.Add("typeCandlestick",TypeCandlestick);
			if (TypeChange != null) h.Add("typeChange",TypeChange);
			if (TypeHeikinAshi != null) h.Add("typeHeikinAshi",TypeHeikinAshi);
			if (TypeHLC != null) h.Add("typeHLC",TypeHLC);
			if (TypeHollowCandlestick != null) h.Add("typeHollowCandlestick",TypeHollowCandlestick);
			if (TypeLine != null) h.Add("typeLine",TypeLine);
			if (TypeOHLC != null) h.Add("typeOHLC",TypeOHLC);
			if (VerticalArrow != null) h.Add("verticalArrow",VerticalArrow);
			if (VerticalCounter != null) h.Add("verticalCounter",VerticalCounter);
			if (VerticalLabel != null) h.Add("verticalLabel",VerticalLabel);
			if (VerticalLabels != null) h.Add("verticalLabels",VerticalLabels);
			if (VerticalLine != null) h.Add("verticalLine",VerticalLine);
			if (ZoomChange != null) h.Add("zoomChange",ZoomChange);
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