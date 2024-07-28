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
	public partial class PlotOptionsKlingerParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsKlingerParams()
		{
		}	
		

		/// <summary>
		/// The fast period for indicator calculations.
		/// </summary>
		public double? FastAvgPeriod { get; set; }
		 

		/// <summary>
		/// The point index which indicator calculations will base. Forexample using OHLC data, index=2 means the indicator will becalculated using Low values.
		/// </summary>
		public double? Index { get; set; }
		 

		/// <summary>
		/// The base period for indicator calculations. This is the number ofdata points which are taken into account for the indicatorcalculations.
		/// </summary>
		public double? Period { get; set; }
		 

		/// <summary>
		/// The base period for signal calculations.
		/// </summary>
		public double? SignalPeriod { get; set; }
		 

		/// <summary>
		/// The slow period for indicator calculations.
		/// </summary>
		public double? SlowAvgPeriod { get; set; }
		 

		/// <summary>
		/// The id of another series to use its data as volume data for theindiator calculation.
		/// </summary>
		public string VolumeSeriesID { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (FastAvgPeriod != null) h.Add("fastAvgPeriod",FastAvgPeriod);
			if (Index != null) h.Add("index",Index);
			if (Period != null) h.Add("period",Period);
			if (SignalPeriod != null) h.Add("signalPeriod",SignalPeriod);
			if (SlowAvgPeriod != null) h.Add("slowAvgPeriod",SlowAvgPeriod);
			if (VolumeSeriesID != null) h.Add("volumeSeriesID",VolumeSeriesID);
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