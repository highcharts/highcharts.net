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
	public partial class LangNavigation  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangNavigation()
		{
		}	
		

		/// <summary>
		/// Translations for all field names used in popup.
		/// </summary>
		public LangNavigationPopup Popup { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Popup != null) h.Add("popup",Popup.ToHashtable(highcharts));
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