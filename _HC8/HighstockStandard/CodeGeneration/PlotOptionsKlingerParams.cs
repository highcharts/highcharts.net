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
			FastAvgPeriod = FastAvgPeriod_DefaultValue = 34;
			Index = Index_DefaultValue = 3;
			Period = Period_DefaultValue = 14;
			SignalPeriod = SignalPeriod_DefaultValue = 13;
			SlowAvgPeriod = SlowAvgPeriod_DefaultValue = 55;
			VolumeSeriesID = VolumeSeriesID_DefaultValue = "volume";
			
		}	
		

		/// <summary>
		/// The fast period for indicator calculations.
		/// </summary>
		public double? FastAvgPeriod { get; set; }
		private double? FastAvgPeriod_DefaultValue { get; set; }
		 

		/// <summary>
		/// The point index which indicator calculations will base. Forexample using OHLC data, index=2 means the indicator will becalculated using Low values.
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// The base period for indicator calculations. This is the number ofdata points which are taken into account for the indicatorcalculations.
		/// </summary>
		public double? Period { get; set; }
		private double? Period_DefaultValue { get; set; }
		 

		/// <summary>
		/// The base period for signal calculations.
		/// </summary>
		public double? SignalPeriod { get; set; }
		private double? SignalPeriod_DefaultValue { get; set; }
		 

		/// <summary>
		/// The slow period for indicator calculations.
		/// </summary>
		public double? SlowAvgPeriod { get; set; }
		private double? SlowAvgPeriod_DefaultValue { get; set; }
		 

		/// <summary>
		/// The id of another series to use its data as volume data for theindiator calculation.
		/// </summary>
		public string VolumeSeriesID { get; set; }
		private string VolumeSeriesID_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (FastAvgPeriod != FastAvgPeriod_DefaultValue) h.Add("fastAvgPeriod",FastAvgPeriod);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (SignalPeriod != SignalPeriod_DefaultValue) h.Add("signalPeriod",SignalPeriod);
			if (SlowAvgPeriod != SlowAvgPeriod_DefaultValue) h.Add("slowAvgPeriod",SlowAvgPeriod);
			if (VolumeSeriesID != VolumeSeriesID_DefaultValue) h.Add("volumeSeriesID",VolumeSeriesID);
			

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