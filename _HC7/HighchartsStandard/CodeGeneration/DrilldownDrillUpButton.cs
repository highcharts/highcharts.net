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
	public partial class DrilldownDrillUpButton  : BaseObject
	{
		Hashtable h = new Hashtable();

		public DrilldownDrillUpButton()
		{
		}	
		

		/// <summary>
		/// Positioning options for the button within the `relativeTo` box.Available properties are `x`, `y`, `align` and `verticalAlign`.
		/// </summary>
		public DrilldownDrillUpButtonPosition Position { get; set; }
		 

		/// <summary>
		/// What box to align the button to. Can be either `plotBox` or`spacingBox`.
		/// </summary>
		public string RelativeTo { get; set; }
		 

		/// <summary>
		/// A collection of attributes for the button. The object takes SVGattributes like `fill`, `stroke`, `stroke-width` or `r`, the borderradius. The theme also supports `style`, a collection of CSSproperties for the text. Equivalent attributes for the hover stateare given in `theme.states.hover`.In styled mode, drill-up button styles can be applied with the`.highcharts-drillup-button` class.
		/// </summary>
		public Object Theme { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Position != null) h.Add("position",Position.ToHashtable(highcharts));
			if (RelativeTo != null) h.Add("relativeTo",RelativeTo);
			if (Theme != null) h.Add("theme",Theme);
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