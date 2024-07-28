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
	public partial class PlotOptionsVectorStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsVectorStatesHover()
		{
		}	
		

		/// <summary>
		/// Additonal line width for the vector errors when they arehovered.
		/// </summary>
		public double? LineWidthPlus { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (LineWidthPlus != null) h.Add("lineWidthPlus",LineWidthPlus);
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