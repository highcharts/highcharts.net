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
	public partial class SeriesTreemapData  : BaseObject
	{
		public SeriesTreemapData()
		{
			Parent = Parent_DefaultValue = "undefined";
			Value = Value_DefaultValue = null;
			ColorValue = ColorValue_DefaultValue = null;
			Parent = Parent_DefaultValue = "undefined";
			Value = Value_DefaultValue = null;
			ColorValue = ColorValue_DefaultValue = null;
			Parent = Parent_DefaultValue = "undefined";
			Value = Value_DefaultValue = null;
			ColorValue = ColorValue_DefaultValue = null;
			Parent = Parent_DefaultValue = "undefined";
			Value = Value_DefaultValue = null;
			ColorValue = ColorValue_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Only for treemap. Use this option to build a tree structure. Thevalue should be the id of the point which is the parent. If no pointshas a matching id, or this option is undefined, then the parent willbe set to the root.
		/// </summary>
		public string Parent { get; set; }
		private string Parent_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a relative area of the pointin the treemap.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// Serves a purpose only if a `colorAxis` object is defined in the chartoptions. This value will decide which color the point gets from thescale of the colorAxis.
		/// </summary>
		public double? ColorValue { get; set; }
		private double? ColorValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// Only for treemap. Use this option to build a tree structure. Thevalue should be the id of the point which is the parent. If no pointshas a matching id, or this option is undefined, then the parent willbe set to the root.
		/// </summary>
		public string Parent { get; set; }
		private string Parent_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a relative area of the pointin the treemap.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// Serves a purpose only if a `colorAxis` object is defined in the chartoptions. This value will decide which color the point gets from thescale of the colorAxis.
		/// </summary>
		public double? ColorValue { get; set; }
		private double? ColorValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// Only for treemap. Use this option to build a tree structure. Thevalue should be the id of the point which is the parent. If no pointshas a matching id, or this option is undefined, then the parent willbe set to the root.
		/// </summary>
		public string Parent { get; set; }
		private string Parent_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a relative area of the pointin the treemap.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// Serves a purpose only if a `colorAxis` object is defined in the chartoptions. This value will decide which color the point gets from thescale of the colorAxis.
		/// </summary>
		public double? ColorValue { get; set; }
		private double? ColorValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// Only for treemap. Use this option to build a tree structure. Thevalue should be the id of the point which is the parent. If no pointshas a matching id, or this option is undefined, then the parent willbe set to the root.
		/// </summary>
		public string Parent { get; set; }
		private string Parent_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a relative area of the pointin the treemap.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// Serves a purpose only if a `colorAxis` object is defined in the chartoptions. This value will decide which color the point gets from thescale of the colorAxis.
		/// </summary>
		public double? ColorValue { get; set; }
		private double? ColorValue_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Parent != Parent_DefaultValue) h.Add("parent",Parent);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (ColorValue != ColorValue_DefaultValue) h.Add("colorValue",ColorValue);
			if (Parent != Parent_DefaultValue) h.Add("parent",Parent);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (ColorValue != ColorValue_DefaultValue) h.Add("colorValue",ColorValue);
			if (Parent != Parent_DefaultValue) h.Add("parent",Parent);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (ColorValue != ColorValue_DefaultValue) h.Add("colorValue",ColorValue);
			if (Parent != Parent_DefaultValue) h.Add("parent",Parent);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (ColorValue != ColorValue_DefaultValue) h.Add("colorValue",ColorValue);
			

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