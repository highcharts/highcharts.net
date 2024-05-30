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
	public partial class LangAccessibilityScreenReaderSectionAnnotations  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityScreenReaderSectionAnnotations()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string DescriptionMultiplePoints { get; set; }
		private string DescriptionMultiplePoints_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DescriptionNoPoints { get; set; }
		private string DescriptionNoPoints_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DescriptionSinglePoint { get; set; }
		private string DescriptionSinglePoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Heading { get; set; }
		private string Heading_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (DescriptionMultiplePoints != null) h.Add("descriptionMultiplePoints",DescriptionMultiplePoints);
			if (DescriptionNoPoints != null) h.Add("descriptionNoPoints",DescriptionNoPoints);
			if (DescriptionSinglePoint != null) h.Add("descriptionSinglePoint",DescriptionSinglePoint);
			if (Heading != null) h.Add("heading",Heading);
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