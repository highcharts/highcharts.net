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
	public partial class PlotOptionsVbpParams  : BaseObject
	{
		public PlotOptionsVbpParams()
		{
			Ranges = Ranges_DefaultValue = null;
			VolumeSeriesID = VolumeSeriesID_DefaultValue = "'volume'";
			
		}	
		

		/// <summary>
		/// <p>The number of price zones.</p>
		/// </summary>
		public double? Ranges { get; set; }
		private double? Ranges_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The id of volume series which is mandatory.For example using OHLC data, volumeSeriesID=&#39;volume&#39; means the indicator will be calculated using OHLC and volume values.</p>
		/// </summary>
		public string VolumeSeriesID { get; set; }
		private string VolumeSeriesID_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Ranges != Ranges_DefaultValue) h.Add("ranges",Ranges);
			if (VolumeSeriesID != VolumeSeriesID_DefaultValue) h.Add("volumeSeriesID",VolumeSeriesID);
			

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