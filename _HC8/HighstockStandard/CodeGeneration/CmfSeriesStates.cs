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
	public partial class CmfSeriesStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public CmfSeriesStates()
		{
			Hover = Hover_DefaultValue = new CmfSeriesStatesHover();
			Inactive = Inactive_DefaultValue = new CmfSeriesStatesInactive();
			Normal = Normal_DefaultValue = new CmfSeriesStatesNormal();
			Select = Select_DefaultValue = new CmfSeriesStatesSelect();
			
		}	
		

		/// <summary>
		/// Options for the hovered series. These settings override thenormal state options when a series is moused over or touched.
		/// </summary>
		public CmfSeriesStatesHover Hover { get; set; }
		private CmfSeriesStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public CmfSeriesStatesInactive Inactive { get; set; }
		private CmfSeriesStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public CmfSeriesStatesNormal Normal { get; set; }
		private CmfSeriesStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific options for point in selected states, after beingselected by[allowPointSelect](#plotOptions.series.allowPointSelect)or programmatically.
		/// </summary>
		public CmfSeriesStatesSelect Select { get; set; }
		private CmfSeriesStatesSelect Select_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty(ref highstock)) h.Add("hover",Hover.ToHashtable(ref highstock));
			if (Inactive.IsDirty(ref highstock)) h.Add("inactive",Inactive.ToHashtable(ref highstock));
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