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
	public partial class LangAccessibilityZoom  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityZoom()
		{
			MapZoomIn = MapZoomIn_DefaultValue = "Zoom chart";
			MapZoomOut = MapZoomOut_DefaultValue = "Zoom out chart";
			ResetZoomButton = ResetZoomButton_DefaultValue = "Reset zoom";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string MapZoomIn { get; set; }
		private string MapZoomIn_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MapZoomOut { get; set; }
		private string MapZoomOut_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ResetZoomButton { get; set; }
		private string ResetZoomButton_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (MapZoomIn != MapZoomIn_DefaultValue) h.Add("mapZoomIn",MapZoomIn);
			if (MapZoomOut != MapZoomOut_DefaultValue) h.Add("mapZoomOut",MapZoomOut);
			if (ResetZoomButton != ResetZoomButton_DefaultValue) h.Add("resetZoomButton",ResetZoomButton);
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