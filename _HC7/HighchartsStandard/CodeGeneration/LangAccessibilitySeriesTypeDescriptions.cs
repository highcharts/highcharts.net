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
		 

		/// <summary>
		/// 
		/// </summary>
		public string Areasplinerange { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Boxplot { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Bubble { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Columnrange { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Errorbar { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Funnel { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Pyramid { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Waterfall { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
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
	}
}