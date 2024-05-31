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
	public partial class AnnotationsLabelsAccessibility  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsLabelsAccessibility()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Description of an annotation label for screen readers and other assistivetechnology.
		/// </summary>
		public string Description { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Description != null) h.Add("description",Description);
			if (CustomFields.Count > 0)
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