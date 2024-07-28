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
	public partial class ColumnrangeSeriesStatesNormal  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColumnrangeSeriesStatesNormal()
		{
		}	
		

		/// <summary>
		/// Animation when returning to normal state after hovering.
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// Animation when returning to normal state after hovering.
		/// </summary>
		public bool? AnimationBool { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Animation != null) h.Add("animation",Animation.ToHashtable(highcharts));
			if (AnimationBool != null) h.Add("animation",AnimationBool);
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