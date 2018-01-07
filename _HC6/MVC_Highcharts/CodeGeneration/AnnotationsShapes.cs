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
	public partial class AnnotationsShapes  : BaseObject
	{
		public AnnotationsShapes()
		{
			Point = Point_DefaultValue = new AnnotationsShapesPoint();
			Points = Points_DefaultValue = new List<AnnotationsShapesPoint>();
			MarkerEnd = MarkerEnd_DefaultValue = "";
			MarkerStart = MarkerStart_DefaultValue = "";
			Stroke = Stroke_DefaultValue = "rgba(0, 0, 0, 0.75)";
			StrokeWidth = StrokeWidth_DefaultValue = 1;
			Fill = Fill_DefaultValue = "rgba(0, 0, 0, 0.75)";
			R = R_DefaultValue = 0;
			Type = Type_DefaultValue = "'rect'";
			Width = Width_DefaultValue = null;
			Height = Height_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// This option defines the point to which the shape will be connected.It can be either the point which exists in the series - it is referencedby the point's id - or a new point with defined x, y propertiesand optionally axes.
		/// </summary>
		public string Point { get; set; }
		private string Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of points for the shape. This option is available for shapeswhich can use multiple points such as path. A point can be either a point object or a point's id.
		/// </summary>
		public List<AnnotationsShapesPoint> Points { get; set; }
		private List<AnnotationsShapesPoint> Points_DefaultValue { get; set; }
		 

		/// <summary>
		/// Id of the marker which will be drawn at the final vertex of the path.Custom markers can be defined in defs property.
		/// </summary>
		public string MarkerEnd { get; set; }
		private string MarkerEnd_DefaultValue { get; set; }
		 

		/// <summary>
		/// Id of the marker which will be drawn at the first vertex of the path.Custom markers can be defined in defs property.
		/// </summary>
		public string MarkerStart { get; set; }
		private string MarkerStart_DefaultValue { get; set; }
		 

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
		/// The color of the shape's fill.
		/// </summary>
		public string Fill { get; set; }
		private string Fill_DefaultValue { get; set; }
		 

		/// <summary>
		/// The radius of the shape.
		/// </summary>
		public double? R { get; set; }
		private double? R_DefaultValue { get; set; }
		 

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
		 

		/// <summary>
		/// The height of the shape.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (Points != Points_DefaultValue) h.Add("points", HashifyList(Points));
			if (MarkerEnd != MarkerEnd_DefaultValue) h.Add("markerEnd",MarkerEnd);
			if (MarkerStart != MarkerStart_DefaultValue) h.Add("markerStart",MarkerStart);
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