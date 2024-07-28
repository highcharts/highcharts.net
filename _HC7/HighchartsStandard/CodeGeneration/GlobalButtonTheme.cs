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
	public partial class GlobalButtonTheme  : BaseObject
	{
		Hashtable h = new Hashtable();

		public GlobalButtonTheme()
		{
		}	
		

		/// <summary>
		/// The fill color for buttons
		/// </summary>
		public string Fill { get; set; }
		 

		/// <summary>
		/// The padding of buttons
		/// </summary>
		public double? Padding { get; set; }
		 

		/// <summary>
		/// The border radius for buttons
		/// </summary>
		public double? R { get; set; }
		 

		/// <summary>
		/// State overrides for the buttons
		/// </summary>
		public GlobalButtonThemeStates States { get; set; }
		 

		/// <summary>
		/// The stroke color for buttons
		/// </summary>
		public string Stroke { get; set; }
		 

		/// <summary>
		/// The stroke width for buttons
		/// </summary>
		public double? StrokeWidth { get; set; }
		 

		/// <summary>
		/// CSS styling for the buttons' text
		/// </summary>
		public Hashtable Style { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Fill != null) h.Add("fill",Fill);
			if (Padding != null) h.Add("padding",Padding);
			if (R != null) h.Add("r",R);
			if (States != null) h.Add("states",States.ToHashtable(highcharts));
			if (Stroke != null) h.Add("stroke",Stroke);
			if (StrokeWidth != null) h.Add("strokeWidth",StrokeWidth);
			if (Style != null) h.Add("style",Style);
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