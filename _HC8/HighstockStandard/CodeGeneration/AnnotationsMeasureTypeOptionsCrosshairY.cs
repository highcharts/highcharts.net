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
	public partial class AnnotationsMeasureTypeOptionsCrosshairY  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsMeasureTypeOptionsCrosshairY()
		{
			DashStyle = DashStyle_DefaultValue = AnnotationsMeasureTypeOptionsCrosshairYDashStyle.Null;
			Enabled = Enabled_DefaultValue = true;
			MarkerEnd = MarkerEnd_DefaultValue = AnnotationsMeasureTypeOptionsCrosshairYMarkerEnd.Arrow;
			ZIndex = ZIndex_DefaultValue = 6;
			
		}	
		

		/// <summary>
		/// The dash or dot style of the crosshair's line. For possiblevalues, see [this demonstration](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/).
		/// </summary>
		public AnnotationsMeasureTypeOptionsCrosshairYDashStyle DashStyle { get; set; }
		private AnnotationsMeasureTypeOptionsCrosshairYDashStyle DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the vertical crosshair.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The marker-end defines the arrowhead that will be drawnat the final vertex of the given crosshair's path.
		/// </summary>
		public AnnotationsMeasureTypeOptionsCrosshairYMarkerEnd MarkerEnd { get; set; }
		private AnnotationsMeasureTypeOptionsCrosshairYMarkerEnd MarkerEnd_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index of the crosshair in annotation.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", Highstock.FirstCharacterToLower(DashStyle.ToString()));
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (MarkerEnd != MarkerEnd_DefaultValue) h.Add("markerEnd", Highstock.FirstCharacterToLower(MarkerEnd.ToString()));
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}