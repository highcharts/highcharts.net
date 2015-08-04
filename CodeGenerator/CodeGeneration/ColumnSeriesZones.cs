using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highstock.Web.Mvc
{
	public partial class ColumnSeriesZones  : BaseObject
	{
		public ColumnSeriesZones()
		{
			Color = Color_DefaultValue = null;
			DashStyle = DashStyle_DefaultValue = null;
			FillColor = FillColor_DefaultValue = null;
			Value = Value_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Defines the color of the series.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// A name for the dash style to use for the graph.
		/// </summary>
		public string DashStyle { get; set; }
		private string DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the fill color for the series (in area type series)
		/// </summary>
		public string FillColor { get; set; }
		private string FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value up to where the zone extends, if undefined the zones stretches to the last value in the series.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle",DashStyle);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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