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
	public partial class DrilldownDrillUpButtonPosition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public DrilldownDrillUpButtonPosition()
		{
		}	
		

		/// <summary>
		/// Horizontal alignment.
		/// </summary>
		public DrilldownDrillUpButtonPositionAlign Align { get; set; }
		 

		/// <summary>
		/// Vertical alignment of the button.
		/// </summary>
		public DrilldownDrillUpButtonPositionVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// The X offset of the button.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// The Y offset of the button.
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Align != DrilldownDrillUpButtonPositionAlign.Null) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (VerticalAlign != DrilldownDrillUpButtonPositionVerticalAlign.Null) h.Add("verticalAlign", highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
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