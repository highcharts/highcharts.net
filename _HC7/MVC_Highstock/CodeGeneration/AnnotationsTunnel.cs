using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class AnnotationsTunnel  : BaseObject
	{
		public AnnotationsTunnel()
		{
			ControlPointOptions = ControlPointOptions_DefaultValue = new AnnotationsTunnelControlPointOptions();
			Draggable = Draggable_DefaultValue = AnnotationsTunnelDraggable.Xy;
			Events = Events_DefaultValue = null;
			LabelOptions = LabelOptions_DefaultValue = new AnnotationsTunnelLabelOptions();
			Labels = Labels_DefaultValue = new List<AnnotationsTunnelLabels>();
			ShapeOptions = ShapeOptions_DefaultValue = new AnnotationsTunnelShapeOptions();
			Shapes = Shapes_DefaultValue = new List<AnnotationsTunnelShapes>();
			TypeOptions = TypeOptions_DefaultValue = new AnnotationsTunnelTypeOptions();
			Visible = Visible_DefaultValue = true;
			ZIndex = ZIndex_DefaultValue = 6;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsTunnelControlPointOptions ControlPointOptions { get; set; }
		private AnnotationsTunnelControlPointOptions ControlPointOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow an annotation to be draggable by a user. Possiblevalues are `"x"`, `"xy"`, `"y"` and `""` (disabled).
		/// </summary>
		public AnnotationsTunnelDraggable Draggable { get; set; }
		private AnnotationsTunnelDraggable Draggable_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Object Events { get; set; }
		private Object Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for annotation's labels. Each label inherits optionsfrom the labelOptions object. An option from the labelOptionscan be overwritten by config for a specific label.
		/// </summary>
		public AnnotationsTunnelLabelOptions LabelOptions { get; set; }
		private AnnotationsTunnelLabelOptions LabelOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of labels for the annotation. For options that apply tomultiple labels, they can be added to the[labelOptions](annotations.labelOptions.html).
		/// </summary>
		public List<AnnotationsTunnelLabels> Labels { get; set; }
		private List<AnnotationsTunnelLabels> Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for annotation's shapes. Each shape inherits optionsfrom the shapeOptions object. An option from the shapeOptionscan be overwritten by config for a specific shape.
		/// </summary>
		public AnnotationsTunnelShapeOptions ShapeOptions { get; set; }
		private AnnotationsTunnelShapeOptions ShapeOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of shapes for the annotation. For options that apply tomultiple shapes, then can be added to the[shapeOptions](annotations.shapeOptions.html).
		/// </summary>
		public List<AnnotationsTunnelShapes> Shapes { get; set; }
		private List<AnnotationsTunnelShapes> Shapes_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsTunnelTypeOptions TypeOptions { get; set; }
		private AnnotationsTunnelTypeOptions TypeOptions_DefaultValue { get; set; }
		 

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
			if (Events != Events_DefaultValue) h.Add("events",Events);
			if (LabelOptions.IsDirty()) h.Add("labelOptions",LabelOptions.ToHashtable());
			if (Labels != Labels_DefaultValue) h.Add("labels",HashifyList(Labels));
			if (ShapeOptions.IsDirty()) h.Add("shapeOptions",ShapeOptions.ToHashtable());
			if (Shapes != Shapes_DefaultValue) h.Add("shapes",HashifyList(Shapes));
			if (TypeOptions.IsDirty()) h.Add("typeOptions",TypeOptions.ToHashtable());
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			

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