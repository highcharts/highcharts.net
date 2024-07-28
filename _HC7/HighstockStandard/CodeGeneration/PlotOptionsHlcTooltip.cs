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
	public partial class PlotOptionsHlcTooltip  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsHlcTooltip()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public double? Distance { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PointFormat { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Distance != null) h.Add("distance",Distance);
			if (PointFormat != null) h.Add("pointFormat",PointFormat);
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