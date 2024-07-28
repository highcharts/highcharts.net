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
	public partial class RangeSelectorButton  : BaseObject
	{
		Hashtable h = new Hashtable();

		public RangeSelectorButton()
		{
		}	
		

		/// <summary>
		/// How many units of the defined type the button should span. If `type`is "month" and `count` is 3, the button spans three months.
		/// </summary>
		public double? Count { get; set; }
		 

		/// <summary>
		/// A custom data grouping object for each button.
		/// </summary>
		public RangeSelectorButtonDataGrouping DataGrouping { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public RangeSelectorButtonEvents Events { get; set; }
		 

		/// <summary>
		/// Additional range (in milliseconds) added to the end of the calculatedtime span.
		/// </summary>
		public double? OffsetMax { get; set; }
		 

		/// <summary>
		/// Additional range (in milliseconds) added to the start of thecalculated time span.
		/// </summary>
		public double? OffsetMin { get; set; }
		 

		/// <summary>
		/// When buttons apply dataGrouping on a series, by default zoomingin/out will deselect buttons and unset dataGrouping. Enable thisoption to keep buttons selected when extremes change.
		/// </summary>
		public bool? PreserveDataGrouping { get; set; }
		 

		/// <summary>
		/// The text for the button itself.
		/// </summary>
		public string Text { get; set; }
		 

		/// <summary>
		/// Explanation for the button, shown as a tooltip on hover, and used byassistive technology.
		/// </summary>
		public string Title { get; set; }
		 

		/// <summary>
		/// Defined the time span for the button. Can be one of `millisecond`,`second`, `minute`, `hour`, `day`, `week`, `month`, `year`, `ytd`,and `all`.
		/// </summary>
		public string Type { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Count != null) h.Add("count",Count);
			if (DataGrouping != null) h.Add("dataGrouping",DataGrouping.ToHashtable(highstock));
			if (Events != null) h.Add("events",Events.ToHashtable(highstock));
			if (OffsetMax != null) h.Add("offsetMax",OffsetMax);
			if (OffsetMin != null) h.Add("offsetMin",OffsetMin);
			if (PreserveDataGrouping != null) h.Add("preserveDataGrouping",PreserveDataGrouping);
			if (Text != null) h.Add("text",Text);
			if (Title != null) h.Add("title",Title);
			if (Type != null) h.Add("type",Type);
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