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
	public partial class ChartZoomingResetButtonPosition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartZoomingResetButtonPosition()
		{
		}	
		

		/// <summary>
		/// The horizontal alignment of the button.
		/// </summary>
		public ChartZoomingResetButtonPositionAlign Align { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the button.
		/// </summary>
		public ChartZoomingResetButtonPositionVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// The horizontal offset of the button.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// The vertical offset of the button.
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Align != ChartZoomingResetButtonPositionAlign.Null) h.Add("align", highstock.FirstCharacterToLower(Align.ToString()));
			if (VerticalAlign != ChartZoomingResetButtonPositionVerticalAlign.Null) h.Add("verticalAlign", highstock.FirstCharacterToLower(VerticalAlign.ToString()));
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