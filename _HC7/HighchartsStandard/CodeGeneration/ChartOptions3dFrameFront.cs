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
	public partial class ChartOptions3dFrameFront  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartOptions3dFrameFront()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The color of the panel.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// The thickness of the panel.
		/// </summary>
		public double? Size { get; set; }
		 

		/// <summary>
		/// Whether to display the frame. Possible values are `true`,`false`, `"auto"` to display only the frames behind thedata, and `"default"` to display faces behind the databased on the axis layout, ignoring the point of view.
		/// </summary>
		public bool? Visible { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Color != null) h.Add("color",Color);
			if (Size != null) h.Add("size",Size);
			if (Visible != null) h.Add("visible",Visible);
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