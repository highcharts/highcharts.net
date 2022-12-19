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
	public partial class PlotOptionsPyramid3dStatesHoverMarkerStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPyramid3dStatesHoverMarkerStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsPyramid3dStatesHoverMarkerStatesHover();
			Normal = Normal_DefaultValue = new PlotOptionsPyramid3dStatesHoverMarkerStatesNormal();
			Select = Select_DefaultValue = new PlotOptionsPyramid3dStatesHoverMarkerStatesSelect();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The hover state for a single point marker.
		/// </summary>
		public PlotOptionsPyramid3dStatesHoverMarkerStatesHover Hover { get; set; }
		private PlotOptionsPyramid3dStatesHoverMarkerStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a single point marker. Currently onlyused for setting animation when returning to normal statefrom hover.
		/// </summary>
		public PlotOptionsPyramid3dStatesHoverMarkerStatesNormal Normal { get; set; }
		private PlotOptionsPyramid3dStatesHoverMarkerStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// The appearance of the point marker when selected. In order toallow a point to be selected, set the`series.allowPointSelect` option to true.
		/// </summary>
		public PlotOptionsPyramid3dStatesHoverMarkerStatesSelect Select { get; set; }
		private PlotOptionsPyramid3dStatesHoverMarkerStatesSelect Select_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty(highcharts)) h.Add("hover",Hover.ToHashtable(highcharts));
			if (Normal.IsDirty(highcharts)) h.Add("normal",Normal.ToHashtable(highcharts));
			if (Select.IsDirty(highcharts)) h.Add("select",Select.ToHashtable(highcharts));
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