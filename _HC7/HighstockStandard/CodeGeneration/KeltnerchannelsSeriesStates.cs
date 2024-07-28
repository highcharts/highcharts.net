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
	public partial class KeltnerchannelsSeriesStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public KeltnerchannelsSeriesStates()
		{
		}	
		

		/// <summary>
		/// Options for the hovered series. These settings override thenormal state options when a series is moused over or touched.
		/// </summary>
		public KeltnerchannelsSeriesStatesHover Hover { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public KeltnerchannelsSeriesStatesInactive Inactive { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public KeltnerchannelsSeriesStatesNormal Normal { get; set; }
		 

		/// <summary>
		/// Specific options for point in selected states, after beingselected by[allowPointSelect](#plotOptions.series.allowPointSelect)or programmatically.
		/// </summary>
		public KeltnerchannelsSeriesStatesSelect Select { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Hover != null) h.Add("hover",Hover.ToHashtable(highstock));
			if (Inactive != null) h.Add("inactive",Inactive.ToHashtable(highstock));
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