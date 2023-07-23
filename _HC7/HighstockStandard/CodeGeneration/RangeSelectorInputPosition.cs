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
			Align = Align_DefaultValue = RangeSelectorInputPositionAlign.Right;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = 0;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The alignment of the input box. Allowed properties are `left`,`center`, `right`.
		/// </summary>
		public RangeSelectorInputPositionAlign Align { get; set; }
		private RangeSelectorInputPositionAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// X offset of the input row.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Y offset of the input row.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Align != Align_DefaultValue) h.Add("align", highstock.FirstCharacterToLower(Align.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}