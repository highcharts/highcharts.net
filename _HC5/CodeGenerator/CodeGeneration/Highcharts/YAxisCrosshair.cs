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
	public partial class YAxisCrosshair  : BaseObject
	{
		public YAxisCrosshair()
		{
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = null;
			DashStyle = DashStyle_DefaultValue = YAxisCrosshairDashStyle.Solid;
			Snap = Snap_DefaultValue = true;
			Width = Width_DefaultValue = null;
			ZIndex = ZIndex_DefaultValue = 2;
			
		}	
		

		/// <summary>
		/// A class name for the crosshair, especially as a hook for styling.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the crosshair. Defaults to <code>#cccccc</code> for numeric and datetime axes, and <code>rgba(204,214,235,0.25)</code> for category axes, where the crosshair by default highlights the whole category.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash style for the crosshair. See <a href="#plotOptions.series.dashStyle">series.dashStyle</a> for possible values.
		/// </summary>
		public YAxisCrosshairDashStyle DashStyle { get; set; }
		private YAxisCrosshairDashStyle DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the crosshair should snap to the point or follow the pointer independent of points.
		/// </summary>
		public bool? Snap { get; set; }
		private bool? Snap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the crosshair. Defaults to 1 for numeric or datetime axes, and for one category width for category axes.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index of the crosshair. Higher Z indices allow drawing the crosshair on top of the series or behind the grid lines.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", Highcharts.FirstCharacterToLower(DashStyle.ToString()));
			if (Snap != Snap_DefaultValue) h.Add("snap",Snap);
			if (Width != Width_DefaultValue) h.Add("width",Width);
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