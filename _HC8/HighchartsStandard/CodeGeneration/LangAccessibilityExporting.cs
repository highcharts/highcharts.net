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
	public partial class LangAccessibilityExporting  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityExporting()
		{
			ChartMenuLabel = ChartMenuLabel_DefaultValue = "Chart menu";
			ExportRegionLabel = ExportRegionLabel_DefaultValue = "Chart menu";
			MenuButtonLabel = MenuButtonLabel_DefaultValue = "View chart menu";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string ChartMenuLabel { get; set; }
		private string ChartMenuLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ExportRegionLabel { get; set; }
		private string ExportRegionLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MenuButtonLabel { get; set; }
		private string MenuButtonLabel_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (ChartMenuLabel != ChartMenuLabel_DefaultValue) h.Add("chartMenuLabel",ChartMenuLabel);
			if (ExportRegionLabel != ExportRegionLabel_DefaultValue) h.Add("exportRegionLabel",ExportRegionLabel);
			if (MenuButtonLabel != MenuButtonLabel_DefaultValue) h.Add("menuButtonLabel",MenuButtonLabel);
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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