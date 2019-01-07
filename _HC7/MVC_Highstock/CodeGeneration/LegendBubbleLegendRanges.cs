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
	public partial class LegendBubbleLegendRanges  : BaseObject
	{
		public LegendBubbleLegendRanges()
		{
			BorderColor = BorderColor_DefaultValue = "";
			Color = Color_DefaultValue = "";
			ConnectorColor = ConnectorColor_DefaultValue = "";
			Value = Value_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// The color of the border for individual range.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the bubble for individual range.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the connector for individual range.
		/// </summary>
		public string ConnectorColor { get; set; }
		private string ConnectorColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Range size value, similar to bubble Z data.
		/// </summary>
		public string Value { get; set; }
		private string Value_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ConnectorColor != ConnectorColor_DefaultValue) h.Add("connectorColor",ConnectorColor);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			

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