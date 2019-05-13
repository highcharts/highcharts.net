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
	public partial class FlagsSeriesStatesHoverMarkerStates  : BaseObject
	{
		public FlagsSeriesStatesHoverMarkerStates()
		{
			Hover = Hover_DefaultValue = new FlagsSeriesStatesHoverMarkerStatesHover();
			Inactive = Inactive_DefaultValue = new FlagsSeriesStatesHoverMarkerStatesInactive();
			Normal = Normal_DefaultValue = new FlagsSeriesStatesHoverMarkerStatesNormal();
			Select = Select_DefaultValue = new FlagsSeriesStatesHoverMarkerStatesSelect();
			
		}	
		

		/// <summary>
		/// The hover state for a single point marker.
		/// </summary>
		public FlagsSeriesStatesHoverMarkerStatesHover Hover { get; set; }
		private FlagsSeriesStatesHoverMarkerStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public FlagsSeriesStatesHoverMarkerStatesInactive Inactive { get; set; }
		private FlagsSeriesStatesHoverMarkerStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a single point marker. Currently onlyused for setting animation when returning to normal statefrom hover.
		/// </summary>
		public FlagsSeriesStatesHoverMarkerStatesNormal Normal { get; set; }
		private FlagsSeriesStatesHoverMarkerStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// The appearance of the point marker when selected. In order toallow a point to be selected, set the`series.allowPointSelect` option to true.
		/// </summary>
		public FlagsSeriesStatesHoverMarkerStatesSelect Select { get; set; }
		private FlagsSeriesStatesHoverMarkerStatesSelect Select_DefaultValue { get; set; }
		  

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