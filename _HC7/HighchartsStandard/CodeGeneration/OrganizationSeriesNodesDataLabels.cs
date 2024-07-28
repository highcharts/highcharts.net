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
	public partial class OrganizationSeriesNodesDataLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public OrganizationSeriesNodesDataLabels()
		{
		}	
		

		/// <summary>
		/// The format string specifying what to show for *links* in theorganization chart.Best to use with [`linkTextPath`](#series.organization.dataLabels.linkTextPath) enabled.
		/// </summary>
		public string LinkFormat { get; set; }
		 

		/// <summary>
		/// Callback to format data labels for _links_ in theorganization chart. The `linkFormat` option takesprecedence over the `linkFormatter`.
		/// </summary>
		public string LinkFormatter { get; set; }
		 

		/// <summary>
		/// Options for a _link_ label text which should follow linkconnection.
		/// </summary>
		public OrganizationSeriesNodesDataLabelsLinkTextPath LinkTextPath { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (LinkFormat != null) h.Add("linkFormat",LinkFormat);
			if (LinkFormatter != null) { h.Add("linkFormatter",LinkFormatter); highcharts.AddFunction("linkFormatter", LinkFormatter); }  
			if (LinkTextPath != null) h.Add("linkTextPath",LinkTextPath.ToHashtable(highcharts));
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