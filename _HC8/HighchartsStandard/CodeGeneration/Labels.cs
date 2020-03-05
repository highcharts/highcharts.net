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
	public partial class Labels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Labels()
		{
			Items = Items_DefaultValue = new List<LabelsItems>();
			Style = Style_DefaultValue = new LabelsStyle();
			
		}	
		

		/// <summary>
		/// An HTML label that can be positioned anywhere in the chart area.
		/// </summary>
		public List<LabelsItems> Items { get; set; }
		private List<LabelsItems> Items_DefaultValue { get; set; }
		 

		/// <summary>
		/// Shared CSS styles for all labels.
		/// </summary>
		public LabelsStyle Style { get; set; }
		private LabelsStyle Style_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Items != Items_DefaultValue) h.Add("items", HashifyList(Items));
			if (Style != Style_DefaultValue) h.Add("style",Style);
			

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