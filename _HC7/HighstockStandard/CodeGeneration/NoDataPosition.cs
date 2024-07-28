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
	public partial class NoDataPosition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NoDataPosition()
		{
		}	
		

		/// <summary>
		/// Horizontal alignment of the label.
		/// </summary>
		public NoDataPositionAlign Align { get; set; }
		 

		/// <summary>
		/// Vertical alignment of the label.
		/// </summary>
		public NoDataPositionVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// Horizontal offset of the label, in pixels.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// Vertical offset of the label, in pixels.
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Align != NoDataPositionAlign.Null) h.Add("align", highstock.FirstCharacterToLower(Align.ToString()));
			if (VerticalAlign != NoDataPositionVerticalAlign.Null) h.Add("verticalAlign", highstock.FirstCharacterToLower(VerticalAlign.ToString()));
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