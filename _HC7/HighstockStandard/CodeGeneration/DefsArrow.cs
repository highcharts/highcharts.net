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
	public partial class DefsArrow  : BaseObject
	{
		Hashtable h = new Hashtable();

		public DefsArrow()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public Object Attributes { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<object> Children { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TagName { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Attributes != null) h.Add("attributes",Attributes);
			if (Children != null) h.Add("children",Children);
			if (TagName != null) h.Add("tagName",TagName);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}