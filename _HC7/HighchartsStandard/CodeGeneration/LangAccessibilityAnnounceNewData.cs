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
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string NewDataAnnounce { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string NewPointAnnounceMultiple { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string NewPointAnnounceSingle { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string NewSeriesAnnounceMultiple { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string NewSeriesAnnounceSingle { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (NewDataAnnounce != null) h.Add("newDataAnnounce",NewDataAnnounce);
			if (NewPointAnnounceMultiple != null) h.Add("newPointAnnounceMultiple",NewPointAnnounceMultiple);
			if (NewPointAnnounceSingle != null) h.Add("newPointAnnounceSingle",NewPointAnnounceSingle);
			if (NewSeriesAnnounceMultiple != null) h.Add("newSeriesAnnounceMultiple",NewSeriesAnnounceMultiple);
			if (NewSeriesAnnounceSingle != null) h.Add("newSeriesAnnounceSingle",NewSeriesAnnounceSingle);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}