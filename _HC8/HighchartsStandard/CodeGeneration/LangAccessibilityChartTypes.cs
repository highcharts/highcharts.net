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
	public partial class LangAccessibilityChartTypes  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityChartTypes()
		{
			BarMultiple = BarMultiple_DefaultValue = "Bar chart with {numSeries} data series.";
			BarSingle = BarSingle_DefaultValue = "Bar chart with {numPoints} {#plural(numPoints, bars, bar)}.";
			BoxplotMultiple = BoxplotMultiple_DefaultValue = "Boxplot with {numSeries} data series.";
			BoxplotSingle = BoxplotSingle_DefaultValue = "Boxplot with {numPoints} {#plural(numPoints, boxes, box)}.";
			BubbleMultiple = BubbleMultiple_DefaultValue = "Bubble chart with {numSeries} data series.";
			BubbleSingle = BubbleSingle_DefaultValue = "Bubble chart with {numPoints} {#plural(numPoints, bubbles, bubble)}.";
			ColumnMultiple = ColumnMultiple_DefaultValue = "Bar chart with {numSeries} data series.";
			ColumnSingle = ColumnSingle_DefaultValue = "Bar chart with {numPoints} {#plural(numPoints, bars, bar)}.";
			CombinationChart = CombinationChart_DefaultValue = "Combination chart with {numSeries} data series.";
			DefaultMultiple = DefaultMultiple_DefaultValue = "Chart with {numSeries} data series.";
			DefaultSingle = DefaultSingle_DefaultValue = "Chart with {numPoints} data {#plural(numPoints, points, point)}.";
			EmptyChart = EmptyChart_DefaultValue = "Empty chart";
			LineMultiple = LineMultiple_DefaultValue = "Line chart with {numSeries} lines.";
			LineSingle = LineSingle_DefaultValue = "Line chart with {numPoints} data {#plural(numPoints, points, point)}.";
			MapTypeDescription = MapTypeDescription_DefaultValue = "Map of {mapTitle} with {numSeries} data series.";
			PieMultiple = PieMultiple_DefaultValue = "Pie chart with {numSeries} pies.";
			PieSingle = PieSingle_DefaultValue = "Pie chart with {numPoints} {#plural(numPoints, slices, slice)}.";
			ScatterMultiple = ScatterMultiple_DefaultValue = "Scatter chart with {numSeries} data series.";
			ScatterSingle = ScatterSingle_DefaultValue = "Scatter chart with {numPoints} {#plural(numPoints, points, point)}.";
			SplineMultiple = SplineMultiple_DefaultValue = "Line chart with {numSeries} lines.";
			SplineSingle = SplineSingle_DefaultValue = "Line chart with {numPoints} data {#plural(numPoints, points, point)}.";
			UnknownMap = UnknownMap_DefaultValue = "Map of unspecified region with {numSeries} data series.";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string BarMultiple { get; set; }
		private string BarMultiple_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BarSingle { get; set; }
		private string BarSingle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BoxplotMultiple { get; set; }
		private string BoxplotMultiple_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BoxplotSingle { get; set; }
		private string BoxplotSingle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BubbleMultiple { get; set; }
		private string BubbleMultiple_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BubbleSingle { get; set; }
		private string BubbleSingle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ColumnMultiple { get; set; }
		private string ColumnMultiple_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ColumnSingle { get; set; }
		private string ColumnSingle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string CombinationChart { get; set; }
		private string CombinationChart_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DefaultMultiple { get; set; }
		private string DefaultMultiple_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DefaultSingle { get; set; }
		private string DefaultSingle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string EmptyChart { get; set; }
		private string EmptyChart_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LineMultiple { get; set; }
		private string LineMultiple_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LineSingle { get; set; }
		private string LineSingle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MapTypeDescription { get; set; }
		private string MapTypeDescription_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PieMultiple { get; set; }
		private string PieMultiple_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PieSingle { get; set; }
		private string PieSingle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ScatterMultiple { get; set; }
		private string ScatterMultiple_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ScatterSingle { get; set; }
		private string ScatterSingle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SplineMultiple { get; set; }
		private string SplineMultiple_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SplineSingle { get; set; }
		private string SplineSingle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string UnknownMap { get; set; }
		private string UnknownMap_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (BarMultiple != BarMultiple_DefaultValue) h.Add("barMultiple",BarMultiple);
			if (BarSingle != BarSingle_DefaultValue) h.Add("barSingle",BarSingle);
			if (BoxplotMultiple != BoxplotMultiple_DefaultValue) h.Add("boxplotMultiple",BoxplotMultiple);
			if (BoxplotSingle != BoxplotSingle_DefaultValue) h.Add("boxplotSingle",BoxplotSingle);
			if (BubbleMultiple != BubbleMultiple_DefaultValue) h.Add("bubbleMultiple",BubbleMultiple);
			if (BubbleSingle != BubbleSingle_DefaultValue) h.Add("bubbleSingle",BubbleSingle);
			if (ColumnMultiple != ColumnMultiple_DefaultValue) h.Add("columnMultiple",ColumnMultiple);
			if (ColumnSingle != ColumnSingle_DefaultValue) h.Add("columnSingle",ColumnSingle);
			if (CombinationChart != CombinationChart_DefaultValue) h.Add("combinationChart",CombinationChart);
			if (DefaultMultiple != DefaultMultiple_DefaultValue) h.Add("defaultMultiple",DefaultMultiple);
			if (DefaultSingle != DefaultSingle_DefaultValue) h.Add("defaultSingle",DefaultSingle);
			if (EmptyChart != EmptyChart_DefaultValue) h.Add("emptyChart",EmptyChart);
			if (LineMultiple != LineMultiple_DefaultValue) h.Add("lineMultiple",LineMultiple);
			if (LineSingle != LineSingle_DefaultValue) h.Add("lineSingle",LineSingle);
			if (MapTypeDescription != MapTypeDescription_DefaultValue) h.Add("mapTypeDescription",MapTypeDescription);
			if (PieMultiple != PieMultiple_DefaultValue) h.Add("pieMultiple",PieMultiple);
			if (PieSingle != PieSingle_DefaultValue) h.Add("pieSingle",PieSingle);
			if (ScatterMultiple != ScatterMultiple_DefaultValue) h.Add("scatterMultiple",ScatterMultiple);
			if (ScatterSingle != ScatterSingle_DefaultValue) h.Add("scatterSingle",ScatterSingle);
			if (SplineMultiple != SplineMultiple_DefaultValue) h.Add("splineMultiple",SplineMultiple);
			if (SplineSingle != SplineSingle_DefaultValue) h.Add("splineSingle",SplineSingle);
			if (UnknownMap != UnknownMap_DefaultValue) h.Add("unknownMap",UnknownMap);
			

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