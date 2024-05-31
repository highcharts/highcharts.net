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
	public partial class ChartResetZoomButtonTheme  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartResetZoomButtonTheme()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// zIndex of the button.
		/// </summary>
		public double? ZIndex { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (ZIndex != null) h.Add("zIndex",ZIndex);
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