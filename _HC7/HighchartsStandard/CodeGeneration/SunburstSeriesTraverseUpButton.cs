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
	public partial class SunburstSeriesTraverseUpButton  : BaseObject
	{
		Hashtable h = new Hashtable();

		public SunburstSeriesTraverseUpButton()
		{
		}	
		

		/// <summary>
		/// The position of the button.
		/// </summary>
		public SunburstSeriesTraverseUpButtonPosition Position { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Position != null) h.Add("position",Position.ToHashtable(highcharts));
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