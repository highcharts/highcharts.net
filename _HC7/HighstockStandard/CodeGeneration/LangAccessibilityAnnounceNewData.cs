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
	public partial class LangAccessibilityAnnounceNewData  : BaseObject
	{
		public LangAccessibilityAnnounceNewData()
		{
			NewDataAnnounce = NewDataAnnounce_DefaultValue = "Updated data for chart {chartTitle}";
			NewPointAnnounceMultiple = NewPointAnnounceMultiple_DefaultValue = "New data point in chart {chartTitle}: {pointDesc}";
			NewPointAnnounceSingle = NewPointAnnounceSingle_DefaultValue = "New data point: {pointDesc}";
			NewSeriesAnnounceMultiple = NewSeriesAnnounceMultiple_DefaultValue = "New data series in chart {chartTitle}: {seriesDesc}";
			NewSeriesAnnounceSingle = NewSeriesAnnounceSingle_DefaultValue = "New data series: {seriesDesc}";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string NewDataAnnounce { get; set; }
		private string NewDataAnnounce_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string NewPointAnnounceMultiple { get; set; }
		private string NewPointAnnounceMultiple_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string NewPointAnnounceSingle { get; set; }
		private string NewPointAnnounceSingle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string NewSeriesAnnounceMultiple { get; set; }
		private string NewSeriesAnnounceMultiple_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string NewSeriesAnnounceSingle { get; set; }
		private string NewSeriesAnnounceSingle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (NewDataAnnounce != NewDataAnnounce_DefaultValue) h.Add("newDataAnnounce",NewDataAnnounce);
			if (NewPointAnnounceMultiple != NewPointAnnounceMultiple_DefaultValue) h.Add("newPointAnnounceMultiple",NewPointAnnounceMultiple);
			if (NewPointAnnounceSingle != NewPointAnnounceSingle_DefaultValue) h.Add("newPointAnnounceSingle",NewPointAnnounceSingle);
			if (NewSeriesAnnounceMultiple != NewSeriesAnnounceMultiple_DefaultValue) h.Add("newSeriesAnnounceMultiple",NewSeriesAnnounceMultiple);
			if (NewSeriesAnnounceSingle != NewSeriesAnnounceSingle_DefaultValue) h.Add("newSeriesAnnounceSingle",NewSeriesAnnounceSingle);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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