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
	public partial class PlotOptionsVennStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsVennStatesHover()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Opacity { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (BorderColor != null) h.Add("borderColor",BorderColor);
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