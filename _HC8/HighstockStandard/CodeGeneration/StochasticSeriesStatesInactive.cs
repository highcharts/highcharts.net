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
	public partial class StochasticSeriesStatesInactive  : BaseObject
	{
		Hashtable h = new Hashtable();

		public StochasticSeriesStatesInactive()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Enabled = Enabled_DefaultValue = new Hashtable();
			Opacity = Opacity_DefaultValue = new Hashtable();
			
		}	
		

		/// <summary>
		/// The animation for entering the inactive state.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the inactive state for a series
		/// </summary>
		public Hashtable Enabled { get; set; }
		private Hashtable Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Opacity of series elements (dataLabels, line, area).
		/// </summary>
		public Hashtable Opacity { get; set; }
		private Hashtable Opacity_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
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