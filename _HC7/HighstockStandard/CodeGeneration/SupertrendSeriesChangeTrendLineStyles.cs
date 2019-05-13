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
	public partial class SupertrendSeriesChangeTrendLineStyles  : BaseObject
	{
		public SupertrendSeriesChangeTrendLineStyles()
		{
			DashStyle = DashStyle_DefaultValue = "LongDash";
			LineColor = LineColor_DefaultValue = "#333333";
			LineWidth = LineWidth_DefaultValue = 1;
			
		}	
		

		/// <summary>
		/// The dash or dot style of the grid lines. For possiblevalues, see[this demonstration](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/).
		/// </summary>
		public string DashStyle { get; set; }
		private string DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the line.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pixel width of the line.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle",DashStyle);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			

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