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
	public partial class RangeSelectorInputPosition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public RangeSelectorInputPosition()
		{
		}	
		

		/// <summary>
		/// The alignment of the input box. Allowed properties are `left`,`center`, `right`.
		/// </summary>
		public RangeSelectorInputPositionAlign Align { get; set; }
		 

		/// <summary>
		/// X offset of the input row.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// Y offset of the input row.
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Align != RangeSelectorInputPositionAlign.Null) h.Add("align", highstock.FirstCharacterToLower(Align.ToString()));
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