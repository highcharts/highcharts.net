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
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Index { get; set; }
		 

		/// <summary>
		/// Parameter used indirectly for calculating the `AD` indicator.Decides about the number of data points that are takeninto account for the indicator calculations.
		/// </summary>
		public double? Period { get; set; }
		 

		/// <summary>
		/// Periods for Chaikin Oscillator calculations.
		/// </summary>
		public List<double> Periods { get; set; }
		 

		/// <summary>
		/// The id of volume series which is mandatory.For example using OHLC data, volumeSeriesID='volume' meansthe indicator will be calculated using OHLC and volume values.
		/// </summary>
		public string VolumeSeriesID { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Index != null) h.Add("index",Index);
			if (Period != null) h.Add("period",Period);
			if (Periods != null) h.Add("periods",Periods);
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