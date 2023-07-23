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
	public partial class AreasplinerangeSeriesDataDragDropGuideBox  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AreasplinerangeSeriesDataDragDropGuideBox()
		{
			Default = Default_DefaultValue = new AreasplinerangeSeriesDataDragDropGuideBoxDefault();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Style options for the guide box default state.
		/// </summary>
		public AreasplinerangeSeriesDataDragDropGuideBoxDefault Default { get; set; }
		private AreasplinerangeSeriesDataDragDropGuideBoxDefault Default_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Default.IsDirty(highcharts)) h.Add("default",Default.ToHashtable(highcharts));
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