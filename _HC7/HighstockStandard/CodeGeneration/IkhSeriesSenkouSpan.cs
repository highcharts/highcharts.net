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
	public partial class IkhSeriesSenkouSpan  : BaseObject
	{
		Hashtable h = new Hashtable();

		public IkhSeriesSenkouSpan()
		{
		}	
		

		/// <summary>
		/// Color of the area between Senkou Span A and B,when Senkou Span A is above Senkou Span B. Note that ifa `style.fill` is defined, the `color` takes precedence andthe `style.fill` is ignored.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// Color of the area between Senkou Span A and B,when Senkou Span A is under Senkou Span B.
		/// </summary>
		public string NegativeColor { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Color != null) h.Add("color",Color);
			if (NegativeColor != null) h.Add("negativeColor",NegativeColor);
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