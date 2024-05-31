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
	public partial class ChartParallelAxesStackShadow  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartParallelAxesStackShadow()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The color of the `stackShadow` border.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// The width of the `stackShadow` border.
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// The color of the `stackShadow`.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// Enable or disable `stackShadow`.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (Color != null) h.Add("color",Color);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (CustomFields.Count > 0)
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