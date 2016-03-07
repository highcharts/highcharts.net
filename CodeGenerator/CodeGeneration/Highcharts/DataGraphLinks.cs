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
	public partial class DataGraphLinks  : BaseObject
	{
		public DataGraphLinks()
		{
			Source = Source_DefaultValue = "";
			Target = Target_DefaultValue = "";
			Weight = Weight_DefaultValue = null;
			ItemStyle = ItemStyle_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Index or name of source node
		/// </summary>
		public string Source { get; set; }
		private string Source_DefaultValue { get; set; }
		 

		/// <summary>
		/// Index or name of target node
		/// </summary>
		public string Target { get; set; }
		private string Target_DefaultValue { get; set; }
		 

		/// <summary>
		/// Weight of link
		/// </summary>
		public number Weight { get; set; }
		private number Weight_DefaultValue { get; set; }
		 

		/// <summary>
		/// see linkStyle
		/// </summary>
		public Object ItemStyle { get; set; }
		private Object ItemStyle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Source != Source_DefaultValue) h.Add("source",Source);
			if (Target != Target_DefaultValue) h.Add("target",Target);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			if (ItemStyle != ItemStyle_DefaultValue) h.Add("itemStyle",ItemStyle);
			

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