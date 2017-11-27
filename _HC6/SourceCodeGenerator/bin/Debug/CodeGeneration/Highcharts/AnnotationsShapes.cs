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
			Point = Point_DefaultValue = null;
			Points = Points_DefaultValue = null;
			MarkerEnd = MarkerEnd_DefaultValue = null;
			MarkerStart = MarkerStart_DefaultValue = null;
			Point = Point_DefaultValue = "";
			Points = Points_DefaultValue = "";
			MarkerEnd = MarkerEnd_DefaultValue = "";
			MarkerStart = MarkerStart_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// This option defines the point to which the shape will be connected.It can be either the point which exists in the series - it is referencedby the point's id - or a new point with defined x, y propertiesand optionally axes.
		/// </summary>
		public string Point { get; set; }
		private string Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of points for the shape. This option is available for shapeswhich can use multiple points such as path. A point can be either a point object or a point's id.
		/// </summary>
		public AnnotationsShapesPoints Points { get; set; }
		private AnnotationsShapesPoints Points_DefaultValue { get; set; }
		 

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
		/// This option defines the point to which the shape will be connected.It can be either the point which exists in the series - it is referencedby the point's id - or a new point with defined x, y propertiesand optionally axes.
		/// </summary>
		public string Point { get; set; }
		private string Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of points for the shape. This option is available for shapeswhich can use multiple points such as path. A point can be either a point object or a point's id.
		/// </summary>
		public AnnotationsShapesPoints Points { get; set; }
		private AnnotationsShapesPoints Points_DefaultValue { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Point != Point_DefaultValue) h.Add("point",Point);
			if (Points != Points_DefaultValue) h.Add("points",Points);
			if (MarkerEnd != MarkerEnd_DefaultValue) h.Add("markerEnd",MarkerEnd);
			if (MarkerStart != MarkerStart_DefaultValue) h.Add("markerStart",MarkerStart);
			if (Point != Point_DefaultValue) h.Add("point",Point);
			if (Points != Points_DefaultValue) h.Add("points",Points);
			if (MarkerEnd != MarkerEnd_DefaultValue) h.Add("markerEnd",MarkerEnd);
			if (MarkerStart != MarkerStart_DefaultValue) h.Add("markerStart",MarkerStart);
			

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