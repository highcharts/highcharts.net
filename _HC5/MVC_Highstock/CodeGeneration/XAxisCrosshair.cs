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
	public partial class XAxisCrosshair  : BaseObject
	{
		public XAxisCrosshair()
		{
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "#cccccc";
			DashStyle = DashStyle_DefaultValue = XAxisCrosshairDashStyle.Solid;
			Label = Label_DefaultValue = new XAxisCrosshairLabel();
			Snap = Snap_DefaultValue = true;
			Width = Width_DefaultValue = 1;
			ZIndex = ZIndex_DefaultValue = 2;
			
		}	
		

		/// <summary>
		/// A class name for the crosshair, especially as a hook for styling.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the crosshair.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash style for the crosshair. See <a href="#plotOptions.series.dashStyle">series.dashStyle</a> for possible values.
		/// </summary>
		public XAxisCrosshairDashStyle DashStyle { get; set; }
		private XAxisCrosshairDashStyle DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A label on the axis next to the crosshair.</p><p>In <a href="http://www.highcharts.com/docs/chart-design-and-style/style-by-css">styled mode</a>, the label is styled with the <code>.highcharts-crosshair-label</code> class.</p>
		/// </summary>
		public XAxisCrosshairLabel Label { get; set; }
		private XAxisCrosshairLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the crosshair should snap to the point or follow the pointer independent of points.
		/// </summary>
		public bool? Snap { get; set; }
		private bool? Snap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the crosshair.
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
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", Highstock.FirstCharacterToLower(DashStyle.ToString()));
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (Snap != Snap_DefaultValue) h.Add("snap",Snap);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			

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