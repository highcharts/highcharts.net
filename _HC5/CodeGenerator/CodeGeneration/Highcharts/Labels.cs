using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class Labels  : BaseObject
	{
		public Labels()
		{
			Items = Items_DefaultValue = new LabelsItems();
			Style = Style_DefaultValue = new Hashtable{{ "color", "#333333" }};
			
		}	
		

		/// <summary>
		/// A HTML label that can be positioned anywhere in the chart area.
		/// </summary>
		public LabelsItems Items { get; set; }
		private LabelsItems Items_DefaultValue { get; set; }
		 

		/// <summary>
		/// Shared CSS styles for all labels.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Items.IsDirty()) h.Add("items",Items.ToHashtable());
			if (Style != Style_DefaultValue) h.Add("style",Style);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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