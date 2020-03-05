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
	public partial class PlotOptionsNetworkgraphMarkerStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsNetworkgraphMarkerStates()
		{
			Inactive = Inactive_DefaultValue = new PlotOptionsNetworkgraphMarkerStatesInactive();
			
		}	
		

		/// <summary>
		/// The opposite state of a hover for a single point node.Applied to all not connected nodes to the hovered one.
		/// </summary>
		public PlotOptionsNetworkgraphMarkerStatesInactive Inactive { get; set; }
		private PlotOptionsNetworkgraphMarkerStatesInactive Inactive_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Inactive.IsDirty()) h.Add("inactive",Inactive.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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