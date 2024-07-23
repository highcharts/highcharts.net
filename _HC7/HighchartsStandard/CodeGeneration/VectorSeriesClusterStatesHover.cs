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
	public partial class VectorSeriesClusterStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public VectorSeriesClusterStatesHover()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The fill color of the cluster marker in hover state. When`undefined`, the series' or point's fillColor for normalstate is used.
		/// </summary>
		public Object FillColor { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (FillColor != null) h.Add("fillColor",FillColor);
			if (CustomFields.Count > 0)
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