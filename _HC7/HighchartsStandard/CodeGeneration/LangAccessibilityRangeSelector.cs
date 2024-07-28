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
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string ClickButtonAnnouncement { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DropdownLabel { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MaxInputLabel { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MinInputLabel { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (ClickButtonAnnouncement != null) h.Add("clickButtonAnnouncement",ClickButtonAnnouncement);
			if (DropdownLabel != null) h.Add("dropdownLabel",DropdownLabel);
			if (MaxInputLabel != null) h.Add("maxInputLabel",MaxInputLabel);
			if (MinInputLabel != null) h.Add("minInputLabel",MinInputLabel);
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