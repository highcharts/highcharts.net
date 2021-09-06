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
	public partial class StochasticSeriesMarkerStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public StochasticSeriesMarkerStates()
		{
			Hover = Hover_DefaultValue = new StochasticSeriesMarkerStatesHover();
			Normal = Normal_DefaultValue = new StochasticSeriesMarkerStatesNormal();
			Select = Select_DefaultValue = new StochasticSeriesMarkerStatesSelect();
			
		}	
		

		/// <summary>
		/// The hover state for a single point marker.
		/// </summary>
		public StochasticSeriesMarkerStatesHover Hover { get; set; }
		private StochasticSeriesMarkerStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a single point marker. Currently onlyused for setting animation when returning to normal statefrom hover.
		/// </summary>
		public StochasticSeriesMarkerStatesNormal Normal { get; set; }
		private StochasticSeriesMarkerStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// The appearance of the point marker when selected. In order toallow a point to be selected, set the`series.allowPointSelect` option to true.
		/// </summary>
		public StochasticSeriesMarkerStatesSelect Select { get; set; }
		private StochasticSeriesMarkerStatesSelect Select_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty(ref highstock)) h.Add("hover",Hover.ToHashtable(ref highstock));
			if (Normal.IsDirty(ref highstock)) h.Add("normal",Normal.ToHashtable(ref highstock));
			if (Select.IsDirty(ref highstock)) h.Add("select",Select.ToHashtable(ref highstock));
			

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