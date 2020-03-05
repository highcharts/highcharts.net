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
	public partial class PlotOptionsNetworkgraphStatesInactive  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsNetworkgraphStatesInactive()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			LinkOpacity = LinkOpacity_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Animation when not hovering over the node.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Opacity of inactive links.
		/// </summary>
		public double? LinkOpacity { get; set; }
		private double? LinkOpacity_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (LinkOpacity != LinkOpacity_DefaultValue) h.Add("linkOpacity",LinkOpacity);
			

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