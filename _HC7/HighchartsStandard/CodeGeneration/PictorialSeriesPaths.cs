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
	public partial class PictorialSeriesPaths  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PictorialSeriesPaths()
		{
		}	
		

		/// <summary>
		/// The definition defines a path to be drawn. It corresponds `d` SVG attribute.
		/// </summary>
		public string Definition { get; set; }
		 

		/// <summary>
		/// The max option determines height of the image. It is the ratio of`yAxis.max` to the `paths.max`.
		/// </summary>
		public double? Max { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Definition != null) h.Add("definition",Definition);
			if (Max != null) h.Add("max",Max);
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