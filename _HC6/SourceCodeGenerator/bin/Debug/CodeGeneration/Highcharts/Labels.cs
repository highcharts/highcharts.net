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
			Style = Style_DefaultValue = new Hashtable{{ "color", "#333333" }};
			Items = Items_DefaultValue = new LabelsItems();
			
		}	
		

		/// <summary>
		/// Shared CSS styles for all labels.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// A HTML label that can be positioned anywhere in the chart area.
		/// </summary>
		public List<object> Items { get; set; }
		private List<object> Items_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Items.IsDirty()) h.Add("items",Items.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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