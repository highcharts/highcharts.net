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
	public partial class LangAccessibilitySeriesTypeDescriptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilitySeriesTypeDescriptions()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Arearange { get; set; }
		private string Arearange_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Areasplinerange { get; set; }
		private string Areasplinerange_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Boxplot { get; set; }
		private string Boxplot_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Bubble { get; set; }
		private string Bubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Columnrange { get; set; }
		private string Columnrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Errorbar { get; set; }
		private string Errorbar_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Funnel { get; set; }
		private string Funnel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Pyramid { get; set; }
		private string Pyramid_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Waterfall { get; set; }
		private string Waterfall_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Arearange != null) h.Add("arearange",Arearange);
			if (Areasplinerange != null) h.Add("areasplinerange",Areasplinerange);
			if (Boxplot != null) h.Add("boxplot",Boxplot);
			if (Bubble != null) h.Add("bubble",Bubble);
			if (Columnrange != null) h.Add("columnrange",Columnrange);
			if (Errorbar != null) h.Add("errorbar",Errorbar);
			if (Funnel != null) h.Add("funnel",Funnel);
			if (Pyramid != null) h.Add("pyramid",Pyramid);
			if (Waterfall != null) h.Add("waterfall",Waterfall);
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