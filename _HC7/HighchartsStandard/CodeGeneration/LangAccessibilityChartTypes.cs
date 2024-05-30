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
			
			CustomFields = new Hashtable();
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
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (BarMultiple != null) h.Add("barMultiple",BarMultiple);
			if (BarSingle != null) h.Add("barSingle",BarSingle);
			if (BoxplotMultiple != null) h.Add("boxplotMultiple",BoxplotMultiple);
			if (BoxplotSingle != null) h.Add("boxplotSingle",BoxplotSingle);
			if (BubbleMultiple != null) h.Add("bubbleMultiple",BubbleMultiple);
			if (BubbleSingle != null) h.Add("bubbleSingle",BubbleSingle);
			if (ColumnMultiple != null) h.Add("columnMultiple",ColumnMultiple);
			if (ColumnSingle != null) h.Add("columnSingle",ColumnSingle);
			if (CombinationChart != null) h.Add("combinationChart",CombinationChart);
			if (DefaultMultiple != null) h.Add("defaultMultiple",DefaultMultiple);
			if (DefaultSingle != null) h.Add("defaultSingle",DefaultSingle);
			if (EmptyChart != null) h.Add("emptyChart",EmptyChart);
			if (LineMultiple != null) h.Add("lineMultiple",LineMultiple);
			if (LineSingle != null) h.Add("lineSingle",LineSingle);
			if (MapTypeDescription != null) h.Add("mapTypeDescription",MapTypeDescription);
			if (PieMultiple != null) h.Add("pieMultiple",PieMultiple);
			if (PieSingle != null) h.Add("pieSingle",PieSingle);
			if (ScatterMultiple != null) h.Add("scatterMultiple",ScatterMultiple);
			if (ScatterSingle != null) h.Add("scatterSingle",ScatterSingle);
			if (SplineMultiple != null) h.Add("splineMultiple",SplineMultiple);
			if (SplineSingle != null) h.Add("splineSingle",SplineSingle);
			if (UnknownMap != null) h.Add("unknownMap",UnknownMap);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}