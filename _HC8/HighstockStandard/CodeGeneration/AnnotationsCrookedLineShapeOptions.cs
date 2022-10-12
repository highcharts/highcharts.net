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
	public partial class AnnotationsCrookedLineShapeOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsCrookedLineShapeOptions()
		{
			DashStyle = DashStyle_DefaultValue = AnnotationsCrookedLineShapeOptionsDashStyle.Null;
			Fill = Fill_DefaultValue = "rgba(0, 0, 0, 0.75)";
			Height = Height_DefaultValue = null;
			R = R_DefaultValue = 0;
			Ry = Ry_DefaultValue = null;
			Snap = Snap_DefaultValue = 2;
			Src = Src_DefaultValue = "";
			Stroke = Stroke_DefaultValue = "rgba(0, 0, 0, 0.75)";
			StrokeWidth = StrokeWidth_DefaultValue = 1;
			Type = Type_DefaultValue = "rect";
			Width = Width_DefaultValue = null;
			XAxis = XAxis_DefaultValue = "";
			YAxis = YAxis_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Name of the dash style to use for the shape's stroke.
		/// </summary>
		public AnnotationsCrookedLineShapeOptionsDashStyle DashStyle { get; set; }
		private AnnotationsCrookedLineShapeOptionsDashStyle DashStyle_DefaultValue { get; set; }
		 

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
		/// The radius of the shape.
		/// </summary>
		public double? R { get; set; }
		private double? R_DefaultValue { get; set; }
		 

		/// <summary>
		/// The radius of the shape in y direction.Used for the ellipse.
		/// </summary>
		public double? Ry { get; set; }
		private double? Ry_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines additional snapping area around an annotationmaking this annotation to focus. Defined in pixels.
		/// </summary>
		public double? Snap { get; set; }
		private double? Snap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The URL for an image to use as the annotation shape.Note, type has to be set to `'image'`.
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
		/// The type of the shape.Avaliable options are circle, rect and ellipse.
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the shape.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// The xAxis index to which the points should be attached.Used for the ellipse.
		/// </summary>
		public string XAxis { get; set; }
		private string XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// The yAxis index to which the points should be attached.Used for the ellipse.
		/// </summary>
		public string YAxis { get; set; }
		private string YAxis_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", highstock.FirstCharacterToLower(DashStyle.ToString()));
			if (Fill != Fill_DefaultValue) h.Add("fill",Fill);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (R != R_DefaultValue) h.Add("r",R);
			if (Ry != Ry_DefaultValue) h.Add("ry",Ry);
			if (Snap != Snap_DefaultValue) h.Add("snap",Snap);
			if (Src != Src_DefaultValue) h.Add("src",Src);
			if (Stroke != Stroke_DefaultValue) h.Add("stroke",Stroke);
			if (StrokeWidth != StrokeWidth_DefaultValue) h.Add("strokeWidth",StrokeWidth);
			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}