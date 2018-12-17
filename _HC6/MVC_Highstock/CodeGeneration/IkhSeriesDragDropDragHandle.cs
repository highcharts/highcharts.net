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
	public partial class IkhSeriesDragDropDragHandle  : BaseObject
	{
		public IkhSeriesDragDropDragHandle()
		{
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "#fff";
			Cursor = Cursor_DefaultValue = "";
			LineColor = LineColor_DefaultValue = "rgba(0, 0, 0, 0.6)";
			LineWidth = LineWidth_DefaultValue = 2;
			PathFormatter = PathFormatter_DefaultValue = "";
			ZIndex = ZIndex_DefaultValue = 901;
			
		}	
		

		/// <summary>
		/// The class name of the drag handles. Defaults to `highcharts-drag-handle`.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color of the drag handles.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The mouse cursor to use for the drag handles. By default this isintelligently switching between `ew-resize` and `ns-resize` dependingon the direction the point is being dragged.
		/// </summary>
		public string Cursor { get; set; }
		private string Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line color of the drag handles.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line width for the drag handles.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Function to define the SVG path to use for the drag handles. Takesthe point as argument. Should return an SVG path in array format. TheSVG path is automatically positioned on the point.
		/// </summary>
		public string PathFormatter { get; set; }
		private string PathFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// The z index for the drag handles.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (PathFormatter != PathFormatter_DefaultValue) { h.Add("pathFormatter",PathFormatter); Highstock.AddFunction("IkhSeriesDragDropDragHandlePathFormatter.pathFormatter", PathFormatter); }  
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