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
	public partial class ChartResetZoomButtonPosition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartResetZoomButtonPosition()
		{
		}	
		

		/// <summary>
		/// The horizontal alignment of the button.
		/// </summary>
		public double? Align { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the button.
		/// </summary>
		public ChartResetZoomButtonPositionVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// The horizontal offset of the button.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// The vertical offset of the button.
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Align != null) h.Add("align",Align);
			if (VerticalAlign != ChartResetZoomButtonPositionVerticalAlign.Null) h.Add("verticalAlign", highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
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