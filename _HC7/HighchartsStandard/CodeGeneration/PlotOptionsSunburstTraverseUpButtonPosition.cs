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
	public partial class PlotOptionsSunburstTraverseUpButtonPosition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSunburstTraverseUpButtonPosition()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Horizontal alignment of the button.
		/// </summary>
		public PlotOptionsSunburstTraverseUpButtonPositionAlign Align { get; set; }
		 

		/// <summary>
		/// Vertical alignment of the button.
		/// </summary>
		public PlotOptionsSunburstTraverseUpButtonPositionVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// Horizontal offset of the button.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// Vertical offset of the button.
		/// </summary>
		public double? Y { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Align != PlotOptionsSunburstTraverseUpButtonPositionAlign.Null) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (VerticalAlign != PlotOptionsSunburstTraverseUpButtonPositionVerticalAlign.Null) h.Add("verticalAlign", highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
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