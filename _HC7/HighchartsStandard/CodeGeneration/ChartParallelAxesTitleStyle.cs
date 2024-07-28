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
	public partial class ChartParallelAxesTitleStyle  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartParallelAxesTitleStyle()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FontSize { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Color != null) h.Add("color",Color);
			if (FontSize != null) h.Add("fontSize",FontSize);
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