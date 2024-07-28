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
	public partial class PlotOptionsLinearregressionangleTooltip  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsLinearregressionangleTooltip()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string PointFormat { get; set; }
		 

		/// <summary>
		/// Number of decimals in indicator series.
		/// </summary>
		public double? ValueDecimals { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (PointFormat != null) h.Add("pointFormat",PointFormat);
			if (ValueDecimals != null) h.Add("valueDecimals",ValueDecimals);
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