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
	public partial class PlotOptionsVennStatesSelect  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsVennStatesSelect()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Color { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Animation != null) h.Add("animation",Animation.ToHashtable(highcharts));
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (Color != null) h.Add("color",Color);
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