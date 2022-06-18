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
	public partial class SunburstSeriesBreadcrumbsPosition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public SunburstSeriesBreadcrumbsPosition()
		{
			Align = Align_DefaultValue = SunburstSeriesBreadcrumbsPositionAlign.Left;
			VerticalAlign = VerticalAlign_DefaultValue = SunburstSeriesBreadcrumbsPositionVerticalAlign.Top;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = null;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Horizontal alignment of the breadcrumbs buttons.
		/// </summary>
		public SunburstSeriesBreadcrumbsPositionAlign Align { get; set; }
		private SunburstSeriesBreadcrumbsPositionAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical alignment of the breadcrumbs buttons.
		/// </summary>
		public SunburstSeriesBreadcrumbsPositionVerticalAlign VerticalAlign { get; set; }
		private SunburstSeriesBreadcrumbsPositionVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The X offset of the breadcrumbs button group.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Y offset of the breadcrumbs button group. When `undefined`,and `floating` is `false`, the `y` position is adapted so thatthe breadcrumbs are rendered outside the target area.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Align != Align_DefaultValue) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}