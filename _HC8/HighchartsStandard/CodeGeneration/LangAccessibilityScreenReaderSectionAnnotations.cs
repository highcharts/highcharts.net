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
			DescriptionMultiplePoints = DescriptionMultiplePoints_DefaultValue = "{annotationText}. Related to {annotationPoint}{ Also related to, #each(additionalAnnotationPoints)}";
			DescriptionNoPoints = DescriptionNoPoints_DefaultValue = "{annotationText}";
			DescriptionSinglePoint = DescriptionSinglePoint_DefaultValue = "{annotationText}. Related to {annotationPoint}";
			Heading = Heading_DefaultValue = "Chart annotations summary";
			
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

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (DescriptionMultiplePoints != DescriptionMultiplePoints_DefaultValue) h.Add("descriptionMultiplePoints",DescriptionMultiplePoints);
			if (DescriptionNoPoints != DescriptionNoPoints_DefaultValue) h.Add("descriptionNoPoints",DescriptionNoPoints);
			if (DescriptionSinglePoint != DescriptionSinglePoint_DefaultValue) h.Add("descriptionSinglePoint",DescriptionSinglePoint);
			if (Heading != Heading_DefaultValue) h.Add("heading",Heading);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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