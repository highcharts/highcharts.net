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
	public partial class LangAccessibilityAnnounceNewData  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityAnnounceNewData()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string NewDataAnnounce { get; set; }
		private string NewDataAnnounce_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string NewPointAnnounceMultiple { get; set; }
		private string NewPointAnnounceMultiple_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string NewPointAnnounceSingle { get; set; }
		private string NewPointAnnounceSingle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string NewSeriesAnnounceMultiple { get; set; }
		private string NewSeriesAnnounceMultiple_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string NewSeriesAnnounceSingle { get; set; }
		private string NewSeriesAnnounceSingle_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (NewDataAnnounce != null) h.Add("newDataAnnounce",NewDataAnnounce);
			if (NewPointAnnounceMultiple != null) h.Add("newPointAnnounceMultiple",NewPointAnnounceMultiple);
			if (NewPointAnnounceSingle != null) h.Add("newPointAnnounceSingle",NewPointAnnounceSingle);
			if (NewSeriesAnnounceMultiple != null) h.Add("newSeriesAnnounceMultiple",NewSeriesAnnounceMultiple);
			if (NewSeriesAnnounceSingle != null) h.Add("newSeriesAnnounceSingle",NewSeriesAnnounceSingle);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}