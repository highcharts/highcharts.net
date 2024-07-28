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
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Index { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Period { get; set; }
		 

		/// <summary>
		/// The id of another series to use its data as volume data for theindicator calculation.
		/// </summary>
		public string VolumeSeriesID { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
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