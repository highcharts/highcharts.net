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
		}	
		

		/// <summary>
		/// Name of the dash style to use for the shape's stroke.
		/// </summary>
		public AnnotationsShapesDashStyle DashStyle { get; set; }
		 

		/// <summary>
		/// The color of the shape's fill.
		/// </summary>
		public string Fill { get; set; }
		 

		/// <summary>
		/// The height of the shape.
		/// </summary>
		public double? Height { get; set; }
		 

		/// <summary>
		/// Id of the marker which will be drawn at the final vertex ofthe path. Custom markers can be defined in defs property.
		/// </summary>
		public string MarkerEnd { get; set; }
		 

		/// <summary>
		/// Id of the marker which will be drawn at the first vertex ofthe path. Custom markers can be defined in defs property.
		/// </summary>
		public string MarkerStart { get; set; }
		 

		/// <summary>
		/// This option defines the point to which the shape will beconnected. It can be either the point which exists in theseries - it is referenced by the point's id - or a new pointwith defined x, y properties and optionally axes.
		/// </summary>
		public AnnotationsShapesPoint Point { get; set; }
		 

		/// <summary>
		/// This option defines the point to which the shape will beconnected. It can be either the point which exists in theseries - it is referenced by the point's id - or a new pointwith defined x, y properties and optionally axes.
		/// </summary>
		public string PointString { get; set; }
		 

		/// <summary>
		/// An array of points for the shapeor a callback function that returns that shape point.This option is availablefor shapes which can use multiple points such as path. Apoint can be either a point object or a point's id.
		/// </summary>
		public List<AnnotationsShapesPoints> Points { get; set; }
		 

		/// <summary>
		/// The radius of the shape.
		/// </summary>
		public double? R { get; set; }
		 

		/// <summary>
		/// The radius of the shape in y direction.Used for the ellipse.
		/// </summary>
		public double? Ry { get; set; }
		 

		/// <summary>
		/// Defines additional snapping area around an annotationmaking this annotation to focus. Defined in pixels.
		/// </summary>
		public double? Snap { get; set; }
		 

		/// <summary>
		/// The URL for an image to use as the annotation shape. Note,type has to be set to `'image'`.
		/// </summary>
		public string Src { get; set; }
		 

		/// <summary>
		/// The color of the shape's stroke.
		/// </summary>
		public string Stroke { get; set; }
		 

		/// <summary>
		/// The pixel stroke width of the shape.
		/// </summary>
		public double? StrokeWidth { get; set; }
		 

		/// <summary>
		/// The type of the shape.Available options are circle, rect and ellipse.
		/// </summary>
		public string Type { get; set; }
		 

		/// <summary>
		/// The width of the shape.
		/// </summary>
		public double? Width { get; set; }
		 

		/// <summary>
		/// The xAxis index to which the points should be attached.Used for the ellipse.
		/// </summary>
		public string XAxis { get; set; }
		 

		/// <summary>
		/// The yAxis index to which the points should be attached.Used for the ellipse.
		/// </summary>
		public string YAxis { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (DashStyle != AnnotationsShapesDashStyle.Null) h.Add("dashStyle", highstock.FirstCharacterToLower(DashStyle.ToString()));
			if (Fill != null) h.Add("fill",Fill);
			if (Height != null) h.Add("height",Height);
			if (MarkerEnd != null) h.Add("markerEnd",MarkerEnd);
			if (MarkerStart != null) h.Add("markerStart",MarkerStart);
			if (Point != null) h.Add("point",Point.ToHashtable(highstock));
			if (PointString != null) h.Add("point",PointString);
			if (Points != null) h.Add("points", HashifyList(highstock,Points));
			if (R != null) h.Add("r",R);
			if (Ry != null) h.Add("ry",Ry);
			if (Snap != null) h.Add("snap",Snap);
			if (Src != null) h.Add("src",Src);
			if (Stroke != null) h.Add("stroke",Stroke);
			if (StrokeWidth != null) h.Add("strokeWidth",StrokeWidth);
			if (Type != null) h.Add("type",Type);
			if (Width != null) h.Add("width",Width);
			if (XAxis != null) h.Add("xAxis",XAxis);
			if (YAxis != null) h.Add("yAxis",YAxis);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}