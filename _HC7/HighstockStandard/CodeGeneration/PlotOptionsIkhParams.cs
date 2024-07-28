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
	public partial class PlotOptionsIkhParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsIkhParams()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Index { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Period { get; set; }
		 

		/// <summary>
		/// The base period for Senkou Span B calculations
		/// </summary>
		public double? PeriodSenkouSpanB { get; set; }
		 

		/// <summary>
		/// The base period for Tenkan calculations.
		/// </summary>
		public double? PeriodTenkan { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Index != null) h.Add("index",Index);
			if (Period != null) h.Add("period",Period);
			if (PeriodSenkouSpanB != null) h.Add("periodSenkouSpanB",PeriodSenkouSpanB);
			if (PeriodTenkan != null) h.Add("periodTenkan",PeriodTenkan);
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