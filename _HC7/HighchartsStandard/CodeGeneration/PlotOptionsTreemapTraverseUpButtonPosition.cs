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
	public partial class PlotOptionsTreemapTraverseUpButtonPosition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTreemapTraverseUpButtonPosition()
		{
		}	
		

		/// <summary>
		/// Horizontal alignment of the button.
		/// </summary>
		public PlotOptionsTreemapTraverseUpButtonPositionAlign Align { get; set; }
		 

		/// <summary>
		/// Vertical alignment of the button.
		/// </summary>
		public PlotOptionsTreemapTraverseUpButtonPositionVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// Horizontal offset of the button.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// Vertical offset of the button.
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Align != PlotOptionsTreemapTraverseUpButtonPositionAlign.Null) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (VerticalAlign != PlotOptionsTreemapTraverseUpButtonPositionVerticalAlign.Null) h.Add("verticalAlign", highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != null) h.Add("x",X);
			if (Y != null) h.Add("y",Y);
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