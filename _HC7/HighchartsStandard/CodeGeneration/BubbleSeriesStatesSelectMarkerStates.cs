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
	public partial class BubbleSeriesStatesSelectMarkerStates  : BaseObject
	{
		public BubbleSeriesStatesSelectMarkerStates()
		{
			Hover = Hover_DefaultValue = new BubbleSeriesStatesSelectMarkerStatesHover();
			Inactive = Inactive_DefaultValue = new BubbleSeriesStatesSelectMarkerStatesInactive();
			Normal = Normal_DefaultValue = new BubbleSeriesStatesSelectMarkerStatesNormal();
			Select = Select_DefaultValue = new BubbleSeriesStatesSelectMarkerStatesSelect();
			
		}	
		

		/// <summary>
		/// The hover state for a single point marker.
		/// </summary>
		public BubbleSeriesStatesSelectMarkerStatesHover Hover { get; set; }
		private BubbleSeriesStatesSelectMarkerStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public BubbleSeriesStatesSelectMarkerStatesInactive Inactive { get; set; }
		private BubbleSeriesStatesSelectMarkerStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a single point marker. Currently onlyused for setting animation when returning to normal statefrom hover.
		/// </summary>
		public BubbleSeriesStatesSelectMarkerStatesNormal Normal { get; set; }
		private BubbleSeriesStatesSelectMarkerStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// The appearance of the point marker when selected. In order toallow a point to be selected, set the`series.allowPointSelect` option to true.
		/// </summary>
		public BubbleSeriesStatesSelectMarkerStatesSelect Select { get; set; }
		private BubbleSeriesStatesSelectMarkerStatesSelect Select_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (Inactive.IsDirty()) h.Add("inactive",Inactive.ToHashtable());
			if (Normal.IsDirty()) h.Add("normal",Normal.ToHashtable());
			if (Select.IsDirty()) h.Add("select",Select.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}