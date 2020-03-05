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
	public partial class StreamgraphSeriesDataSorting  : BaseObject
	{
		Hashtable h = new Hashtable();

		public StreamgraphSeriesDataSorting()
		{
			Enabled = Enabled_DefaultValue = null;
			MatchByName = MatchByName_DefaultValue = null;
			SortKey = SortKey_DefaultValue = "y";
			
		}	
		

		/// <summary>
		/// Enable or disable data sorting for the series. Use [xAxis.reversed](#xAxis.reversed) to change the sorting order.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to allow matching points by name in an update. If this optionis disabled, points will be matched by order.
		/// </summary>
		public bool? MatchByName { get; set; }
		private bool? MatchByName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Determines what data value should be used to sort by.
		/// </summary>
		public string SortKey { get; set; }
		private string SortKey_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (MatchByName != MatchByName_DefaultValue) h.Add("matchByName",MatchByName);
			if (SortKey != SortKey_DefaultValue) h.Add("sortKey",SortKey);
			

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