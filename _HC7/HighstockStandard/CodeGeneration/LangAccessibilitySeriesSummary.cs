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
		public LangAccessibilitySeriesSummary()
		{
			Bar = Bar_DefaultValue = "{name}, bar series {ix} of {numSeries} with {numPoints} {#plural(numPoints, bars, bar)}.";
			BarCombination = BarCombination_DefaultValue = "{name}, series {ix} of {numSeries}. Bar series with {numPoints} {#plural(numPoints, bars, bar)}.";
			Boxplot = Boxplot_DefaultValue = "{name}, boxplot {ix} of {numSeries} with {numPoints} {#plural(numPoints, boxes, box)}.";
			BoxplotCombination = BoxplotCombination_DefaultValue = "{name}, series {ix} of {numSeries}. Boxplot with {numPoints} {#plural(numPoints, boxes, box)}.";
			Bubble = Bubble_DefaultValue = "{name}, bubble series {ix} of {numSeries} with {numPoints} {#plural(numPoints, bubbles, bubble)}.";
			BubbleCombination = BubbleCombination_DefaultValue = "{name}, series {ix} of {numSeries}. Bubble series with {numPoints} {#plural(numPoints, bubbles, bubble)}.";
			Column = Column_DefaultValue = "{name}, bar series {ix} of {numSeries} with {numPoints} {#plural(numPoints, bars, bar)}.";
			ColumnCombination = ColumnCombination_DefaultValue = "{name}, series {ix} of {numSeries}. Bar series with {numPoints} {#plural(numPoints, bars, bar)}.";
			Default = Default_DefaultValue = "{name}, series {ix} of {numSeries} with {numPoints} data {#plural(numPoints, points, point)}.";
			DefaultCombination = DefaultCombination_DefaultValue = "{name}, series {ix} of {numSeries} with {numPoints} data {#plural(numPoints, points, point)}.";
			Line = Line_DefaultValue = "{name}, line {ix} of {numSeries} with {numPoints} data {#plural(numPoints, points, point)}.";
			LineCombination = LineCombination_DefaultValue = "{name}, series {ix} of {numSeries}. Line with {numPoints} data {#plural(numPoints, points, point)}.";
			Map = Map_DefaultValue = "{name}, map {ix} of {numSeries} with {numPoints} {#plural(numPoints, areas, area)}.";
			Mapbubble = Mapbubble_DefaultValue = "{name}, bubble series {ix} of {numSeries} with {numPoints} {#plural(numPoints, bubbles, bubble)}.";
			MapbubbleCombination = MapbubbleCombination_DefaultValue = "{name}, series {ix} of {numSeries}. Bubble series with {numPoints} {#plural(numPoints, bubbles, bubble)}.";
			MapCombination = MapCombination_DefaultValue = "{name}, series {ix} of {numSeries}. Map with {numPoints} {#plural(numPoints, areas, area)}.";
			Mapline = Mapline_DefaultValue = "{name}, line {ix} of {numSeries} with {numPoints} data {#plural(numPoints, points, point)}.";
			MaplineCombination = MaplineCombination_DefaultValue = "{name}, series {ix} of {numSeries}. Line with {numPoints} data {#plural(numPoints, points, point)}.";
			Pie = Pie_DefaultValue = "{name}, pie {ix} of {numSeries} with {numPoints} {#plural(numPoints, slices, slice)}.";
			PieCombination = PieCombination_DefaultValue = "{name}, series {ix} of {numSeries}. Pie with {numPoints} {#plural(numPoints, slices, slice)}.";
			Scatter = Scatter_DefaultValue = "{name}, scatter plot {ix} of {numSeries} with {numPoints} {#plural(numPoints, points, point)}.";
			ScatterCombination = ScatterCombination_DefaultValue = "{name}, series {ix} of {numSeries}, scatter plot with {numPoints} {#plural(numPoints, points, point)}.";
			Spline = Spline_DefaultValue = "{name}, line {ix} of {numSeries} with {numPoints} data {#plural(numPoints, points, point)}.";
			SplineCombination = SplineCombination_DefaultValue = "{name}, series {ix} of {numSeries}. Line with {numPoints} data {#plural(numPoints, points, point)}.";
			
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
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

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