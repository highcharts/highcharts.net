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
			AnnouncementFormatter = AnnouncementFormatter_DefaultValue = "";
			Enabled = Enabled_DefaultValue = false;
			InterruptUser = InterruptUser_DefaultValue = false;
			MinAnnounceInterval = MinAnnounceInterval_DefaultValue = 5000;
			
		}	
		

		/// <summary>
		/// Optional formatter callback for the announcement. Receivesup to three arguments. The first argument is always an arrayof all series that received updates. If an announcement isalready queued, the series that received updates for thatannouncement are also included in this array. The secondargument is provided if `chart.addSeries` was called, andthere is a new series. In that case, this argument is areference to the new series. The third argument, similarly,is provided if `series.addPoint` was called, and there is anew point. In that case, this argument is a reference to thenew point.The function should return a string with the text to announceto the user. Return empty string to not announce anything.Return `false` to use the default announcement format.
		/// </summary>
		public string AnnouncementFormatter { get; set; }
		private string AnnouncementFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable announcing new data to screen reader users
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Choose whether or not the announcements should interrupt thescreen reader. If not enabled, the user will be notified onceidle. It is recommended not to enable this setting unlessthere is a specific reason to do so.
		/// </summary>
		public bool? InterruptUser { get; set; }
		private bool? InterruptUser_DefaultValue { get; set; }
		 

		/// <summary>
		/// Minimum interval between announcements in milliseconds. Ifnew data arrives before this amount of time has passed, it isqueued for announcement. If another new data event happenswhile an announcement is queued, the queued announcement isdropped, and the latest announcement is queued instead. Setto 0 to allow all announcements, but be warned that frequentannouncements are disturbing to users.
		/// </summary>
		public double? MinAnnounceInterval { get; set; }
		private double? MinAnnounceInterval_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (AnnouncementFormatter != AnnouncementFormatter_DefaultValue) h.Add("announcementFormatter",AnnouncementFormatter);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (InterruptUser != InterruptUser_DefaultValue) h.Add("interruptUser",InterruptUser);
			if (MinAnnounceInterval != MinAnnounceInterval_DefaultValue) h.Add("minAnnounceInterval",MinAnnounceInterval);
			

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