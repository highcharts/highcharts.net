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
			DashStyle = DashStyle_DefaultValue = AnnotationsMeasureTypeOptionsCrosshairXDashStyle.Null;
			Enabled = Enabled_DefaultValue = true;
			MarkerEnd = MarkerEnd_DefaultValue = "arrow";
			ZIndex = ZIndex_DefaultValue = 6;
			
		}	
		

		/// <summary>
		/// The dash or dot style of the crosshair's line. For possiblevalues, see[this demonstration](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/).
		/// </summary>
		public AnnotationsMeasureTypeOptionsCrosshairXDashStyle DashStyle { get; set; }
		private AnnotationsMeasureTypeOptionsCrosshairXDashStyle DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the horizontal crosshair.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The marker-end defines the arrowhead that will be drawnat the final vertex of the given crosshair's path.
		/// </summary>
		public string MarkerEnd { get; set; }
		private string MarkerEnd_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index of the crosshair in annotation.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", highstock.FirstCharacterToLower(DashStyle.ToString()));
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (MarkerEnd != MarkerEnd_DefaultValue) h.Add("markerEnd",MarkerEnd);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			

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