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
	public partial class NavigatorYAxisCrosshair  : BaseObject
	{
		public NavigatorYAxisCrosshair()
		{
			ClassName = ClassName_DefaultValue = null;
			Color = Color_DefaultValue = "#cccccc";
			DashStyle = DashStyle_DefaultValue = NavigatorYAxisCrosshairDashStyle.Solid;
			Snap = Snap_DefaultValue = true;
			Width = Width_DefaultValue = 1;
			ZIndex = ZIndex_DefaultValue = 2;
			Label = Label_DefaultValue = new NavigatorYAxisCrosshairLabel();
			
		}	
		

		/// <summary>
		/// <p>A class name for the crosshair, especially as a hook for styling.</p>
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the crosshair. Defaults to <code>#cccccc</code> for numeric anddatetime axes, and <code>rgba(204,214,235,0.25)</code> for category axes, wherethe crosshair by default highlights the whole category.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The dash style for the crosshair. See <a href="#plotOptions.series.dashStyle">series.dashStyle</a> for possible values.</p>
		/// </summary>
		public NavigatorYAxisCrosshairDashStyle DashStyle { get; set; }
		private NavigatorYAxisCrosshairDashStyle DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether the crosshair should snap to the point or follow the pointerindependent of points.</p>
		/// </summary>
		public bool? Snap { get; set; }
		private bool? Snap_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel width of the crosshair. Defaults to 1 for numeric or datetimeaxes, and for one category width for category axes.</p>
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The Z index of the crosshair. Higher Z indices allow drawing thecrosshair on top of the series or behind the grid lines.</p>
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A label on the axis next to the crosshair.</p><p>In styled mode, the label is styled with the <code>.highcharts-crosshair-label</code> class.</p>
		/// </summary>
		public NavigatorYAxisCrosshairLabel Label { get; set; }
		private NavigatorYAxisCrosshairLabel Label_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", Highstock.FirstCharacterToLower(DashStyle.ToString()));
			if (Snap != Snap_DefaultValue) h.Add("snap",Snap);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			

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