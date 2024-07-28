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
	public partial class PlotOptionsTilemapStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTilemapStatesHover()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapStatesHoverHalo Halo { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Halo != null) h.Add("halo",Halo.ToHashtable(highcharts));
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