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
	public partial class ColumnSeriesDragDropGuideBox  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColumnSeriesDragDropGuideBox()
		{
			Default = Default_DefaultValue = new ColumnSeriesDragDropGuideBoxDefault();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Style options for the guide box default state.
		/// </summary>
		public ColumnSeriesDragDropGuideBoxDefault Default { get; set; }
		private ColumnSeriesDragDropGuideBoxDefault Default_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Default.IsDirty(ref highcharts)) h.Add("default",Default.ToHashtable(ref highcharts));
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