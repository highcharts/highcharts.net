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
	public partial class PlotOptionsStochasticParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsStochasticParams()
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
		/// Periods for Stochastic oscillator: [%K, %D].
		/// </summary>
		public List<int> Periods { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Index != null) h.Add("index",Index);
			if (Period != null) h.Add("period",Period);
			if (Periods != null) h.Add("periods",Periods);
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