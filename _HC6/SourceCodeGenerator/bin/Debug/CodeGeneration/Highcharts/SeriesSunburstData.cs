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
	public partial class SeriesSunburstData  : BaseObject
	{
		public SeriesSunburstData()
		{
			Value = Value_DefaultValue = null;
			Name = Name_DefaultValue = "undefined";
			Weight = Weight_DefaultValue = null;
			Value = Value_DefaultValue = null;
			Name = Name_DefaultValue = "undefined";
			Weight = Weight_DefaultValue = null;
			Value = Value_DefaultValue = null;
			Name = Name_DefaultValue = "undefined";
			Weight = Weight_DefaultValue = null;
			Value = Value_DefaultValue = null;
			Name = Name_DefaultValue = "undefined";
			Weight = Weight_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The value of the point, resulting in a relative area of the pointin the sunburst.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name decides the text for a word.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// The weighting of a word. The weight decides the relative size of a wordcompared to the rest of the collection.
		/// </summary>
		public double? Weight { get; set; }
		private double? Weight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a relative area of the pointin the sunburst.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name decides the text for a word.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// The weighting of a word. The weight decides the relative size of a wordcompared to the rest of the collection.
		/// </summary>
		public double? Weight { get; set; }
		private double? Weight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a relative area of the pointin the sunburst.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name decides the text for a word.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// The weighting of a word. The weight decides the relative size of a wordcompared to the rest of the collection.
		/// </summary>
		public double? Weight { get; set; }
		private double? Weight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a relative area of the pointin the sunburst.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name decides the text for a word.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// The weighting of a word. The weight decides the relative size of a wordcompared to the rest of the collection.
		/// </summary>
		public double? Weight { get; set; }
		private double? Weight_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			

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