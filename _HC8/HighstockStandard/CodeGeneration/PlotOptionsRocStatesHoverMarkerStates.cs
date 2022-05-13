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
	public partial class PlotOptionsRocStatesHoverMarkerStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsRocStatesHoverMarkerStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsRocStatesHoverMarkerStatesHover();
			Normal = Normal_DefaultValue = new PlotOptionsRocStatesHoverMarkerStatesNormal();
			Select = Select_DefaultValue = new PlotOptionsRocStatesHoverMarkerStatesSelect();
			
		}	
		

		/// <summary>
		/// The hover state for a single point marker.
		/// </summary>
		public PlotOptionsRocStatesHoverMarkerStatesHover Hover { get; set; }
		private PlotOptionsRocStatesHoverMarkerStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a single point marker. Currently onlyused for setting animation when returning to normal statefrom hover.
		/// </summary>
		public PlotOptionsRocStatesHoverMarkerStatesNormal Normal { get; set; }
		private PlotOptionsRocStatesHoverMarkerStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// The appearance of the point marker when selected. In order toallow a point to be selected, set the`series.allowPointSelect` option to true.
		/// </summary>
		public PlotOptionsRocStatesHoverMarkerStatesSelect Select { get; set; }
		private PlotOptionsRocStatesHoverMarkerStatesSelect Select_DefaultValue { get; set; }
		  

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