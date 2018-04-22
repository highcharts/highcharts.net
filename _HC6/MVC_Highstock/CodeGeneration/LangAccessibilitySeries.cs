using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class LangAccessibilitySeries  : BaseObject
	{
		public LangAccessibilitySeries()
		{
			Summary = Summary_DefaultValue = new LangAccessibilitySeriesSummary();
			Description = Description_DefaultValue = "{description}";
			XAxisDescription = XAxisDescription_DefaultValue = "X axis, {name}";
			YAxisDescription = YAxisDescription_DefaultValue = "Y axis, {name}";
			
		}	
		

		/// <summary>
		/// Lang configuration for the series main summary. Each seriestype has two modes:    1. This series type is the only series type used in the       chart   2. This is a combination chart with multiple series typesIf a definition does not exist for the specific series typeand mode, the 'default' lang definitions are used.
		/// </summary>
		public LangAccessibilitySeriesSummary Summary { get; set; }
		private LangAccessibilitySeriesSummary Summary_DefaultValue { get; set; }
		 

		/// <summary>
		/// User supplied description text. This is added after the mainsummary if present.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

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

			if (Summary.IsDirty()) h.Add("summary",Summary.ToHashtable());
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (XAxisDescription != XAxisDescription_DefaultValue) h.Add("xAxisDescription",XAxisDescription);
			if (YAxisDescription != YAxisDescription_DefaultValue) h.Add("yAxisDescription",YAxisDescription);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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