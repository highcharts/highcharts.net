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
			Position = Position_DefaultValue = new DrilldownDrillUpButtonPosition();
			RelativeTo = RelativeTo_DefaultValue = "plotBox";
			Theme = Theme_DefaultValue = null;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Positioning options for the button within the `relativeTo` box.Available properties are `x`, `y`, `align` and `verticalAlign`.
		/// </summary>
		public DrilldownDrillUpButtonPosition Position { get; set; }
		private DrilldownDrillUpButtonPosition Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// What box to align the button to. Can be either `plotBox` or`spacingBox`.
		/// </summary>
		public string RelativeTo { get; set; }
		private string RelativeTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of attributes for the button. The object takes SVGattributes like `fill`, `stroke`, `stroke-width` or `r`, the borderradius. The theme also supports `style`, a collection of CSSproperties for the text. Equivalent attributes for the hover stateare given in `theme.states.hover`.In styled mode, drill-up button styles can be applied with the`.highcharts-drillup-button` class.
		/// </summary>
		public Object Theme { get; set; }
		private Object Theme_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Position.IsDirty(ref highcharts)) h.Add("position",Position.ToHashtable(ref highcharts));
			if (RelativeTo != RelativeTo_DefaultValue) h.Add("relativeTo",RelativeTo);
			if (Theme != Theme_DefaultValue) h.Add("theme",Theme);
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