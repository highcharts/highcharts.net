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
	public partial class PlotOptionsTrixMarkerStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTrixMarkerStates()
		{
		}	
		

		/// <summary>
		/// The hover state for a single point marker.
		/// </summary>
		public PlotOptionsTrixMarkerStatesHover Hover { get; set; }
		 

		/// <summary>
		/// The normal state of a single point marker. Currently onlyused for setting animation when returning to normal statefrom hover.
		/// </summary>
		public PlotOptionsTrixMarkerStatesNormal Normal { get; set; }
		 

		/// <summary>
		/// The appearance of the point marker when selected. In order toallow a point to be selected, set the`series.allowPointSelect` option to true.
		/// </summary>
		public PlotOptionsTrixMarkerStatesSelect Select { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Hover != null) h.Add("hover",Hover.ToHashtable(highstock));
			if (Normal != null) h.Add("normal",Normal.ToHashtable(highstock));
			if (Select != null) h.Add("select",Select.ToHashtable(highstock));
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