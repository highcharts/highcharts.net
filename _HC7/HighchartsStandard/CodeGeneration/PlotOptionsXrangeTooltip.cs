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
	public partial class PlotOptionsXrangeTooltip  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsXrangeTooltip()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public double? Distance { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string HeaderFormat { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PointFormat { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Distance != null) h.Add("distance",Distance);
			if (HeaderFormat != null) h.Add("headerFormat",HeaderFormat);
			if (PointFormat != null) h.Add("pointFormat",PointFormat);
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