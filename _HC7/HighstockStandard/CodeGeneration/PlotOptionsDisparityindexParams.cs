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
			Average = Average_DefaultValue = "sma";
			Index = Index_DefaultValue = 3;
			Period = Period_DefaultValue = 14;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The average used to calculate the Disparity Index indicator.By default it uses SMA, with EMA as an option. To use otheraverages, e.g. TEMA, the `stock/indicators/tema.js` file needs tobe loaded.If value is different than `ema`, `dema`, `tema` or `wma`,then sma is used.
		/// </summary>
		public string Average { get; set; }
		private string Average_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// The base period for indicator calculations. This is the number ofdata points which are taken into account for the indicatorcalculations.
		/// </summary>
		public double? Period { get; set; }
		private double? Period_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Average != Average_DefaultValue) h.Add("average",Average);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}