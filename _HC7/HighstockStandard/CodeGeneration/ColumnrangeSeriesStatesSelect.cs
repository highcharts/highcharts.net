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
	public partial class ColumnrangeSeriesStatesSelect  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColumnrangeSeriesStatesSelect()
		{
		}	
		

		/// <summary>
		/// Animation setting for hovering the graph in line-type series.
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// Animation setting for hovering the graph in line-type series.
		/// </summary>
		public bool? AnimationBool { get; set; }
		 

		/// <summary>
		/// Enable separate styles for the hovered series to visualizethat the user hovers either the series itself or the legend.
		/// </summary>
		public bool? Enabled { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Animation != null) h.Add("animation",Animation);
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (Enabled != null) h.Add("enabled",Enabled);
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