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
	public partial class AccessibilityAnnounceNewData  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AccessibilityAnnounceNewData()
		{
		}	
		

		/// <summary>
		/// Optional formatter callback for the announcement. Receivesup to three arguments. The first argument is always an arrayof all series that received updates. If an announcement isalready queued, the series that received updates for thatannouncement are also included in this array. The secondargument is provided if `chart.addSeries` was called, andthere is a new series. In that case, this argument is areference to the new series. The third argument, similarly,is provided if `series.addPoint` was called, and there is anew point. In that case, this argument is a reference to thenew point.The function should return a string with the text to announceto the user. Return empty string to not announce anything.Return `false` to use the default announcement format.
		/// </summary>
		public string AnnouncementFormatter { get; set; }
		 

		/// <summary>
		/// Enable announcing new data to screen reader users
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Choose whether or not the announcements should interrupt thescreen reader. If not enabled, the user will be notified onceidle. It is recommended not to enable this setting unlessthere is a specific reason to do so.
		/// </summary>
		public bool? InterruptUser { get; set; }
		 

		/// <summary>
		/// Minimum interval between announcements in milliseconds. Ifnew data arrives before this amount of time has passed, it isqueued for announcement. If another new data event happenswhile an announcement is queued, the queued announcement isdropped, and the latest announcement is queued instead. Setto 0 to allow all announcements, but be warned that frequentannouncements are disturbing to users.
		/// </summary>
		public double? MinAnnounceInterval { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (AnnouncementFormatter != null) { h.Add("announcementFormatter",AnnouncementFormatter); highstock.AddFunction("announcementFormatter", AnnouncementFormatter); }  
			if (Enabled != null) h.Add("enabled",Enabled);
			if (InterruptUser != null) h.Add("interruptUser",InterruptUser);
			if (MinAnnounceInterval != null) h.Add("minAnnounceInterval",MinAnnounceInterval);
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