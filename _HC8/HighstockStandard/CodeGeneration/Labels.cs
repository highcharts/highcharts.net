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
	public partial class Labels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Labels()
		{
			Items = Items_DefaultValue = new List<LabelsItems>();
			Style = Style_DefaultValue = new Hashtable();
			
		}	
		

		/// <summary>
		/// An HTML label that can be positioned anywhere in the chart area.
		/// </summary>
		public List<LabelsItems> Items { get; set; }
		private List<LabelsItems> Items_DefaultValue { get; set; }
		 

		/// <summary>
		/// Shared CSS styles for all labels.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Items != Items_DefaultValue) h.Add("items", HashifyList(highstock,Items));
			if (Style != Style_DefaultValue) h.Add("style",Style);
			

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}