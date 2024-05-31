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
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Announcement for assistive technology when navigator valuesare changed.Receives `axisRangeDescription` and `chart` as context.`axisRangeDescription` corresponds to the range descriptiondefined in [lang.accessibility.axis](#lang.accessibility.axis)
		/// </summary>
		public string ChangeAnnouncement { get; set; }
		 

		/// <summary>
		/// Label for the navigator region.Receives `chart` as context.
		/// </summary>
		public string GroupLabel { get; set; }
		 

		/// <summary>
		/// Label for the navigator handles.Receives `handleIx` and `chart` as context.`handleIx` refers to the index of the navigator handle.
		/// </summary>
		public string HandleLabel { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (ChangeAnnouncement != null) h.Add("changeAnnouncement",ChangeAnnouncement);
			if (GroupLabel != null) h.Add("groupLabel",GroupLabel);
			if (HandleLabel != null) h.Add("handleLabel",HandleLabel);
			if (CustomFields.Count > 0)
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