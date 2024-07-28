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
	public partial class PlotOptionsMfiParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsMfiParams()
		{
		}	
		

		/// <summary>
		/// Number of maximum decimals that are used in MFI calculations.
		/// </summary>
		public double? Decimals { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Index { get; set; }
		 

		/// <summary>
		/// The base period for indicator calculations. This is the number ofdata points which are taken into account for the indicatorcalculations.
		/// </summary>
		public double? Period { get; set; }
		 

		/// <summary>
		/// The id of volume series which is mandatory.For example using OHLC data, volumeSeriesID='volume' meansthe indicator will be calculated using OHLC and volume values.
		/// </summary>
		public string VolumeSeriesID { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Decimals != null) h.Add("decimals",Decimals);
			if (Index != null) h.Add("index",Index);
			if (Period != null) h.Add("period",Period);
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