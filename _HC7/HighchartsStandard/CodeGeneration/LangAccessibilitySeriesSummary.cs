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
	public partial class LangAccessibilitySeriesSummary  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilitySeriesSummary()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Bar { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BarCombination { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Boxplot { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BoxplotCombination { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Bubble { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BubbleCombination { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Column { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ColumnCombination { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Default { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DefaultCombination { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Line { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LineCombination { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Map { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Mapbubble { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MapbubbleCombination { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MapCombination { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Mapline { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MaplineCombination { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Pie { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PieCombination { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Scatter { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ScatterCombination { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Spline { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SplineCombination { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Bar != null) h.Add("bar",Bar);
			if (BarCombination != null) h.Add("barCombination",BarCombination);
			if (Boxplot != null) h.Add("boxplot",Boxplot);
			if (BoxplotCombination != null) h.Add("boxplotCombination",BoxplotCombination);
			if (Bubble != null) h.Add("bubble",Bubble);
			if (BubbleCombination != null) h.Add("bubbleCombination",BubbleCombination);
			if (Column != null) h.Add("column",Column);
			if (ColumnCombination != null) h.Add("columnCombination",ColumnCombination);
			if (Default != null) h.Add("default",Default);
			if (DefaultCombination != null) h.Add("defaultCombination",DefaultCombination);
			if (Line != null) h.Add("line",Line);
			if (LineCombination != null) h.Add("lineCombination",LineCombination);
			if (Map != null) h.Add("map",Map);
			if (Mapbubble != null) h.Add("mapbubble",Mapbubble);
			if (MapbubbleCombination != null) h.Add("mapbubbleCombination",MapbubbleCombination);
			if (MapCombination != null) h.Add("mapCombination",MapCombination);
			if (Mapline != null) h.Add("mapline",Mapline);
			if (MaplineCombination != null) h.Add("maplineCombination",MaplineCombination);
			if (Pie != null) h.Add("pie",Pie);
			if (PieCombination != null) h.Add("pieCombination",PieCombination);
			if (Scatter != null) h.Add("scatter",Scatter);
			if (ScatterCombination != null) h.Add("scatterCombination",ScatterCombination);
			if (Spline != null) h.Add("spline",Spline);
			if (SplineCombination != null) h.Add("splineCombination",SplineCombination);
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