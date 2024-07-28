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
	public partial class AnnotationsMeasureTypeOptionsCrosshairX  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsMeasureTypeOptionsCrosshairX()
		{
		}	
		

		/// <summary>
		/// The dash or dot style of the crosshair's line. For possiblevalues, see[this demonstration](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/).
		/// </summary>
		public AnnotationsMeasureTypeOptionsCrosshairXDashStyle DashStyle { get; set; }
		 

		/// <summary>
		/// Enable or disable the horizontal crosshair.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// The marker-end defines the arrowhead that will be drawnat the final vertex of the given crosshair's path.
		/// </summary>
		public string MarkerEnd { get; set; }
		 

		/// <summary>
		/// The Z index of the crosshair in annotation.
		/// </summary>
		public double? ZIndex { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (DashStyle != AnnotationsMeasureTypeOptionsCrosshairXDashStyle.Null) h.Add("dashStyle", highstock.FirstCharacterToLower(DashStyle.ToString()));
			if (Enabled != null) h.Add("enabled",Enabled);
			if (MarkerEnd != null) h.Add("markerEnd",MarkerEnd);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
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