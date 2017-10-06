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
			Count = Count_DefaultValue = 0;
			Events = Events_DefaultValue = new RangeSelectorButtonsEvents();
			OffsetMax = OffsetMax_DefaultValue = 0;
			OffsetMin = OffsetMin_DefaultValue = 0;
			DataGrouping = DataGrouping_DefaultValue = null;
			Text = Text_DefaultValue = null;
			Type = Type_DefaultValue = RangeSelectorButtonsType.Null;
			
		}	
		

		/// <summary>
		/// <p>How many units of the defined type the button should span. If <code>type</code>is &quot;month&quot; and <code>count</code> is 3, the button spans three months.</p>
		/// </summary>
		public double? Count { get; set; }
		private double? Count_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public RangeSelectorButtonsEvents Events { get; set; }
		private RangeSelectorButtonsEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Additional range (in milliseconds) added to the end of the calculated time span.</p>
		/// </summary>
		public double? OffsetMax { get; set; }
		private double? OffsetMax_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Additional range (in milliseconds) added to the start of the calculated time span.</p>
		/// </summary>
		public double? OffsetMin { get; set; }
		private double? OffsetMin_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A custom data grouping object for each button.</p>
		/// </summary>
		public Object DataGrouping { get; set; }
		private Object DataGrouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The text for the button itself.</p>
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Defined the time span for the button. Can be one of <code>&quot;millisecond&quot;,&quot;second&quot;, &quot;minute&quot;, &quot;hour&quot;, &quot;day&quot;, &quot;week&quot;, &quot;month&quot;, &quot;ytd&quot;, &quot;all&quot;</code>.</p>
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
			if (DataGrouping != DataGrouping_DefaultValue) h.Add("dataGrouping",DataGrouping);
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