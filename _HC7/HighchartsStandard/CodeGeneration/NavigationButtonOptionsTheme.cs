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
	public partial class NavigationButtonOptionsTheme  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationButtonOptionsTheme()
		{
		}	
		

		/// <summary>
		/// The default fill exists only to capture hover events.
		/// </summary>
		public string Fill { get; set; }
		 

		/// <summary>
		/// Padding for the button.
		/// </summary>
		public double? Padding { get; set; }
		 

		/// <summary>
		/// Default stroke for the buttons.
		/// </summary>
		public string Stroke { get; set; }
		 

		/// <summary>
		/// Default stroke linecap for the buttons.
		/// </summary>
		public string StrokeLinecap { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Fill != null) h.Add("fill",Fill);
			if (Padding != null) h.Add("padding",Padding);
			if (Stroke != null) h.Add("stroke",Stroke);
			if (StrokeLinecap != null) h.Add("strokeLinecap",StrokeLinecap);
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