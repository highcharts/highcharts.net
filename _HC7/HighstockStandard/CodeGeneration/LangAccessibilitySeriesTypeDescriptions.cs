using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class LangAccessibilitySeriesTypeDescriptions  : BaseObject
	{
		public LangAccessibilitySeriesTypeDescriptions()
		{
			Arearange = Arearange_DefaultValue = "Arearange charts are line charts displaying a range between a lower and higher value for each point.";
			Areasplinerange = Areasplinerange_DefaultValue = "These charts are line charts displaying a range between a lower and higher value for each point.";
			Boxplot = Boxplot_DefaultValue = "Box plot charts are typically used to display groups of statistical data. Each data point in the chart can have up to 5 values: minimum, lower quartile, median, upper quartile, and maximum.";
			Bubble = Bubble_DefaultValue = "Bubble charts are scatter charts where each data point also has a size value.";
			Columnrange = Columnrange_DefaultValue = "Columnrange charts are column charts displaying a range between a lower and higher value for each point.";
			Errorbar = Errorbar_DefaultValue = "Errorbar series are used to display the variability of the data.";
			Funnel = Funnel_DefaultValue = "Funnel charts are used to display reduction of data in stages.";
			Pyramid = Pyramid_DefaultValue = "Pyramid charts consist of a single pyramid with item heights corresponding to each point value.";
			Waterfall = Waterfall_DefaultValue = "A waterfall chart is a column chart where each column contributes towards a total end value.";
			
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
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Arearange != Arearange_DefaultValue) h.Add("arearange",Arearange);
			if (Areasplinerange != Areasplinerange_DefaultValue) h.Add("areasplinerange",Areasplinerange);
			if (Boxplot != Boxplot_DefaultValue) h.Add("boxplot",Boxplot);
			if (Bubble != Bubble_DefaultValue) h.Add("bubble",Bubble);
			if (Columnrange != Columnrange_DefaultValue) h.Add("columnrange",Columnrange);
			if (Errorbar != Errorbar_DefaultValue) h.Add("errorbar",Errorbar);
			if (Funnel != Funnel_DefaultValue) h.Add("funnel",Funnel);
			if (Pyramid != Pyramid_DefaultValue) h.Add("pyramid",Pyramid);
			if (Waterfall != Waterfall_DefaultValue) h.Add("waterfall",Waterfall);
			

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