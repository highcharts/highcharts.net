using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class Labels  : BaseObject
	{
		public Labels()
		{
			Style = Style_DefaultValue = new LabelsStyle();
			Items = Items_DefaultValue = new LabelsItems();
			
		}	
		

		/// <summary>
		/// <p>Shared CSS styles for all labels.</p>
		/// </summary>
		public LabelsStyle Style { get; set; }
		private LabelsStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A HTML label that can be positioned anywhere in the chart area.</p>
		/// </summary>
		public LabelsItems Items { get; set; }
		private LabelsItems Items_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
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