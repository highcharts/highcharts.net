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
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string DescriptionMultiplePoints { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DescriptionNoPoints { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DescriptionSinglePoint { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Heading { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (DescriptionMultiplePoints != null) h.Add("descriptionMultiplePoints",DescriptionMultiplePoints);
			if (DescriptionNoPoints != null) h.Add("descriptionNoPoints",DescriptionNoPoints);
			if (DescriptionSinglePoint != null) h.Add("descriptionSinglePoint",DescriptionSinglePoint);
			if (Heading != null) h.Add("heading",Heading);
			if (CustomFields != null && CustomFields.Count > 0)
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