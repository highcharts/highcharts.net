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
	public partial class PlotOptionsWordcloudRotation  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsWordcloudRotation()
		{
		}	
		

		/// <summary>
		/// The smallest degree of rotation for a word.
		/// </summary>
		public double? From { get; set; }
		 

		/// <summary>
		/// The number of possible orientations for a word, within the rangeof `rotation.from` and `rotation.to`. Must be a number largerthan 0.
		/// </summary>
		public double? Orientations { get; set; }
		 

		/// <summary>
		/// The largest degree of rotation for a word.
		/// </summary>
		public double? To { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (From != null) h.Add("from",From);
			if (Orientations != null) h.Add("orientations",Orientations);
			if (To != null) h.Add("to",To);
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