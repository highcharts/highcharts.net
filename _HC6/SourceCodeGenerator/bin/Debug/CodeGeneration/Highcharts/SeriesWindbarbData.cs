using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class SeriesWindbarbData  : BaseObject
	{
		public SeriesWindbarbData()
		{
			Value = Value_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Value = Value_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Value = Value_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Value = Value_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The wind speed in meters per second.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind speed in meters per second.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind speed in meters per second.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind speed in meters per second.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			

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