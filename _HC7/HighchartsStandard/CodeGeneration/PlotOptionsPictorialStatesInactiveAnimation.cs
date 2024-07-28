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
	public partial class PlotOptionsPictorialStatesInactiveAnimation  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPictorialStatesInactiveAnimation()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public double? Duration { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Duration != null) h.Add("duration",Duration);
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