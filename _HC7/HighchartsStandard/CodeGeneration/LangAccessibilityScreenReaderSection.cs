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
	public partial class LangAccessibilityScreenReaderSection  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityScreenReaderSection()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string AfterRegionLabel { get; set; }
		 

		/// <summary>
		/// Language options for annotation descriptions.
		/// </summary>
		public List<Annotations> Annotations { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BeforeRegionLabel { get; set; }
		 

		/// <summary>
		/// Label for the end of the chart. Announced by screen readers.
		/// </summary>
		public string EndOfChartMarker { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (AfterRegionLabel != null) h.Add("afterRegionLabel",AfterRegionLabel);
			if (Annotations != null) h.Add("annotations", HashifyList(highcharts,Annotations));
			if (BeforeRegionLabel != null) h.Add("beforeRegionLabel",BeforeRegionLabel);
			if (EndOfChartMarker != null) h.Add("endOfChartMarker",EndOfChartMarker);
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