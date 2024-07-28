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
	public partial class ColumnSeriesStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColumnSeriesStates()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public ColumnSeriesStatesHover Hover { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public ColumnSeriesStatesInactive Inactive { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public ColumnSeriesStatesNormal Normal { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColumnSeriesStatesSelect Select { get; set; }
		  

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