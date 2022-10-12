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
	public partial class LangAccessibilitySeriesSummary  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilitySeriesSummary()
		{
			Bar = Bar_DefaultValue = "{series.name}, bar series {seriesNumber} of {chart.series.length} with {series.points.length} {#plural(series.points.length, bars, bar)}.";
			BarCombination = BarCombination_DefaultValue = "{series.name}, series {seriesNumber} of {chart.series.length}. Bar series with {series.points.length} {#plural(series.points.length, bars, bar)}.";
			Boxplot = Boxplot_DefaultValue = "{series.name}, boxplot {seriesNumber} of {chart.series.length} with {series.points.length} {#plural(series.points.length, boxes, box)}.";
			BoxplotCombination = BoxplotCombination_DefaultValue = "{series.name}, series {seriesNumber} of {chart.series.length}. Boxplot with {series.points.length} {#plural(series.points.length, boxes, box)}.";
			Bubble = Bubble_DefaultValue = "{series.name}, bubble series {seriesNumber} of {chart.series.length} with {series.points.length} {#plural(series.points.length, bubbles, bubble)}.";
			BubbleCombination = BubbleCombination_DefaultValue = "{series.name}, series {seriesNumber} of {chart.series.length}. Bubble series with {series.points.length} {#plural(series.points.length, bubbles, bubble)}.";
			Column = Column_DefaultValue = "{series.name}, bar series {seriesNumber} of {chart.series.length} with {series.points.length} {#plural(series.points.length, bars, bar)}.";
			ColumnCombination = ColumnCombination_DefaultValue = "{series.name}, series {seriesNumber} of {chart.series.length}. Bar series with {series.points.length} {#plural(series.points.length, bars, bar)}.";
			Default = Default_DefaultValue = "{series.name}, series {seriesNumber} of {chart.series.length} with {series.points.length} data {#plural(series.points.length, points, point)}.";
			DefaultCombination = DefaultCombination_DefaultValue = "{series.name}, series {seriesNumber} of {chart.series.length} with {series.points.length} data {#plural(series.points.length, points, point)}.";
			Line = Line_DefaultValue = "{series.name}, line {seriesNumber} of {chart.series.length} with {series.points.length} data {#plural(series.points.length, points, point)}.";
			LineCombination = LineCombination_DefaultValue = "{series.name}, series {seriesNumber} of {chart.series.length}. Line with {series.points.length} data {#plural(series.points.length, points, point)}.";
			Map = Map_DefaultValue = "{series.name}, map {seriesNumber} of {chart.series.length} with {series.points.length} {#plural(series.points.length, areas, area)}.";
			Mapbubble = Mapbubble_DefaultValue = "{series.name}, bubble series {seriesNumber} of {chart.series.length} with {series.points.length} {#plural(series.points.length, bubbles, bubble)}.";
			MapbubbleCombination = MapbubbleCombination_DefaultValue = "{series.name}, series {seriesNumber} of {chart.series.length}. Bubble series with {series.points.length} {#plural(series.points.length, bubbles, bubble)}.";
			MapCombination = MapCombination_DefaultValue = "{series.name}, series {seriesNumber} of {chart.series.length}. Map with {series.points.length} {#plural(series.points.length, areas, area)}.";
			Mapline = Mapline_DefaultValue = "{series.name}, line {seriesNumber} of {chart.series.length} with {series.points.length} data {#plural(series.points.length, points, point)}.";
			MaplineCombination = MaplineCombination_DefaultValue = "{series.name}, series {seriesNumber} of {chart.series.length}. Line with {series.points.length} data {#plural(series.points.length, points, point)}.";
			Pie = Pie_DefaultValue = "{series.name}, pie {seriesNumber} of {chart.series.length} with {series.points.length} {#plural(series.points.length, slices, slice)}.";
			PieCombination = PieCombination_DefaultValue = "{series.name}, series {seriesNumber} of {chart.series.length}. Pie with {series.points.length} {#plural(series.points.length, slices, slice)}.";
			Scatter = Scatter_DefaultValue = "{series.name}, scatter plot {seriesNumber} of {chart.series.length} with {series.points.length} {#plural(series.points.length, points, point)}.";
			ScatterCombination = ScatterCombination_DefaultValue = "{series.name}, series {seriesNumber} of {chart.series.length}, scatter plot with {series.points.length} {#plural(series.points.length, points, point)}.";
			Spline = Spline_DefaultValue = "{series.name}, line {seriesNumber} of {chart.series.length} with {series.points.length} data {#plural(series.points.length, points, point)}.";
			SplineCombination = SplineCombination_DefaultValue = "{series.name}, series {seriesNumber} of {chart.series.length}. Line with {series.points.length} data {#plural(series.points.length, points, point)}.";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Bar { get; set; }
		private string Bar_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BarCombination { get; set; }
		private string BarCombination_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Boxplot { get; set; }
		private string Boxplot_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BoxplotCombination { get; set; }
		private string BoxplotCombination_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Bubble { get; set; }
		private string Bubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BubbleCombination { get; set; }
		private string BubbleCombination_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Column { get; set; }
		private string Column_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ColumnCombination { get; set; }
		private string ColumnCombination_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Default { get; set; }
		private string Default_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DefaultCombination { get; set; }
		private string DefaultCombination_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Line { get; set; }
		private string Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LineCombination { get; set; }
		private string LineCombination_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Map { get; set; }
		private string Map_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Mapbubble { get; set; }
		private string Mapbubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MapbubbleCombination { get; set; }
		private string MapbubbleCombination_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MapCombination { get; set; }
		private string MapCombination_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Mapline { get; set; }
		private string Mapline_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MaplineCombination { get; set; }
		private string MaplineCombination_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Pie { get; set; }
		private string Pie_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PieCombination { get; set; }
		private string PieCombination_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Scatter { get; set; }
		private string Scatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ScatterCombination { get; set; }
		private string ScatterCombination_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Spline { get; set; }
		private string Spline_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SplineCombination { get; set; }
		private string SplineCombination_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Bar != Bar_DefaultValue) h.Add("bar",Bar);
			if (BarCombination != BarCombination_DefaultValue) h.Add("barCombination",BarCombination);
			if (Boxplot != Boxplot_DefaultValue) h.Add("boxplot",Boxplot);
			if (BoxplotCombination != BoxplotCombination_DefaultValue) h.Add("boxplotCombination",BoxplotCombination);
			if (Bubble != Bubble_DefaultValue) h.Add("bubble",Bubble);
			if (BubbleCombination != BubbleCombination_DefaultValue) h.Add("bubbleCombination",BubbleCombination);
			if (Column != Column_DefaultValue) h.Add("column",Column);
			if (ColumnCombination != ColumnCombination_DefaultValue) h.Add("columnCombination",ColumnCombination);
			if (Default != Default_DefaultValue) h.Add("default",Default);
			if (DefaultCombination != DefaultCombination_DefaultValue) h.Add("defaultCombination",DefaultCombination);
			if (Line != Line_DefaultValue) h.Add("line",Line);
			if (LineCombination != LineCombination_DefaultValue) h.Add("lineCombination",LineCombination);
			if (Map != Map_DefaultValue) h.Add("map",Map);
			if (Mapbubble != Mapbubble_DefaultValue) h.Add("mapbubble",Mapbubble);
			if (MapbubbleCombination != MapbubbleCombination_DefaultValue) h.Add("mapbubbleCombination",MapbubbleCombination);
			if (MapCombination != MapCombination_DefaultValue) h.Add("mapCombination",MapCombination);
			if (Mapline != Mapline_DefaultValue) h.Add("mapline",Mapline);
			if (MaplineCombination != MaplineCombination_DefaultValue) h.Add("maplineCombination",MaplineCombination);
			if (Pie != Pie_DefaultValue) h.Add("pie",Pie);
			if (PieCombination != PieCombination_DefaultValue) h.Add("pieCombination",PieCombination);
			if (Scatter != Scatter_DefaultValue) h.Add("scatter",Scatter);
			if (ScatterCombination != ScatterCombination_DefaultValue) h.Add("scatterCombination",ScatterCombination);
			if (Spline != Spline_DefaultValue) h.Add("spline",Spline);
			if (SplineCombination != SplineCombination_DefaultValue) h.Add("splineCombination",SplineCombination);
			

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