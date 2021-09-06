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
			
		}	
		

		/// <summary>
		/// The average used to calculate the Disparity Index indicator.By default it uses SMA. To use other averages, e.g. EMA,the `stock/indicators/ema.js` file needs to be loaded.If value is different than ema|dema|tema|wma, then sma is used.
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
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Average != Average_DefaultValue) h.Add("average",Average);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}