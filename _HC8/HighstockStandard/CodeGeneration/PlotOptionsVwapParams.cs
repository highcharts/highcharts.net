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
	public partial class PlotOptionsVwapParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsVwapParams()
		{
			Index = Index_DefaultValue = "undefined";
			Period = Period_DefaultValue = 30;
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
		public double? Period { get; set; }
		private double? Period_DefaultValue { get; set; }
		 

		/// <summary>
		/// The id of volume series which is mandatory. For example usingOHLC data, volumeSeriesID='volume' means the indicator will becalculated using OHLC and volume values.
		/// </summary>
		public string VolumeSeriesID { get; set; }
		private string VolumeSeriesID_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (VolumeSeriesID != VolumeSeriesID_DefaultValue) h.Add("volumeSeriesID",VolumeSeriesID);
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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