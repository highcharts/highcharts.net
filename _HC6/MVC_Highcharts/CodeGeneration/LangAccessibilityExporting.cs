using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class LangAccessibilityExporting  : BaseObject
	{
		public LangAccessibilityExporting()
		{
			ChartMenuLabel = ChartMenuLabel_DefaultValue = "Chart export";
			MenuButtonLabel = MenuButtonLabel_DefaultValue = "View export menu";
			ExportRegionLabel = ExportRegionLabel_DefaultValue = "Chart export menu";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string ChartMenuLabel { get; set; }
		private string ChartMenuLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MenuButtonLabel { get; set; }
		private string MenuButtonLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ExportRegionLabel { get; set; }
		private string ExportRegionLabel_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ChartMenuLabel != ChartMenuLabel_DefaultValue) h.Add("chartMenuLabel",ChartMenuLabel);
			if (MenuButtonLabel != MenuButtonLabel_DefaultValue) h.Add("menuButtonLabel",MenuButtonLabel);
			if (ExportRegionLabel != ExportRegionLabel_DefaultValue) h.Add("exportRegionLabel",ExportRegionLabel);
			

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