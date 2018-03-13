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
	public partial class RangeSelectorButtons  : BaseObject
	{
		public RangeSelectorButtons()
		{
			Count = Count_DefaultValue = 1;
			Events = Events_DefaultValue = new RangeSelectorButtonsEvents();
			OffsetMax = OffsetMax_DefaultValue = 0;
			OffsetMin = OffsetMin_DefaultValue = 0;
			DataGrouping = DataGrouping_DefaultValue = new RangeSelectorButtonsDataGrouping();
			Text = Text_DefaultValue = "";
			Type = Type_DefaultValue = RangeSelectorButtonsType.Millisecond;
			
		}	
		

		/// <summary>
		/// How many units of the defined type the button should span. If `type`is "month" and `count` is 3, the button spans three months.
		/// </summary>
		public double? Count { get; set; }
		private double? Count_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public RangeSelectorButtonsEvents Events { get; set; }
		private RangeSelectorButtonsEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Additional range (in milliseconds) added to the end of the calculated time span.
		/// </summary>
		public double? OffsetMax { get; set; }
		private double? OffsetMax_DefaultValue { get; set; }
		 

		/// <summary>
		/// Additional range (in milliseconds) added to the start of the calculated time span.
		/// </summary>
		public double? OffsetMin { get; set; }
		private double? OffsetMin_DefaultValue { get; set; }
		 

		/// <summary>
		/// A custom data grouping object for each button.
		/// </summary>
		public RangeSelectorButtonsDataGrouping DataGrouping { get; set; }
		private RangeSelectorButtonsDataGrouping DataGrouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text for the button itself.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defined the time span for the button. Can be one of `"millisecond","second", "minute", "hour", "day", "week", "month", "ytd", "all"`.
		/// </summary>
		public RangeSelectorButtonsType Type { get; set; }
		private RangeSelectorButtonsType Type_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Count != Count_DefaultValue) h.Add("count",Count);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (OffsetMax != OffsetMax_DefaultValue) h.Add("offsetMax",OffsetMax);
			if (OffsetMin != OffsetMin_DefaultValue) h.Add("offsetMin",OffsetMin);
			if (DataGrouping.IsDirty()) h.Add("dataGrouping",DataGrouping.ToHashtable());
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