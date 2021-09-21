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
	public partial class AnnotationsShapes  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsShapes()
		{
			DashStyle = DashStyle_DefaultValue = AnnotationsShapesDashStyle.Null;
			Fill = Fill_DefaultValue = "rgba(0, 0, 0, 0.75)";
			Height = Height_DefaultValue = null;
			MarkerEnd = MarkerEnd_DefaultValue = "";
			MarkerStart = MarkerStart_DefaultValue = "";
			Point = Point_DefaultValue = new AnnotationsShapesPoint();
			PointString = PointString_DefaultValue = "null";
			Points = Points_DefaultValue = new List<AnnotationsShapesPoints>();
			R = R_DefaultValue = 0;
			Snap = Snap_DefaultValue = 2;
			Src = Src_DefaultValue = "";
			Stroke = Stroke_DefaultValue = "rgba(0, 0, 0, 0.75)";
			StrokeWidth = StrokeWidth_DefaultValue = 1;
			Type = Type_DefaultValue = "rect";
			Width = Width_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Name of the dash style to use for the shape's stroke.
		/// </summary>
		public AnnotationsShapesDashStyle DashStyle { get; set; }
		private AnnotationsShapesDashStyle DashStyle_DefaultValue { get; set; }
		 

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
		/// Id of the marker which will be drawn at the final vertex ofthe path. Custom markers can be defined in defs property.
		/// </summary>
		public string MarkerEnd { get; set; }
		private string MarkerEnd_DefaultValue { get; set; }
		 

		/// <summary>
		/// Id of the marker which will be drawn at the first vertex ofthe path. Custom markers can be defined in defs property.
		/// </summary>
		public string MarkerStart { get; set; }
		private string MarkerStart_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option defines the point to which the shape will beconnected. It can be either the point which exists in theseries - it is referenced by the point's id - or a new pointwith defined x, y properties and optionally axes.
		/// </summary>
		public AnnotationsShapesPoint Point { get; set; }
		private AnnotationsShapesPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option defines the point to which the shape will beconnected. It can be either the point which exists in theseries - it is referenced by the point's id - or a new pointwith defined x, y properties and optionally axes.
		/// </summary>
		public string PointString { get; set; }
		private string PointString_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of points for the shapeor a callback function that returns that shape point.This option is availablefor shapes which can use multiple points such as path. Apoint can be either a point object or a point's id.
		/// </summary>
		public List<AnnotationsShapesPoints> Points { get; set; }
		private List<AnnotationsShapesPoints> Points_DefaultValue { get; set; }
		 

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
		/// The URL for an image to use as the annotation shape. Note,type has to be set to `'image'`.
		/// </summary>
		public string Src { get; set; }
		private string Src_DefaultValue { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", Highstock.FirstCharacterToLower(DashStyle.ToString()));
			if (Fill != Fill_DefaultValue) h.Add("fill",Fill);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (MarkerEnd != MarkerEnd_DefaultValue) h.Add("markerEnd",MarkerEnd);
			if (MarkerStart != MarkerStart_DefaultValue) h.Add("markerStart",MarkerStart);
			if (Point.IsDirty(ref highstock)) h.Add("point",Point.ToHashtable(ref highstock));
			if (PointString != PointString_DefaultValue) h.Add("point",PointString);
			if (Points != Points_DefaultValue) h.Add("points", HashifyList(ref highstock,Points));
			if (R != R_DefaultValue) h.Add("r",R);
			if (Snap != Snap_DefaultValue) h.Add("snap",Snap);
			if (Src != Src_DefaultValue) h.Add("src",Src);
			if (Stroke != Stroke_DefaultValue) h.Add("stroke",Stroke);
			if (StrokeWidth != StrokeWidth_DefaultValue) h.Add("strokeWidth",StrokeWidth);
			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}