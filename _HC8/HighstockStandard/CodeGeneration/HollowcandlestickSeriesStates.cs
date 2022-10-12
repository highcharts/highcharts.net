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
	public partial class HollowcandlestickSeriesStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public HollowcandlestickSeriesStates()
		{
			Hover = Hover_DefaultValue = new HollowcandlestickSeriesStatesHover();
			Inactive = Inactive_DefaultValue = new HollowcandlestickSeriesStatesInactive();
			Normal = Normal_DefaultValue = new HollowcandlestickSeriesStatesNormal();
			Select = Select_DefaultValue = new HollowcandlestickSeriesStatesSelect();
			
		}	
		

		/// <summary>
		/// Options for the hovered series. These settings override thenormal state options when a series is moused over or touched.
		/// </summary>
		public HollowcandlestickSeriesStatesHover Hover { get; set; }
		private HollowcandlestickSeriesStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public HollowcandlestickSeriesStatesInactive Inactive { get; set; }
		private HollowcandlestickSeriesStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public HollowcandlestickSeriesStatesNormal Normal { get; set; }
		private HollowcandlestickSeriesStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific options for point in selected states, after beingselected by[allowPointSelect](#plotOptions.series.allowPointSelect)or programmatically.
		/// </summary>
		public HollowcandlestickSeriesStatesSelect Select { get; set; }
		private HollowcandlestickSeriesStatesSelect Select_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty(ref highstock)) h.Add("hover",Hover.ToHashtable(ref highstock));
			if (Inactive.IsDirty(ref highstock)) h.Add("inactive",Inactive.ToHashtable(ref highstock));
			if (Normal.IsDirty(ref highstock)) h.Add("normal",Normal.ToHashtable(ref highstock));
			if (Select.IsDirty(ref highstock)) h.Add("select",Select.ToHashtable(ref highstock));
			

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