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
	public partial class LangAccessibilityRangeSelector  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityRangeSelector()
		{
			ClickButtonAnnouncement = ClickButtonAnnouncement_DefaultValue = "Viewing {axisRangeDescription}";
			DropdownLabel = DropdownLabel_DefaultValue = "{rangeTitle}";
			MaxInputLabel = MaxInputLabel_DefaultValue = "Select end date.";
			MinInputLabel = MinInputLabel_DefaultValue = "Select start date.";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string ClickButtonAnnouncement { get; set; }
		private string ClickButtonAnnouncement_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DropdownLabel { get; set; }
		private string DropdownLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MaxInputLabel { get; set; }
		private string MaxInputLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MinInputLabel { get; set; }
		private string MinInputLabel_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (ClickButtonAnnouncement != ClickButtonAnnouncement_DefaultValue) h.Add("clickButtonAnnouncement",ClickButtonAnnouncement);
			if (DropdownLabel != DropdownLabel_DefaultValue) h.Add("dropdownLabel",DropdownLabel);
			if (MaxInputLabel != MaxInputLabel_DefaultValue) h.Add("maxInputLabel",MaxInputLabel);
			if (MinInputLabel != MinInputLabel_DefaultValue) h.Add("minInputLabel",MinInputLabel);
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