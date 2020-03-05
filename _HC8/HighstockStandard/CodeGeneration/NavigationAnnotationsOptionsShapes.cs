using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class NavigationAnnotationsOptionsShapes  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationAnnotationsOptionsShapes()
		{
			Fill = Fill_DefaultValue = "rgba(0, 0, 0, 0.75)";
			Height = Height_DefaultValue = null;
			MarkerEnd = MarkerEnd_DefaultValue = "";
			MarkerStart = MarkerStart_DefaultValue = "";
			Point = Point_DefaultValue = new NavigationAnnotationsOptionsShapesPoint();
			PointString = PointString_DefaultValue = "null";
			Points = Points_DefaultValue = new NavigationAnnotationsOptionsShapesPoints();
			R = R_DefaultValue = 0;
			Snap = Snap_DefaultValue = 2;
			Stroke = Stroke_DefaultValue = "rgba(0, 0, 0, 0.75)";
			StrokeWidth = StrokeWidth_DefaultValue = 1;
			Type = Type_DefaultValue = " rect ";
			Width = Width_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The color of the shape's fill.
		/// </summary>
		public string Fill { get; set; }
		private string Fill_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the shape.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// Id of the marker which will be drawn at the final vertex of thepath. Custom markers can be defined in defs property.
		/// </summary>
		public string MarkerEnd { get; set; }
		private string MarkerEnd_DefaultValue { get; set; }
		 

		/// <summary>
		/// Id of the marker which will be drawn at the first vertex of thepath. Custom markers can be defined in defs property.
		/// </summary>
		public string MarkerStart { get; set; }
		private string MarkerStart_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option defines the point to which the shape will beconnected. It can be either the point which exists in theseries - it is referenced by the point's id - or a new point withdefined x, y properties and optionally axes.
		/// </summary>
		public NavigationAnnotationsOptionsShapesPoint Point { get; set; }
		private NavigationAnnotationsOptionsShapesPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option defines the point to which the shape will beconnected. It can be either the point which exists in theseries - it is referenced by the point's id - or a new point withdefined x, y properties and optionally axes.
		/// </summary>
		public string PointString { get; set; }
		private string PointString_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of points for the shape. This option is available forshapes which can use multiple points such as path. A point can beeither a point object or a point's id.
		/// </summary>
		public NavigationAnnotationsOptionsShapesPoints Points { get; set; }
		private NavigationAnnotationsOptionsShapesPoints Points_DefaultValue { get; set; }
		 

		/// <summary>
		/// The radius of the shape.
		/// </summary>
		public double? R { get; set; }
		private double? R_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines additional snapping area around an annotationmaking this annotation to focus. Defined in pixels.
		/// </summary>
		public double? Snap { get; set; }
		private double? Snap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the shape's stroke.
		/// </summary>
		public string Stroke { get; set; }
		private string Stroke_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel stroke width of the shape.
		/// </summary>
		public double? StrokeWidth { get; set; }
		private double? StrokeWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The type of the shape, e.g. circle or rectangle.
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the shape.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Fill != Fill_DefaultValue) h.Add("fill",Fill);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (MarkerEnd != MarkerEnd_DefaultValue) h.Add("markerEnd",MarkerEnd);
			if (MarkerStart != MarkerStart_DefaultValue) h.Add("markerStart",MarkerStart);
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (PointString != PointString_DefaultValue) h.Add("point",PointString);
			if (Points.IsDirty()) h.Add("points",Points.ToHashtable());
			if (R != R_DefaultValue) h.Add("r",R);
			if (Snap != Snap_DefaultValue) h.Add("snap",Snap);
			if (Stroke != Stroke_DefaultValue) h.Add("stroke",Stroke);
			if (StrokeWidth != StrokeWidth_DefaultValue) h.Add("strokeWidth",StrokeWidth);
			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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