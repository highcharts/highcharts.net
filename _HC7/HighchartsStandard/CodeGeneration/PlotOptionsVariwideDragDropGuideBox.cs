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
	public partial class PlotOptionsVariwideDragDropGuideBox  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsVariwideDragDropGuideBox()
		{
		}	
		

		/// <summary>
		/// Style options for the guide box default state.
		/// </summary>
		public PlotOptionsVariwideDragDropGuideBoxDefault Default { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Default != null) h.Add("default",Default.ToHashtable(highcharts));
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