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
	public partial class ExportingMenuItemDefinitions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ExportingMenuItemDefinitions()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string OnClick { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Separator { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Text { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TextKey { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (OnClick != null) { h.Add("onClick",OnClick); highcharts.AddFunction("onClick", OnClick); }  
			if (Separator != null) h.Add("separator",Separator);
			if (Text != null) h.Add("text",Text);
			if (TextKey != null) h.Add("textKey",TextKey);
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