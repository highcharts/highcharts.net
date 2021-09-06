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
	public partial class PlotOptionsVbpParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsVbpParams()
		{
			Index = Index_DefaultValue = "undefined";
			Period = Period_DefaultValue = "undefined";
			Ranges = Ranges_DefaultValue = 12;
			VolumeSeriesID = VolumeSeriesID_DefaultValue = "volume";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Index { get; set; }
		private string Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Period { get; set; }
		private string Period_DefaultValue { get; set; }
		 

		/// <summary>
		/// The number of price zones.
		/// </summary>
		public double? Ranges { get; set; }
		private double? Ranges_DefaultValue { get; set; }
		 

		/// <summary>
		/// The id of volume series which is mandatory. For example usingOHLC data, volumeSeriesID='volume' means the indicator will becalculated using OHLC and volume values.
		/// </summary>
		public string VolumeSeriesID { get; set; }
		private string VolumeSeriesID_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (Ranges != Ranges_DefaultValue) h.Add("ranges",Ranges);
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