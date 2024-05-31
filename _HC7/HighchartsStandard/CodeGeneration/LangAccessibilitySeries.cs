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
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// User supplied description text. This is added in the pointcomment description by default if present.`{description}` refers to the value given in[point.accessibility.description](#series.line.data.accessibility.description).
		/// </summary>
		public string Description { get; set; }
		 

		/// <summary>
		/// Description for the value of null points.
		/// </summary>
		public string NullPointValue { get; set; }
		 

		/// <summary>
		/// Description for annotations on a point, as it is made availableto assistive technology.
		/// </summary>
		public string PointAnnotationsDescription { get; set; }
		 

		/// <summary>
		/// Lang configuration for the series main summary. Each seriestype has two modes:1. This series type is the only series type used in the   chart2. This is a combination chart with multiple series typesIf a definition does not exist for the specific series typeand mode, the 'default' lang definitions are used.Chart and its subproperties can be accessed with the `{chart}` variable.The series and its subproperties can be accessed with the `{series}` variable.The series index (starting from 1) can be accessed with the `{seriesNumber}` variable.
		/// </summary>
		public LangAccessibilitySeriesSummary Summary { get; set; }
		 

		/// <summary>
		/// xAxis description for series if there are multiple xAxes inthe chart.
		/// </summary>
		public string XAxisDescription { get; set; }
		 

		/// <summary>
		/// yAxis description for series if there are multiple yAxes inthe chart.
		/// </summary>
		public string YAxisDescription { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Description != null) h.Add("description",Description);
			if (NullPointValue != null) h.Add("nullPointValue",NullPointValue);
			if (PointAnnotationsDescription != null) h.Add("pointAnnotationsDescription",PointAnnotationsDescription);
			if (Summary != null) h.Add("summary",Summary.ToHashtable(highcharts));
			if (XAxisDescription != null) h.Add("xAxisDescription",XAxisDescription);
			if (YAxisDescription != null) h.Add("yAxisDescription",YAxisDescription);
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