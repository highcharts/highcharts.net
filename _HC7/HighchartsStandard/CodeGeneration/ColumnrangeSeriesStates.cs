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
	public partial class ColumnrangeSeriesStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColumnrangeSeriesStates()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public ColumnrangeSeriesStatesHover Hover { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public ColumnrangeSeriesStatesInactive Inactive { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public ColumnrangeSeriesStatesNormal Normal { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColumnrangeSeriesStatesSelect Select { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Hover != null) h.Add("hover",Hover.ToHashtable(highcharts));
			if (Inactive != null) h.Add("inactive",Inactive.ToHashtable(highcharts));
			if (Normal != null) h.Add("normal",Normal.ToHashtable(highcharts));
			if (Select != null) h.Add("select",Select.ToHashtable(highcharts));
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