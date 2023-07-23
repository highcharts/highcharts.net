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
	public partial class ChartOptions3dFrameLeft  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartOptions3dFrameLeft()
		{
			Color = Color_DefaultValue = "transparent";
			Size = Size_DefaultValue = 1;
			Visible = Visible_DefaultValue = default;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The color of the panel.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The thickness of the panel.
		/// </summary>
		public double? Size { get; set; }
		private double? Size_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display the frame. Possible values are `true`,`false`, `"auto"` to display only the frames behind thedata, and `"default"` to display faces behind the databased on the axis layout, ignoring the point of view.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Size != Size_DefaultValue) h.Add("size",Size);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}