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
	public partial class VbpSeriesVolumeDivisionStyles  : BaseObject
	{
		Hashtable h = new Hashtable();

		public VbpSeriesVolumeDivisionStyles()
		{
		}	
		

		/// <summary>
		/// Color of negative volume bars.
		/// </summary>
		public string NegativeColor { get; set; }
		 

		/// <summary>
		/// Color of positive volume bars.
		/// </summary>
		public string PositiveColor { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (NegativeColor != null) h.Add("negativeColor",NegativeColor);
			if (PositiveColor != null) h.Add("positiveColor",PositiveColor);
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