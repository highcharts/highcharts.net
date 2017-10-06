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
	public partial class AnnotationsShapeOptions  : BaseObject
	{
		public AnnotationsShapeOptions()
		{
			Stroke = Stroke_DefaultValue = "rgba(0, 0, 0, 0.75)";
			StrokeWidth = StrokeWidth_DefaultValue = null;
			Fill = Fill_DefaultValue = "rgba(0, 0, 0, 0.75)";
			R = R_DefaultValue = null;
			Type = Type_DefaultValue = "'rect'";
			Width = Width_DefaultValue = null;
			Height = Height_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The color of the shape&#39;s stroke.</p>
		/// </summary>
		public string Stroke { get; set; }
		private string Stroke_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel stroke width of the shape.</p>
		/// </summary>
		public double? StrokeWidth { get; set; }
		private double? StrokeWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the shape&#39;s fill.</p>
		/// </summary>
		public string Fill { get; set; }
		private string Fill_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The radius of the shape.</p>
		/// </summary>
		public double? R { get; set; }
		private double? R_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The type of the shape, e.g. circle or rectangle.</p>
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width of the shape.</p>
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The height of the shape.</p>
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Stroke != Stroke_DefaultValue) h.Add("stroke",Stroke);
			if (StrokeWidth != StrokeWidth_DefaultValue) h.Add("strokeWidth",StrokeWidth);
			if (Fill != Fill_DefaultValue) h.Add("fill",Fill);
			if (R != R_DefaultValue) h.Add("r",R);
			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			

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