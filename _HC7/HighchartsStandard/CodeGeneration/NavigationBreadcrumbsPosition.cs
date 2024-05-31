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
	public partial class NavigationBreadcrumbsPosition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationBreadcrumbsPosition()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Horizontal alignment of the breadcrumbs buttons.
		/// </summary>
		public NavigationBreadcrumbsPositionAlign Align { get; set; }
		 

		/// <summary>
		/// Vertical alignment of the breadcrumbs buttons.
		/// </summary>
		public NavigationBreadcrumbsPositionVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// The X offset of the breadcrumbs button group.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// The Y offset of the breadcrumbs button group. When `undefined`,and `floating` is `false`, the `y` position is adapted so thatthe breadcrumbs are rendered outside the target area.
		/// </summary>
		public double? Y { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Align != NavigationBreadcrumbsPositionAlign.Null) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (VerticalAlign != NavigationBreadcrumbsPositionVerticalAlign.Null) h.Add("verticalAlign", highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != null) h.Add("x",X);
			if (Y != null) h.Add("y",Y);
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