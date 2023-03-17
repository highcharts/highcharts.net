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
	public partial class PlotOptionsChaikinParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsChaikinParams()
		{
			Index = Index_DefaultValue = "undefined";
			Period = Period_DefaultValue = 9;
			Periods = Periods_DefaultValue = new List<double>();
			VolumeSeriesID = VolumeSeriesID_DefaultValue = "volume";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Index { get; set; }
		private string Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// Parameter used indirectly for calculating the `AD` indicator.Decides about the number of data points that are takeninto account for the indicator calculations.
		/// </summary>
		public double? Period { get; set; }
		private double? Period_DefaultValue { get; set; }
		 

		/// <summary>
		/// Periods for Chaikin Oscillator calculations.
		/// </summary>
		public List<double> Periods { get; set; }
		private List<double> Periods_DefaultValue { get; set; }
		 

		/// <summary>
		/// The id of volume series which is mandatory.For example using OHLC data, volumeSeriesID='volume' meansthe indicator will be calculated using OHLC and volume values.
		/// </summary>
		public string VolumeSeriesID { get; set; }
		private string VolumeSeriesID_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (Periods != Periods_DefaultValue) h.Add("periods",Periods);
			if (VolumeSeriesID != VolumeSeriesID_DefaultValue) h.Add("volumeSeriesID",VolumeSeriesID);
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