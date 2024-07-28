using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PlotOptionsDisparityindexParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsDisparityindexParams()
		{
		}	
		

		/// <summary>
		/// The average used to calculate the Disparity Index indicator.By default it uses SMA, with EMA as an option. To use otheraverages, e.g. TEMA, the `stock/indicators/tema.js` file needs tobe loaded.If value is different than `ema`, `dema`, `tema` or `wma`,then sma is used.
		/// </summary>
		public string Average { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Index { get; set; }
		 

		/// <summary>
		/// The base period for indicator calculations. This is the number ofdata points which are taken into account for the indicatorcalculations.
		/// </summary>
		public double? Period { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Average != null) h.Add("average",Average);
			if (Index != null) h.Add("index",Index);
			if (Period != null) h.Add("period",Period);
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