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
	public partial class ChartOptions3dFrameSide  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartOptions3dFrameSide()
		{
		}	
		

		/// <summary>
		/// The color of the panel.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// The thickness of the panel.
		/// </summary>
		public double? Size { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Color != null) h.Add("color",Color);
			if (Size != null) h.Add("size",Size);
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