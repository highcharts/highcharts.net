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
	public partial class PlotOptionsMacdSignalLine  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsMacdSignalLine()
		{
			Styles = Styles_DefaultValue = new PlotOptionsMacdSignalLineStyles();
			Zones = Zones_DefaultValue = new PlotOptionsMacdSignalLineZones();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsMacdSignalLineStyles Styles { get; set; }
		private PlotOptionsMacdSignalLineStyles Styles_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsMacdSignalLineZones Zones { get; set; }
		private PlotOptionsMacdSignalLineZones Zones_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Styles.IsDirty(highstock)) h.Add("styles",Styles.ToHashtable(highstock));
			if (Zones.IsDirty(highstock)) h.Add("zones",Zones.ToHashtable(highstock));
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}