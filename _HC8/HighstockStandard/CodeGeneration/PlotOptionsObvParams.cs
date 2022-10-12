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
	public partial class PlotOptionsObvParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsObvParams()
		{
			Index = Index_DefaultValue = "undefined";
			Period = Period_DefaultValue = "undefined";
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
		/// The id of another series to use its data as volume data for theindiator calculation.
		/// </summary>
		public string VolumeSeriesID { get; set; }
		private string VolumeSeriesID_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (VolumeSeriesID != VolumeSeriesID_DefaultValue) h.Add("volumeSeriesID",VolumeSeriesID);
			

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