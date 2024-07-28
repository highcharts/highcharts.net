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
	public partial class NavigationAnnotationsOptionsControlPointOptionsStyle  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationAnnotationsOptionsControlPointOptionsStyle()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Cursor { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Fill { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Stroke { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? StrokeWidth { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Cursor != null) h.Add("cursor",Cursor);
			if (Fill != null) h.Add("fill",Fill);
			if (Stroke != null) h.Add("stroke",Stroke);
			if (StrokeWidth != null) h.Add("strokeWidth",StrokeWidth);
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