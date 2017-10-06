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
	public partial class RangeSelectorButtonTheme  : BaseObject
	{
		public RangeSelectorButtonTheme()
		{
			Undefined = Undefined_DefaultValue = null;
			Width = Width_DefaultValue = null;
			Height = Height_DefaultValue = null;
			Padding = Padding_DefaultValue = null;
			ZIndex = ZIndex_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public double? Undefined { get; set; }
		private double? Undefined_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Padding { get; set; }
		private double? Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Undefined != Undefined_DefaultValue) h.Add("undefined",Undefined);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			

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