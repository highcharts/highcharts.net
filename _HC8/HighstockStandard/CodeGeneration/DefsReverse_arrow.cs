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
	public partial class DefsReverse_arrow  : BaseObject
	{
		Hashtable h = new Hashtable();

		public DefsReverse_arrow()
		{
			Attributes = Attributes_DefaultValue = null;
			TagName = TagName_DefaultValue = "marker";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public Object Attributes { get; set; }
		private Object Attributes_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TagName { get; set; }
		private string TagName_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Attributes != Attributes_DefaultValue) h.Add("attributes",Attributes);
			if (TagName != TagName_DefaultValue) h.Add("tagName",TagName);
			

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