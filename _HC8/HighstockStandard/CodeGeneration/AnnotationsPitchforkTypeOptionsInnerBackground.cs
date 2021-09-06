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
	public partial class AnnotationsPitchforkTypeOptionsInnerBackground  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsPitchforkTypeOptionsInnerBackground()
		{
			DashStyle = DashStyle_DefaultValue = AnnotationsPitchforkTypeOptionsInnerBackgroundDashStyle.Null;
			Fill = Fill_DefaultValue = "rgba(130, 170, 255, 0.4)";
			Snap = Snap_DefaultValue = 2;
			Src = Src_DefaultValue = "";
			Stroke = Stroke_DefaultValue = "rgba(0, 0, 0, 0.75)";
			StrokeWidth = StrokeWidth_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// Name of the dash style to use for the shape's stroke.
		/// </summary>
		public AnnotationsPitchforkTypeOptionsInnerBackgroundDashStyle DashStyle { get; set; }
		private AnnotationsPitchforkTypeOptionsInnerBackgroundDashStyle DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Fill { get; set; }
		private string Fill_DefaultValue { get; set; }
		 

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
		/// 
		/// </summary>
		public double? StrokeWidth { get; set; }
		private double? StrokeWidth_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", Highstock.FirstCharacterToLower(DashStyle.ToString()));
			if (Fill != Fill_DefaultValue) h.Add("fill",Fill);
			if (Snap != Snap_DefaultValue) h.Add("snap",Snap);
			if (Src != Src_DefaultValue) h.Add("src",Src);
			if (Stroke != Stroke_DefaultValue) h.Add("stroke",Stroke);
			if (StrokeWidth != StrokeWidth_DefaultValue) h.Add("strokeWidth",StrokeWidth);
			

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