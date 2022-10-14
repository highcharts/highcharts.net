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
	public partial class PivotpointsSeriesMarkerStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PivotpointsSeriesMarkerStates()
		{
			Hover = Hover_DefaultValue = new PivotpointsSeriesMarkerStatesHover();
			Normal = Normal_DefaultValue = new PivotpointsSeriesMarkerStatesNormal();
			Select = Select_DefaultValue = new PivotpointsSeriesMarkerStatesSelect();
			
		}	
		

		/// <summary>
		/// The hover state for a single point marker.
		/// </summary>
		public PivotpointsSeriesMarkerStatesHover Hover { get; set; }
		private PivotpointsSeriesMarkerStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a single point marker. Currently onlyused for setting animation when returning to normal statefrom hover.
		/// </summary>
		public PivotpointsSeriesMarkerStatesNormal Normal { get; set; }
		private PivotpointsSeriesMarkerStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// The appearance of the point marker when selected. In order toallow a point to be selected, set the`series.allowPointSelect` option to true.
		/// </summary>
		public PivotpointsSeriesMarkerStatesSelect Select { get; set; }
		private PivotpointsSeriesMarkerStatesSelect Select_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty(highstock)) h.Add("hover",Hover.ToHashtable(highstock));
			if (Normal.IsDirty(highstock)) h.Add("normal",Normal.ToHashtable(highstock));
			if (Select.IsDirty(highstock)) h.Add("select",Select.ToHashtable(highstock));
			

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