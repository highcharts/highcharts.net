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
			Text = Text_DefaultValue = "";
			Type = Type_DefaultValue = RangeSelectorButtonsType.Null;
			
		}	
		

		/// <summary>
		/// How many units of the defined type the button should span. If <code>type</code> is "month" and <code>count</code> is 3, the button spans three months.
		/// </summary>
		public double? Count { get; set; }
		private double? Count_DefaultValue { get; set; }
		 

		/// <summary>
		/// A custom data grouping object for each button.
		/// </summary>
		public Object DataGrouping { get; set; }
		private Object DataGrouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text for the button itself.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defined the time span for the button. Can be one of <code>"millisecond", "second", "minute", "hour", "day", "week", "month", "ytd", "all"</code>.
		/// </summary>
		public RangeSelectorButtonsType Type { get; set; }
		private RangeSelectorButtonsType Type_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Count != Count_DefaultValue) h.Add("count",Count);
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