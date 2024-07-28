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
	public partial class VbpSeriesLastPrice  : BaseObject
	{
		Hashtable h = new Hashtable();

		public VbpSeriesLastPrice()
		{
		}	
		

		/// <summary>
		/// The color of the line of last price.By default, the line has the same color as the series.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// Enable or disable the indicator.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public VbpSeriesLastPriceLabel Label { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Color != null) h.Add("color",Color);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Label != null) h.Add("label",Label.ToHashtable(highstock));
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