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
	public partial class OrganizationSeriesNodesDataLabelsLinkTextPathAttributes  : BaseObject
	{
		Hashtable h = new Hashtable();

		public OrganizationSeriesNodesDataLabelsLinkTextPathAttributes()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public double? StartOffset { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TextAnchor { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (StartOffset != null) h.Add("startOffset",StartOffset);
			if (TextAnchor != null) h.Add("textAnchor",TextAnchor);
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