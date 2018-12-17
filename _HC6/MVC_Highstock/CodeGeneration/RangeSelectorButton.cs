using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class RangeSelectorButton  : BaseObject
	{
		public RangeSelectorButton()
		{
			Count = Count_DefaultValue = 1;
			DataGrouping = DataGrouping_DefaultValue = null;
			Events = Events_DefaultValue = new RangeSelectorButtonEvents();
			OffsetMax = OffsetMax_DefaultValue = 0;
			OffsetMin = OffsetMin_DefaultValue = 0;
			PreserveDataGrouping = PreserveDataGrouping_DefaultValue = false;
			Text = Text_DefaultValue = "";
			Type = Type_DefaultValue = RangeSelectorButtonType.Null;
			
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
		/// Defined the time span for the button. Can be one of `millisecond`,`second`, `minute`, `hour`, `day`, `week`, `month`, `ytd`, `all`.
		/// </summary>
		public RangeSelectorButtonType Type { get; set; }
		private RangeSelectorButtonType Type_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Count != Count_DefaultValue) h.Add("count",Count);
			if (DataGrouping != DataGrouping_DefaultValue) h.Add("dataGrouping",DataGrouping);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (OffsetMax != OffsetMax_DefaultValue) h.Add("offsetMax",OffsetMax);
			if (OffsetMin != OffsetMin_DefaultValue) h.Add("offsetMin",OffsetMin);
			if (PreserveDataGrouping != PreserveDataGrouping_DefaultValue) h.Add("preserveDataGrouping",PreserveDataGrouping);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Type != Type_DefaultValue) h.Add("type", Highstock.FirstCharacterToLower(Type.ToString()));
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}