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
	public partial class PlotOptionsPackedbubbleParentNode  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPackedbubbleParentNode()
		{
		}	
		

		/// <summary>
		/// Allow this series' parent nodes to be selectedby clicking on the graph.
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (AllowPointSelect != null) h.Add("allowPointSelect",AllowPointSelect);
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