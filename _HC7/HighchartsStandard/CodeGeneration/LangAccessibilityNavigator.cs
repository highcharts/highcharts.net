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
	public partial class LangAccessibilityNavigator  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityNavigator()
		{
			ChangeAnnouncement = ChangeAnnouncement_DefaultValue = "{axisRangeDescription}";
			GroupLabel = GroupLabel_DefaultValue = "Axis zoom";
			HandleLabel = HandleLabel_DefaultValue = "{#eq handleIx 0}Start, percent{else}End, percent{/eq}";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Announcement for assistive technology when navigator valuesare changed.Receives `axisRangeDescription` and `chart` as context.`axisRangeDescription` corresponds to the range descriptiondefined in [lang.accessibility.axis](#lang.accessibility.axis)
		/// </summary>
		public string ChangeAnnouncement { get; set; }
		private string ChangeAnnouncement_DefaultValue { get; set; }
		 

		/// <summary>
		/// Label for the navigator region.Receives `chart` as context.
		/// </summary>
		public string GroupLabel { get; set; }
		private string GroupLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// Label for the navigator handles.Receives `handleIx` and `chart` as context.`handleIx` refers to the index of the navigator handle.
		/// </summary>
		public string HandleLabel { get; set; }
		private string HandleLabel_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (ChangeAnnouncement != ChangeAnnouncement_DefaultValue) h.Add("changeAnnouncement",ChangeAnnouncement);
			if (GroupLabel != GroupLabel_DefaultValue) h.Add("groupLabel",GroupLabel);
			if (HandleLabel != HandleLabel_DefaultValue) h.Add("handleLabel",HandleLabel);
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