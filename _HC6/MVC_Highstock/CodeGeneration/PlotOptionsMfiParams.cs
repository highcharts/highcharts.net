using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PlotOptionsMfiParams  : BaseObject
	{
		public PlotOptionsMfiParams()
		{
			Period = Period_DefaultValue = null;
			VolumeSeriesID = VolumeSeriesID_DefaultValue = "volume";
			Decimals = Decimals_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The base period for indicator calculations.</p>
		/// </summary>
		public double? Period { get; set; }
		private double? Period_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The id of volume series which is mandatory.For example using OHLC data, volumeSeriesID=&#39;volume&#39; means the indicator will be calculated using OHLC and volume values.</p>
		/// </summary>
		public string VolumeSeriesID { get; set; }
		private string VolumeSeriesID_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Number of maximum decimals that are used in MFI calculations.</p>
		/// </summary>
		public double? Decimals { get; set; }
		private double? Decimals_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (VolumeSeriesID != VolumeSeriesID_DefaultValue) h.Add("volumeSeriesID",VolumeSeriesID);
			if (Decimals != Decimals_DefaultValue) h.Add("decimals",Decimals);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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