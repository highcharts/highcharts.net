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
	public partial class LineSeriesDataAccessibility  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LineSeriesDataAccessibility()
		{
			Description = Description_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Provide a description of the data point, announced to screen readers.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Description != Description_DefaultValue) h.Add("description",Description);
			

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