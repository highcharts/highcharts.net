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
			AfterRegionLabel = AfterRegionLabel_DefaultValue = "";
			Annotations = Annotations_DefaultValue = new List<Annotations>();
			BeforeRegionLabel = BeforeRegionLabel_DefaultValue = "";
			EndOfChartMarker = EndOfChartMarker_DefaultValue = "End of interactive chart.";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string AfterRegionLabel { get; set; }
		private string AfterRegionLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// Language options for annotation descriptions.
		/// </summary>
		public List<Annotations> Annotations { get; set; }
		private List<Annotations> Annotations_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BeforeRegionLabel { get; set; }
		private string BeforeRegionLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// Label for the end of the chart. Announced by screen readers.
		/// </summary>
		public string EndOfChartMarker { get; set; }
		private string EndOfChartMarker_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (AfterRegionLabel != AfterRegionLabel_DefaultValue) h.Add("afterRegionLabel",AfterRegionLabel);
			if (Annotations != Annotations_DefaultValue) h.Add("annotations", HashifyList(ref highcharts,Annotations));
			if (BeforeRegionLabel != BeforeRegionLabel_DefaultValue) h.Add("beforeRegionLabel",BeforeRegionLabel);
			if (EndOfChartMarker != EndOfChartMarker_DefaultValue) h.Add("endOfChartMarker",EndOfChartMarker);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}