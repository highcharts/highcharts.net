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
		Hashtable h = new Hashtable();

		public PlotOptionsMacdParams()
		{
		}	
		

		/// <summary>
		/// The point index which indicator calculations will base. Forexample using OHLC data, index=2 means the indicator will becalculated using Low values.
		/// </summary>
		public double? Index { get; set; }
		 

		/// <summary>
		/// The long period for indicator calculations.
		/// </summary>
		public double? LongPeriod { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Period { get; set; }
		 

		/// <summary>
		/// The short period for indicator calculations.
		/// </summary>
		public double? ShortPeriod { get; set; }
		 

		/// <summary>
		/// The base period for signal calculations.
		/// </summary>
		public double? SignalPeriod { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Index != null) h.Add("index",Index);
			if (LongPeriod != null) h.Add("longPeriod",LongPeriod);
			if (Period != null) h.Add("period",Period);
			if (ShortPeriod != null) h.Add("shortPeriod",ShortPeriod);
			if (SignalPeriod != null) h.Add("signalPeriod",SignalPeriod);
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