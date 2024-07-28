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
	public partial class LangAccessibilityChartTypes  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityChartTypes()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string BarMultiple { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BarSingle { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BoxplotMultiple { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BoxplotSingle { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BubbleMultiple { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BubbleSingle { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ColumnMultiple { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ColumnSingle { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string CombinationChart { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DefaultMultiple { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DefaultSingle { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string EmptyChart { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LineMultiple { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LineSingle { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MapTypeDescription { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PieMultiple { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PieSingle { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ScatterMultiple { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ScatterSingle { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SplineMultiple { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SplineSingle { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string UnknownMap { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
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