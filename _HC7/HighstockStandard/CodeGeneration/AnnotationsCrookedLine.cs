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
		public AnnotationsCrookedLine()
		{
			ControlPointOptions = ControlPointOptions_DefaultValue = new AnnotationsCrookedLineControlPointOptions();
			Draggable = Draggable_DefaultValue = AnnotationsCrookedLineDraggable.Xy;
			Events = Events_DefaultValue = new AnnotationsCrookedLineEvents();
			LabelOptions = LabelOptions_DefaultValue = new AnnotationsCrookedLineLabelOptions();
			Labels = Labels_DefaultValue = new List<AnnotationsCrookedLineLabels>();
			ShapeOptions = ShapeOptions_DefaultValue = new AnnotationsCrookedLineShapeOptions();
			Shapes = Shapes_DefaultValue = new List<AnnotationsCrookedLineShapes>();
			TypeOptions = TypeOptions_DefaultValue = new AnnotationsCrookedLineTypeOptions();
			Visible = Visible_DefaultValue = true;
			ZIndex = ZIndex_DefaultValue = 6;
			
		}	
		

		/// <summary>
		/// Options for annotation's control points. Each control pointinherits options from controlPointOptions object.Options from the controlPointOptions can be overwrittenby options in a specific control point.
		/// </summary>
		public AnnotationsCrookedLineControlPointOptions ControlPointOptions { get; set; }
		private AnnotationsCrookedLineControlPointOptions ControlPointOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow an annotation to be draggable by a user. Possiblevalues are `"x"`, `"xy"`, `"y"` and `""` (disabled).
		/// </summary>
		public AnnotationsCrookedLineDraggable Draggable { get; set; }
		private AnnotationsCrookedLineDraggable Draggable_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsCrookedLineEvents Events { get; set; }
		private AnnotationsCrookedLineEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for annotation's labels. Each label inherits optionsfrom the labelOptions object. An option from the labelOptionscan be overwritten by config for a specific label.
		/// </summary>
		public AnnotationsCrookedLineLabelOptions LabelOptions { get; set; }
		private AnnotationsCrookedLineLabelOptions LabelOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of labels for the annotation. For options that apply tomultiple labels, they can be added to the[labelOptions](annotations.labelOptions.html).
		/// </summary>
		public List<AnnotationsCrookedLineLabels> Labels { get; set; }
		private List<AnnotationsCrookedLineLabels> Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for annotation's shapes. Each shape inherits optionsfrom the shapeOptions object. An option from the shapeOptionscan be overwritten by config for a specific shape.
		/// </summary>
		public AnnotationsCrookedLineShapeOptions ShapeOptions { get; set; }
		private AnnotationsCrookedLineShapeOptions ShapeOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of shapes for the annotation. For options that apply tomultiple shapes, then can be added to the[shapeOptions](annotations.shapeOptions.html).
		/// </summary>
		public List<AnnotationsCrookedLineShapes> Shapes { get; set; }
		private List<AnnotationsCrookedLineShapes> Shapes_DefaultValue { get; set; }
		 

		/// <summary>
		/// Additional options for an annotation with the type.
		/// </summary>
		public AnnotationsCrookedLineTypeOptions TypeOptions { get; set; }
		private AnnotationsCrookedLineTypeOptions TypeOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the annotation is visible.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index of the annotation.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ControlPointOptions.IsDirty()) h.Add("controlPointOptions",ControlPointOptions.ToHashtable());
			if (Draggable != Draggable_DefaultValue) h.Add("draggable", Highstock.FirstCharacterToLower(Draggable.ToString()));
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (LabelOptions.IsDirty()) h.Add("labelOptions",LabelOptions.ToHashtable());
			if (Labels.Any()) h.Add("labels",HashifyList(Labels));
			if (ShapeOptions.IsDirty()) h.Add("shapeOptions",ShapeOptions.ToHashtable());
			if (Shapes.Any()) h.Add("shapes",HashifyList(Shapes));
			if (TypeOptions.IsDirty()) h.Add("typeOptions",TypeOptions.ToHashtable());
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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