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
	public partial class PlotOptionsWindbarbTooltip  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsWindbarbTooltip()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public double? Distance { get; set; }
		 

		/// <summary>
		/// The default point format for the wind barb tooltip. Note the`point.beaufort` property that refers to the Beaufort wind scale.The names can be internationalized by modifying`Highcharts.seriesTypes.windbarb.prototype.beaufortNames`.
		/// </summary>
		public string PointFormat { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Distance != null) h.Add("distance",Distance);
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