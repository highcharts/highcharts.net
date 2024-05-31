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
	public partial class Loading  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Loading()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The duration in milliseconds of the fade out effect.
		/// </summary>
		public double? HideDuration { get; set; }
		 

		/// <summary>
		/// CSS styles for the loading label `span`.
		/// </summary>
		public Hashtable LabelStyle { get; set; }
		 

		/// <summary>
		/// The duration in milliseconds of the fade in effect.
		/// </summary>
		public double? ShowDuration { get; set; }
		 

		/// <summary>
		/// CSS styles for the loading screen that covers the plot area.In styled mode, the loading label is styled with the`.highcharts-loading` class.
		/// </summary>
		public Hashtable Style { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (HideDuration != null) h.Add("hideDuration",HideDuration);
			if (LabelStyle != null) h.Add("labelStyle",LabelStyle);
			if (ShowDuration != null) h.Add("showDuration",ShowDuration);
			if (Style != null) h.Add("style",Style);
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