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
	public partial class SeriesVectorData  : BaseObject
	{
		public SeriesVectorData()
		{
			Length = Length_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Length = Length_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Length = Length_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Length = Length_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The length of the vector. The rendered length will relate to the`vectorLength` setting.
		/// </summary>
		public double? Length { get; set; }
		private double? Length_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vector direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the vector. The rendered length will relate to the`vectorLength` setting.
		/// </summary>
		public double? Length { get; set; }
		private double? Length_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vector direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the vector. The rendered length will relate to the`vectorLength` setting.
		/// </summary>
		public double? Length { get; set; }
		private double? Length_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vector direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the vector. The rendered length will relate to the`vectorLength` setting.
		/// </summary>
		public double? Length { get; set; }
		private double? Length_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vector direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Length != Length_DefaultValue) h.Add("length",Length);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (Length != Length_DefaultValue) h.Add("length",Length);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (Length != Length_DefaultValue) h.Add("length",Length);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (Length != Length_DefaultValue) h.Add("length",Length);
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