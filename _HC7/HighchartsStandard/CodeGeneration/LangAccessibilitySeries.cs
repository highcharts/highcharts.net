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
	public partial class LangAccessibilitySeries  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilitySeries()
		{
			Description = Description_DefaultValue = "{description}";
			NullPointValue = NullPointValue_DefaultValue = "No value";
			PointAnnotationsDescription = PointAnnotationsDescription_DefaultValue = "{#each annotations}Annotation: {this}{/each}";
			Summary = Summary_DefaultValue = new LangAccessibilitySeriesSummary();
			XAxisDescription = XAxisDescription_DefaultValue = "X axis, {name}";
			YAxisDescription = YAxisDescription_DefaultValue = "Y axis, {name}";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// User supplied description text. This is added in the pointcomment description by default if present.`{description}` refers to the value given in[point.accessibility.description](#series.line.data.accessibility.description).
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Description for the value of null points.
		/// </summary>
		public string NullPointValue { get; set; }
		private string NullPointValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// Description for annotations on a point, as it is made availableto assistive technology.
		/// </summary>
		public string PointAnnotationsDescription { get; set; }
		private string PointAnnotationsDescription_DefaultValue { get; set; }
		 

		/// <summary>
		/// Lang configuration for the series main summary. Each seriestype has two modes:1. This series type is the only series type used in the   chart2. This is a combination chart with multiple series typesIf a definition does not exist for the specific series typeand mode, the 'default' lang definitions are used.Chart and its subproperties can be accessed with the `{chart}` variable.The series and its subproperties can be accessed with the `{series}` variable.The series index (starting from 1) can be accessed with the `{seriesNumber}` variable.
		/// </summary>
		public LangAccessibilitySeriesSummary Summary { get; set; }
		private LangAccessibilitySeriesSummary Summary_DefaultValue { get; set; }
		 

		/// <summary>
		/// X-axis description for series if there are multiple xAxes inthe chart.
		/// </summary>
		public string XAxisDescription { get; set; }
		private string XAxisDescription_DefaultValue { get; set; }
		 

		/// <summary>
		/// Y-axis description for series if there are multiple yAxes inthe chart.
		/// </summary>
		public string YAxisDescription { get; set; }
		private string YAxisDescription_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (NullPointValue != NullPointValue_DefaultValue) h.Add("nullPointValue",NullPointValue);
			if (PointAnnotationsDescription != PointAnnotationsDescription_DefaultValue) h.Add("pointAnnotationsDescription",PointAnnotationsDescription);
			if (Summary.IsDirty(highcharts)) h.Add("summary",Summary.ToHashtable(highcharts));
			if (XAxisDescription != XAxisDescription_DefaultValue) h.Add("xAxisDescription",XAxisDescription);
			if (YAxisDescription != YAxisDescription_DefaultValue) h.Add("yAxisDescription",YAxisDescription);
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