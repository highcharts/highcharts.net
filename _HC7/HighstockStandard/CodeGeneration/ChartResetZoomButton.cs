using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class ChartResetZoomButton  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartResetZoomButton()
		{
		}	
		

		/// <summary>
		/// The position of the button.
		/// </summary>
		public ChartResetZoomButtonPosition Position { get; set; }
		 

		/// <summary>
		/// What frame the button placement should be related to. Can beeither `plotBox` or `spacingBox`.
		/// </summary>
		public string RelativeTo { get; set; }
		 

		/// <summary>
		/// A collection of attributes for the button. The object takes SVGattributes like `fill`, `stroke`, `stroke-width` or `r`, theborder radius. The theme also supports `style`, a collection ofCSS properties for the text. Equivalent attributes for the hoverstate are given in `theme.states.hover`.
		/// </summary>
		public ChartResetZoomButtonTheme Theme { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Position != null) h.Add("position",Position.ToHashtable(highstock));
			if (RelativeTo != null) h.Add("relativeTo",RelativeTo);
			if (Theme != null) h.Add("theme",Theme.ToHashtable(highstock));
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