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
			Style = Style_DefaultValue = new LabelsStyle();
			Items = Items_DefaultValue = new List<LabelsItems>();
			
		}	
		

		/// <summary>
		/// Shared CSS styles for all labels.
		/// </summary>
		public LabelsStyle Style { get; set; }
		private LabelsStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// A HTML label that can be positioned anywhere in the chart area.
		/// </summary>
		public List<LabelsItems> Items { get; set; }
		private List<LabelsItems> Items_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (Items != Items_DefaultValue) h.Add("items", HashifyList(Items));
			

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