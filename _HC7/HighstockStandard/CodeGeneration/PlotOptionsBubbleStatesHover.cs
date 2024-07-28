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
	public partial class PlotOptionsBubbleStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsBubbleStatesHover()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleStatesHoverHalo Halo { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Halo != null) h.Add("halo",Halo.ToHashtable(highstock));
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