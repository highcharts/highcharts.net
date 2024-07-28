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
	public partial class PlotOptionsSankeyLevelsStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSankeyLevelsStatesHover()
		{
		}	
		

		/// <summary>
		/// Opacity for the links between nodes in the sankey diagram inhover mode.
		/// </summary>
		public double? LinkOpacity { get; set; }
		 

		/// <summary>
		/// Opacity for the nodes in the sankey diagram in hover mode.
		/// </summary>
		public double? Opacity { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (LinkOpacity != null) h.Add("linkOpacity",LinkOpacity);
			if (Opacity != null) h.Add("opacity",Opacity);
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