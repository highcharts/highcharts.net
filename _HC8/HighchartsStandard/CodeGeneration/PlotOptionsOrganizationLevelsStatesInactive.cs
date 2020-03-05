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
	public partial class PlotOptionsOrganizationLevelsStatesInactive  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsOrganizationLevelsStatesInactive()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			LinkOpacity = LinkOpacity_DefaultValue = null;
			Opacity = Opacity_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Opacity for the links between nodes in the sankey diagram ininactive mode.
		/// </summary>
		public double? LinkOpacity { get; set; }
		private double? LinkOpacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (LinkOpacity != LinkOpacity_DefaultValue) h.Add("linkOpacity",LinkOpacity);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			

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