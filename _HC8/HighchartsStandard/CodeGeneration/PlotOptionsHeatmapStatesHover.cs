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
	public partial class PlotOptionsHeatmapStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsHeatmapStatesHover()
		{
			Brightness = Brightness_DefaultValue = new Hashtable();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// How much to brighten the point on interaction. Requires themain color to be defined in hex or rgb(a) format.In styled mode, the hover brightening is by default replacedwith a fill-opacity set in the `.highcharts-point:hover`rule.
		/// </summary>
		public Hashtable Brightness { get; set; }
		private Hashtable Brightness_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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