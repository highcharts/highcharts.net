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
	public partial class PlotOptionsAreasplineDataLabelsTextPath  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsAreasplineDataLabelsTextPath()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Presentation attributes for the text path.
		/// </summary>
		public Object Attributes { get; set; }
		 

		/// <summary>
		/// Enable or disable `textPath` option for link's or marker's datalabels.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Attributes != null) h.Add("attributes",Attributes);
			if (Enabled != null) h.Add("enabled",Enabled);
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