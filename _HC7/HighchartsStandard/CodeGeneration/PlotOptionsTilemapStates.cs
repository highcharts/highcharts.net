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
	public partial class PlotOptionsTilemapStates  : BaseObject
	{
		public PlotOptionsTilemapStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsTilemapStatesHover();
			Inactive = Inactive_DefaultValue = new PlotOptionsTilemapStatesInactive();
			Normal = Normal_DefaultValue = new PlotOptionsTilemapStatesNormal();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapStatesHover Hover { get; set; }
		private PlotOptionsTilemapStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public PlotOptionsTilemapStatesInactive Inactive { get; set; }
		private PlotOptionsTilemapStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public PlotOptionsTilemapStatesNormal Normal { get; set; }
		private PlotOptionsTilemapStatesNormal Normal_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (Inactive.IsDirty()) h.Add("inactive",Inactive.ToHashtable());
			if (Normal.IsDirty()) h.Add("normal",Normal.ToHashtable());
			

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