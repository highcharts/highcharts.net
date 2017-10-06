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
	public partial class ScatterSeriesIkhZone  : BaseObject
	{
		public ScatterSeriesIkhZone()
		{
			ClassName = ClassName_DefaultValue = null;
			Color = Color_DefaultValue = null;
			DashStyle = DashStyle_DefaultValue = null;
			FillColor = FillColor_DefaultValue = null;
			Value = Value_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Styled mode only. A custom class name for the zone.</p>
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Defines the color of the series.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A name for the dash style to use for the graph.</p>
		/// </summary>
		public string DashStyle { get; set; }
		private string DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Defines the fill color for the series (in area type series)</p>
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The value up to where the zone extends, if undefined the zones stretchesto the last value in the series.</p>
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle",DashStyle);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
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