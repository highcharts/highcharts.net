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
	public partial class NavigationBindingsEllipseAnnotation  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationBindingsEllipseAnnotation()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string ClassName { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (ClassName != null) h.Add("className",ClassName);
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