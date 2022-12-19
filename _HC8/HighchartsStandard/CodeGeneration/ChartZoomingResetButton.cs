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
	public partial class ChartZoomingResetButton  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartZoomingResetButton()
		{
			Position = Position_DefaultValue = new ChartZoomingResetButtonPosition();
			RelativeTo = RelativeTo_DefaultValue = "plot";
			Theme = Theme_DefaultValue = new ChartZoomingResetButtonTheme();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The position of the button.
		/// </summary>
		public ChartZoomingResetButtonPosition Position { get; set; }
		private ChartZoomingResetButtonPosition Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// What frame the button placement should be related to. Can beeither `plotBox` or `spacingBox`.
		/// </summary>
		public string RelativeTo { get; set; }
		private string RelativeTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of attributes for the button. The object takes SVGattributes like `fill`, `stroke`, `stroke-width` or `r`, theborder radius. The theme also supports `style`, a collection ofCSS properties for the text. Equivalent attributes for the hoverstate are given in `theme.states.hover`.
		/// </summary>
		public ChartZoomingResetButtonTheme Theme { get; set; }
		private ChartZoomingResetButtonTheme Theme_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Position.IsDirty(highcharts)) h.Add("position",Position.ToHashtable(highcharts));
			if (RelativeTo != RelativeTo_DefaultValue) h.Add("relativeTo",RelativeTo);
			if (Theme.IsDirty(highcharts)) h.Add("theme",Theme.ToHashtable(highcharts));
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