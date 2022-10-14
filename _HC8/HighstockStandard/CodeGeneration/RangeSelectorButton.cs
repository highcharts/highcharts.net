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
			Count = Count_DefaultValue = 1;
			DataGrouping = DataGrouping_DefaultValue = null;
			Events = Events_DefaultValue = new RangeSelectorButtonEvents();
			OffsetMax = OffsetMax_DefaultValue = 0;
			OffsetMin = OffsetMin_DefaultValue = 0;
			PreserveDataGrouping = PreserveDataGrouping_DefaultValue = false;
			Text = Text_DefaultValue = "";
			Title = Title_DefaultValue = "";
			Type = Type_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// How many units of the defined type the button should span. If `type`is "month" and `count` is 3, the button spans three months.
		/// </summary>
		public double? Count { get; set; }
		private double? Count_DefaultValue { get; set; }
		 

		/// <summary>
		/// A custom data grouping object for each button.
		/// </summary>
		public Object DataGrouping { get; set; }
		private Object DataGrouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public RangeSelectorButtonEvents Events { get; set; }
		private RangeSelectorButtonEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Additional range (in milliseconds) added to the end of the calculatedtime span.
		/// </summary>
		public double? OffsetMax { get; set; }
		private double? OffsetMax_DefaultValue { get; set; }
		 

		/// <summary>
		/// Additional range (in milliseconds) added to the start of thecalculated time span.
		/// </summary>
		public double? OffsetMin { get; set; }
		private double? OffsetMin_DefaultValue { get; set; }
		 

		/// <summary>
		/// When buttons apply dataGrouping on a series, by default zoomingin/out will deselect buttons and unset dataGrouping. Enable thisoption to keep buttons selected when extremes change.
		/// </summary>
		public bool? PreserveDataGrouping { get; set; }
		private bool? PreserveDataGrouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text for the button itself.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// Explanation for the button, shown as a tooltip on hover, and used byassistive technology.
		/// </summary>
		public string Title { get; set; }
		private string Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defined the time span for the button. Can be one of `millisecond`,`second`, `minute`, `hour`, `day`, `week`, `month`, `year`, `ytd`,and `all`.
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Count != Count_DefaultValue) h.Add("count",Count);
			if (DataGrouping != DataGrouping_DefaultValue) h.Add("dataGrouping",DataGrouping);
			if (Events.IsDirty(highstock)) h.Add("events",Events.ToHashtable(highstock));
			if (OffsetMax != OffsetMax_DefaultValue) h.Add("offsetMax",OffsetMax);
			if (OffsetMin != OffsetMin_DefaultValue) h.Add("offsetMin",OffsetMin);
			if (PreserveDataGrouping != PreserveDataGrouping_DefaultValue) h.Add("preserveDataGrouping",PreserveDataGrouping);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Title != Title_DefaultValue) h.Add("title",Title);
			if (Type != Type_DefaultValue) h.Add("type",Type);
			

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