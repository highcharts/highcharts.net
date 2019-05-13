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
	public partial class AnnotationsInfinityLine  : BaseObject
	{
		public AnnotationsInfinityLine()
		{
			ControlPointOptions = ControlPointOptions_DefaultValue = new AnnotationsInfinityLineControlPointOptions();
			Draggable = Draggable_DefaultValue = AnnotationsInfinityLineDraggable.Xy;
			Events = Events_DefaultValue = new AnnotationsInfinityLineEvents();
			LabelOptions = LabelOptions_DefaultValue = new AnnotationsInfinityLineLabelOptions();
			ShapeOptions = ShapeOptions_DefaultValue = new AnnotationsInfinityLineShapeOptions();
			TypeOptions = TypeOptions_DefaultValue = new AnnotationsInfinityLineTypeOptions();
			Visible = Visible_DefaultValue = true;
			ZIndex = ZIndex_DefaultValue = 6;
			
		}	
		

		/// <summary>
		/// Options for annotation's control points. Each control pointinherits options from controlPointOptions object.Options from the controlPointOptions can be overwrittenby options in a specific control point.
		/// </summary>
		public AnnotationsInfinityLineControlPointOptions ControlPointOptions { get; set; }
		private AnnotationsInfinityLineControlPointOptions ControlPointOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow an annotation to be draggable by a user. Possiblevalues are `"x"`, `"xy"`, `"y"` and `""` (disabled).
		/// </summary>
		public AnnotationsInfinityLineDraggable Draggable { get; set; }
		private AnnotationsInfinityLineDraggable Draggable_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsInfinityLineEvents Events { get; set; }
		private AnnotationsInfinityLineEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for annotation's labels. Each label inherits optionsfrom the labelOptions object. An option from the labelOptionscan be overwritten by config for a specific label.
		/// </summary>
		public AnnotationsInfinityLineLabelOptions LabelOptions { get; set; }
		private AnnotationsInfinityLineLabelOptions LabelOptions_DefaultValue { get; set; }

		/// <summary>
		/// Options for annotation's shapes. Each shape inherits optionsfrom the shapeOptions object. An option from the shapeOptionscan be overwritten by config for a specific shape.
		/// </summary>
		public AnnotationsInfinityLineShapeOptions ShapeOptions { get; set; }
		private AnnotationsInfinityLineShapeOptions ShapeOptions_DefaultValue { get; set; }
		 
		/// <summary>
		/// Additional options for an annotation with the type.
		/// </summary>
		public AnnotationsInfinityLineTypeOptions TypeOptions { get; set; }
		private AnnotationsInfinityLineTypeOptions TypeOptions_DefaultValue { get; set; }
		 

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
			if (ShapeOptions.IsDirty()) h.Add("shapeOptions",ShapeOptions.ToHashtable());
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