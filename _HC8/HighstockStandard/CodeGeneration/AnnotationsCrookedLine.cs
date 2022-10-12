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
	public partial class AnnotationsCrookedLine  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsCrookedLine()
		{
			ControlPointOptions = ControlPointOptions_DefaultValue = new AnnotationsCrookedLineControlPointOptions();
			LabelOptions = LabelOptions_DefaultValue = new AnnotationsCrookedLineLabelOptions();
			ShapeOptions = ShapeOptions_DefaultValue = new AnnotationsCrookedLineShapeOptions();
			TypeOptions = TypeOptions_DefaultValue = new AnnotationsCrookedLineTypeOptions();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsCrookedLineControlPointOptions ControlPointOptions { get; set; }
		private AnnotationsCrookedLineControlPointOptions ControlPointOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsCrookedLineLabelOptions LabelOptions { get; set; }
		private AnnotationsCrookedLineLabelOptions LabelOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsCrookedLineShapeOptions ShapeOptions { get; set; }
		private AnnotationsCrookedLineShapeOptions ShapeOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Additional options for an annotation with the type.
		/// </summary>
		public AnnotationsCrookedLineTypeOptions TypeOptions { get; set; }
		private AnnotationsCrookedLineTypeOptions TypeOptions_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (ControlPointOptions.IsDirty(ref highstock)) h.Add("controlPointOptions",ControlPointOptions.ToHashtable(ref highstock));
			if (LabelOptions.IsDirty(ref highstock)) h.Add("labelOptions",LabelOptions.ToHashtable(ref highstock));
			if (ShapeOptions.IsDirty(ref highstock)) h.Add("shapeOptions",ShapeOptions.ToHashtable(ref highstock));
			if (TypeOptions.IsDirty(ref highstock)) h.Add("typeOptions",TypeOptions.ToHashtable(ref highstock));
			

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