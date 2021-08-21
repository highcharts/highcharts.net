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
	public partial class LangExportData  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangExportData()
		{
			AnnotationHeader = AnnotationHeader_DefaultValue = "Annotations";
			CategoryDatetimeHeader = CategoryDatetimeHeader_DefaultValue = "DateTime";
			CategoryHeader = CategoryHeader_DefaultValue = "Category";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The annotation column title.
		/// </summary>
		public string AnnotationHeader { get; set; }
		private string AnnotationHeader_DefaultValue { get; set; }
		 

		/// <summary>
		/// The category column title when axis type set to "datetime".
		/// </summary>
		public string CategoryDatetimeHeader { get; set; }
		private string CategoryDatetimeHeader_DefaultValue { get; set; }
		 

		/// <summary>
		/// The category column title.
		/// </summary>
		public string CategoryHeader { get; set; }
		private string CategoryHeader_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (AnnotationHeader != AnnotationHeader_DefaultValue) h.Add("annotationHeader",AnnotationHeader);
			if (CategoryDatetimeHeader != CategoryDatetimeHeader_DefaultValue) h.Add("categoryDatetimeHeader",CategoryDatetimeHeader);
			if (CategoryHeader != CategoryHeader_DefaultValue) h.Add("categoryHeader",CategoryHeader);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}