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
	public partial class LangExportData  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangExportData()
		{
		}	
		

		/// <summary>
		/// The annotation column title.
		/// </summary>
		public string AnnotationHeader { get; set; }
		 

		/// <summary>
		/// The category column title when axis type set to "datetime".
		/// </summary>
		public string CategoryDatetimeHeader { get; set; }
		 

		/// <summary>
		/// The category column title.
		/// </summary>
		public string CategoryHeader { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (AnnotationHeader != null) h.Add("annotationHeader",AnnotationHeader);
			if (CategoryDatetimeHeader != null) h.Add("categoryDatetimeHeader",CategoryDatetimeHeader);
			if (CategoryHeader != null) h.Add("categoryHeader",CategoryHeader);
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