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
	public partial class PlotOptionsMacdParams  : BaseObject
	{
		public PlotOptionsMacdParams()
		{
			Index = Index_DefaultValue = 0;
			LongPeriod = LongPeriod_DefaultValue = 26;
			Period = Period_DefaultValue = 26;
			ShortPeriod = ShortPeriod_DefaultValue = 12;
			SignalPeriod = SignalPeriod_DefaultValue = 9;
			
		}	
		

		/// <summary>
		/// The point index which indicator calculations will base. Forexample using OHLC data, index=2 means the indicator will becalculated using Low values.
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// The long period for indicator calculations.
		/// </summary>
		public double? LongPeriod { get; set; }
		private double? LongPeriod_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Period { get; set; }
		private double? Period_DefaultValue { get; set; }
		 

		/// <summary>
		/// The short period for indicator calculations.
		/// </summary>
		public double? ShortPeriod { get; set; }
		private double? ShortPeriod_DefaultValue { get; set; }
		 

		/// <summary>
		/// The base period for signal calculations.
		/// </summary>
		public double? SignalPeriod { get; set; }
		private double? SignalPeriod_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (LongPeriod != LongPeriod_DefaultValue) h.Add("longPeriod",LongPeriod);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (ShortPeriod != ShortPeriod_DefaultValue) h.Add("shortPeriod",ShortPeriod);
			if (SignalPeriod != SignalPeriod_DefaultValue) h.Add("signalPeriod",SignalPeriod);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}