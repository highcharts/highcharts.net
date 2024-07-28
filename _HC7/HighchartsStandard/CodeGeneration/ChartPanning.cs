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
	public partial class ChartPanning  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartPanning()
		{
		}	
		

		/// <summary>
		/// Enable or disable chart panning.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Decides in what dimensions the user can pan the chart. Can beone of `x`, `y`, or `xy`.When this option is set to `y` or `xy`, [yAxis.startOnTick](#yAxis.startOnTick)and [yAxis.endOnTick](#yAxis.endOnTick) are overwritten to `false`.
		/// </summary>
		public ChartPanningType Type { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Type != ChartPanningType.Null) h.Add("type", highcharts.FirstCharacterToLower(Type.ToString()));
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