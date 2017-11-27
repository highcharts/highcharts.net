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
	public partial class SeriesVariwideData  : BaseObject
	{
		public SeriesVariwideData()
		{
			Z = Z_DefaultValue = null;
			Z = Z_DefaultValue = null;
			Z = Z_DefaultValue = null;
			Z = Z_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The relative width for each column. The widths are distributed so they sum up to the X axis length.
		/// </summary>
		public double? Z { get; set; }
		private double? Z_DefaultValue { get; set; }
		 

		/// <summary>
		/// The relative width for each column. The widths are distributed so they sum up to the X axis length.
		/// </summary>
		public double? Z { get; set; }
		private double? Z_DefaultValue { get; set; }
		 

		/// <summary>
		/// The relative width for each column. The widths are distributed so they sum up to the X axis length.
		/// </summary>
		public double? Z { get; set; }
		private double? Z_DefaultValue { get; set; }
		 

		/// <summary>
		/// The relative width for each column. The widths are distributed so they sum up to the X axis length.
		/// </summary>
		public double? Z { get; set; }
		private double? Z_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			

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