using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class FunnelSeriesTooltipDateTimeLabelFormats  : BaseObject
	{
		Hashtable h = new Hashtable();

		public FunnelSeriesTooltipDateTimeLabelFormats()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Day { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Hour { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Millisecond { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Minute { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Month { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Second { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Week { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Year { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Day != null) h.Add("day",Day);
			if (Hour != null) h.Add("hour",Hour);
			if (Millisecond != null) h.Add("millisecond",Millisecond);
			if (Minute != null) h.Add("minute",Minute);
			if (Month != null) h.Add("month",Month);
			if (Second != null) h.Add("second",Second);
			if (Week != null) h.Add("week",Week);
			if (Year != null) h.Add("year",Year);
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