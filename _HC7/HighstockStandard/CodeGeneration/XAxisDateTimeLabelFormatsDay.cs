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
	public partial class XAxisDateTimeLabelFormatsDay  : BaseObject
	{
		Hashtable h = new Hashtable();

		public XAxisDateTimeLabelFormatsDay()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public List<string> List { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Main { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (List != null) h.Add("list",List);
			if (Main != null) h.Add("main",Main);
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