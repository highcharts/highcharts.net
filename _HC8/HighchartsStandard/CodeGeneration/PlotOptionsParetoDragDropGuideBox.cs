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
	public partial class PlotOptionsParetoDragDropGuideBox  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsParetoDragDropGuideBox()
		{
			Default = Default_DefaultValue = new PlotOptionsParetoDragDropGuideBoxDefault();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Style options for the guide box default state.
		/// </summary>
		public PlotOptionsParetoDragDropGuideBoxDefault Default { get; set; }
		private PlotOptionsParetoDragDropGuideBoxDefault Default_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Default.IsDirty()) h.Add("default",Default.ToHashtable());
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