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
		public LangAccessibilitySeries()
		{
			Description = Description_DefaultValue = "{description}";
			Summary = Summary_DefaultValue = new LangAccessibilitySeriesSummary();
			XAxisDescription = XAxisDescription_DefaultValue = "X axis, {name}";
			YAxisDescription = YAxisDescription_DefaultValue = "Y axis, {name}";
			
		}	
		

		/// <summary>
		/// User supplied description text. This is added after the mainsummary if present.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Lang configuration for the series main summary. Each seriestype has two modes:    1. This series type is the only series type used in the       chart   2. This is a combination chart with multiple series typesIf a definition does not exist for the specific series typeand mode, the 'default' lang definitions are used.
		/// </summary>
		public LangAccessibilitySeriesSummary Summary { get; set; }
		private LangAccessibilitySeriesSummary Summary_DefaultValue { get; set; }
		 

		/// <summary>
		/// xAxis description for series if there are multiple xAxes inthe chart.
		/// </summary>
		public string XAxisDescription { get; set; }
		private string XAxisDescription_DefaultValue { get; set; }
		 

		/// <summary>
		/// yAxis description for series if there are multiple yAxes inthe chart.
		/// </summary>
		public string YAxisDescription { get; set; }
		private string YAxisDescription_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Summary.IsDirty()) h.Add("summary",Summary.ToHashtable());
			if (XAxisDescription != XAxisDescription_DefaultValue) h.Add("xAxisDescription",XAxisDescription);
			if (YAxisDescription != YAxisDescription_DefaultValue) h.Add("yAxisDescription",YAxisDescription);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}