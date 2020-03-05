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
	public partial class AnnotationsTunnelTypeOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsTunnelTypeOptions()
		{
			Background = Background_DefaultValue = new AnnotationsTunnelTypeOptionsBackground();
			Height = Height_DefaultValue = -2;
			HeightControlPoint = HeightControlPoint_DefaultValue = new AnnotationsTunnelTypeOptionsHeightControlPoint();
			Line = Line_DefaultValue = new AnnotationsTunnelTypeOptionsLine();
			Points = Points_DefaultValue = new List<AnnotationsTunnelTypeOptionsPoints>();
			XAxis = XAxis_DefaultValue = "";
			YAxis = YAxis_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Background options.
		/// </summary>
		public AnnotationsTunnelTypeOptionsBackground Background { get; set; }
		private AnnotationsTunnelTypeOptionsBackground Background_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the annotation in terms of yAxis.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the control point which controlsthe annotation's height.
		/// </summary>
		public AnnotationsTunnelTypeOptionsHeightControlPoint HeightControlPoint { get; set; }
		private AnnotationsTunnelTypeOptionsHeightControlPoint HeightControlPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsTunnelTypeOptionsLine Line { get; set; }
		private AnnotationsTunnelTypeOptionsLine Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<AnnotationsTunnelTypeOptionsPoints> Points { get; set; }
		private List<AnnotationsTunnelTypeOptionsPoints> Points_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string XAxis { get; set; }
		private string XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string YAxis { get; set; }
		private string YAxis_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Background.IsDirty()) h.Add("background",Background.ToHashtable());
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (HeightControlPoint.IsDirty()) h.Add("heightControlPoint",HeightControlPoint.ToHashtable());
			if (Line.IsDirty()) h.Add("line",Line.ToHashtable());
			if (Points != Points_DefaultValue) h.Add("points", HashifyList(Points));
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			

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