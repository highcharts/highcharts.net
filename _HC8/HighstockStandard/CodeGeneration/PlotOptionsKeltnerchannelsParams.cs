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
	public partial class PlotOptionsKeltnerchannelsParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsKeltnerchannelsParams()
		{
			Index = Index_DefaultValue = 0;
			MultiplierATR = MultiplierATR_DefaultValue = 2;
			Period = Period_DefaultValue = 20;
			PeriodATR = PeriodATR_DefaultValue = 10;
			
		}	
		

		/// <summary>
		/// The point index which indicator calculations will base. Forexample using OHLC data, index=2 means the indicator will becalculated using Low values.
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// The ATR multiplier.
		/// </summary>
		public double? MultiplierATR { get; set; }
		private double? MultiplierATR_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Period { get; set; }
		private double? Period_DefaultValue { get; set; }
		 

		/// <summary>
		/// The ATR period.
		/// </summary>
		public double? PeriodATR { get; set; }
		private double? PeriodATR_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (MultiplierATR != MultiplierATR_DefaultValue) h.Add("multiplierATR",MultiplierATR);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (PeriodATR != PeriodATR_DefaultValue) h.Add("periodATR",PeriodATR);
			

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