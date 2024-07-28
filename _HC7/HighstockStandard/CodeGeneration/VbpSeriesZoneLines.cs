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
	public partial class VbpSeriesZoneLines  : BaseObject
	{
		Hashtable h = new Hashtable();

		public VbpSeriesZoneLines()
		{
		}	
		

		/// <summary>
		/// Enable/disable zone lines.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Specify the style of zone lines.
		/// </summary>
		public Hashtable Styles { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Styles != null) h.Add("styles",Styles);
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