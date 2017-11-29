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
	public partial class Annotations  : BaseObject
	{
		public Annotations()
		{
			Visible = Visible_DefaultValue = True;
			LabelOptions = LabelOptions_DefaultValue = "";
			ShapeOptions = ShapeOptions_DefaultValue = "";
			ZIndex = ZIndex_DefaultValue = 6;
			Labels = Labels_DefaultValue = "";
			Shapes = Shapes_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Whether the annotation is visible.
		/// </summary>
		public Annotationsvisible Visible { get; set; }
		private Annotationsvisible Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for annotation's labels. Each label inherits optionsfrom the labelOptions object. An option from the labelOptions can beoverwritten by config for a specific label.
		/// </summary>
		public AnnotationslabelOptions LabelOptions { get; set; }
		private AnnotationslabelOptions LabelOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for annotation's shapes. Each shape inherits optionsfrom the shapeOptions object. An option from the shapeOptions can beoverwritten by config for a specific shape.
		/// </summary>
		public AnnotationsshapeOptions ShapeOptions { get; set; }
		private AnnotationsshapeOptions ShapeOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index of the annotation.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of labels for the annotation. For options that apply to multiplelabels, they can be added to the [labelOptions](annotations.labelOptions.html).
		/// </summary>
		public List<object> Labels { get; set; }
		private List<object> Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of shapes for the annotation. For options that apply to multipleshapes, then can be added to the [shapeOptions](annotations.shapeOptions.html).
		/// </summary>
		public List<object> Shapes { get; set; }
		private List<object> Shapes_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (LabelOptions.IsDirty()) h.Add("labelOptions",LabelOptions.ToHashtable());
			if (ShapeOptions.IsDirty()) h.Add("shapeOptions",ShapeOptions.ToHashtable());
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (Shapes.IsDirty()) h.Add("shapes",Shapes.ToHashtable());
			

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