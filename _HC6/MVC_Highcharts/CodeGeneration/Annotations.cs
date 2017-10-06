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
			Visible = Visible_DefaultValue = null;
			LabelOptions = LabelOptions_DefaultValue = new AnnotationsLabelOptions();
			ShapeOptions = ShapeOptions_DefaultValue = new AnnotationsShapeOptions();
			ZIndex = ZIndex_DefaultValue = 6;
			Labels = Labels_DefaultValue = new AnnotationsLabels();
			Shapes = Shapes_DefaultValue = new AnnotationsShapes();
			
		}	
		

		/// <summary>
		/// <p>Whether the annotation is visible.</p>
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for annotation&#39;s labels. Each label inherits optionsfrom the labelOptions object. An option from the labelOptions can beoverwritten by config for a specific label.</p>
		/// </summary>
		public AnnotationsLabelOptions LabelOptions { get; set; }
		private AnnotationsLabelOptions LabelOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for annotation&#39;s shapes. Each shape inherits optionsfrom the shapeOptions object. An option from the shapeOptions can beoverwritten by config for a specific shape.</p>
		/// </summary>
		public AnnotationsShapeOptions ShapeOptions { get; set; }
		private AnnotationsShapeOptions ShapeOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The Z index of the annotation.</p>
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array of labels for the annotation. For options that apply to multiplelabels, they can be added to the <a href="annotations.labelOptions.html">labelOptions</a>.</p>
		/// </summary>
		public AnnotationsLabels Labels { get; set; }
		private AnnotationsLabels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array of shapes for the annotation. For options that apply to multipleshapes, then can be added to the <a href="annotations.shapeOptions.html">shapeOptions</a>.</p>
		/// </summary>
		public AnnotationsShapes Shapes { get; set; }
		private AnnotationsShapes Shapes_DefaultValue { get; set; }
		  

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