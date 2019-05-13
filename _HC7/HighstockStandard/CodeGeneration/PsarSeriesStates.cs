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
	public partial class PsarSeriesStates  : BaseObject
	{
		public PsarSeriesStates()
		{
			Hover = Hover_DefaultValue = new PsarSeriesStatesHover();
			Inactive = Inactive_DefaultValue = new PsarSeriesStatesInactive();
			Normal = Normal_DefaultValue = new PsarSeriesStatesNormal();
			
		}	
		

		/// <summary>
		/// Options for the hovered series. These settings override thenormal state options when a series is moused over or touched.
		/// </summary>
		public PsarSeriesStatesHover Hover { get; set; }
		private PsarSeriesStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public PsarSeriesStatesInactive Inactive { get; set; }
		private PsarSeriesStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public PsarSeriesStatesNormal Normal { get; set; }
		private PsarSeriesStatesNormal Normal_DefaultValue { get; set; }
		  

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