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
	public partial class LangAccessibilityLegend  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityLegend()
		{
			LegendItem = LegendItem_DefaultValue = "Show {itemName}";
			LegendLabel = LegendLabel_DefaultValue = "Chart legend: {legendTitle}";
			LegendLabelNoTitle = LegendLabelNoTitle_DefaultValue = "Toggle series visibility, {chartTitle}";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string LegendItem { get; set; }
		private string LegendItem_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LegendLabel { get; set; }
		private string LegendLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LegendLabelNoTitle { get; set; }
		private string LegendLabelNoTitle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (LegendItem != LegendItem_DefaultValue) h.Add("legendItem",LegendItem);
			if (LegendLabel != LegendLabel_DefaultValue) h.Add("legendLabel",LegendLabel);
			if (LegendLabelNoTitle != LegendLabelNoTitle_DefaultValue) h.Add("legendLabelNoTitle",LegendLabelNoTitle);
			

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}