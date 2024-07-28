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
	public partial class ScatterSeriesJitter  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ScatterSeriesJitter()
		{
		}	
		

		/// <summary>
		/// The maximal X offset for the random jitter effect.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// The maximal Y offset for the random jitter effect.
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (X != null) h.Add("x",X);
			if (Y != null) h.Add("y",Y);
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