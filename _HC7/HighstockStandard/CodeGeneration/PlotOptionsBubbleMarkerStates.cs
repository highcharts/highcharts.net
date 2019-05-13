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
	public partial class PlotOptionsBubbleMarkerStates  : BaseObject
	{
		public PlotOptionsBubbleMarkerStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsBubbleMarkerStatesHover();
			Inactive = Inactive_DefaultValue = new PlotOptionsBubbleMarkerStatesInactive();
			Normal = Normal_DefaultValue = new PlotOptionsBubbleMarkerStatesNormal();
			Select = Select_DefaultValue = new PlotOptionsBubbleMarkerStatesSelect();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleMarkerStatesHover Hover { get; set; }
		private PlotOptionsBubbleMarkerStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleMarkerStatesInactive Inactive { get; set; }
		private PlotOptionsBubbleMarkerStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a single point marker. Currently onlyused for setting animation when returning to normal statefrom hover.
		/// </summary>
		public PlotOptionsBubbleMarkerStatesNormal Normal { get; set; }
		private PlotOptionsBubbleMarkerStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// The appearance of the point marker when selected. In order toallow a point to be selected, set the`series.allowPointSelect` option to true.
		/// </summary>
		public PlotOptionsBubbleMarkerStatesSelect Select { get; set; }
		private PlotOptionsBubbleMarkerStatesSelect Select_DefaultValue { get; set; }
		  

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