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
	public partial class AnnotationsVerticalLine  : BaseObject
	{
		public AnnotationsVerticalLine()
		{
			Draggable = Draggable_DefaultValue = AnnotationsVerticalLineDraggable.Xy;
			Events = Events_DefaultValue = new AnnotationsVerticalLineEvents();
			LabelOptions = LabelOptions_DefaultValue = new AnnotationsVerticalLineLabelOptions();
			ShapeOptions = ShapeOptions_DefaultValue = new AnnotationsVerticalLineShapeOptions();
			TypeOptions = TypeOptions_DefaultValue = new AnnotationsVerticalLineTypeOptions();
			Visible = Visible_DefaultValue = true;
			ZIndex = ZIndex_DefaultValue = 6;
			
		}	
		

		/// <summary>
		/// Allow an annotation to be draggable by a user. Possiblevalues are `"x"`, `"xy"`, `"y"` and `""` (disabled).
		/// </summary>
		public AnnotationsVerticalLineDraggable Draggable { get; set; }
		private AnnotationsVerticalLineDraggable Draggable_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsVerticalLineEvents Events { get; set; }
		private AnnotationsVerticalLineEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for annotation's labels. Each label inherits optionsfrom the labelOptions object. An option from the labelOptionscan be overwritten by config for a specific label.
		/// </summary>
		public AnnotationsVerticalLineLabelOptions LabelOptions { get; set; }
		private AnnotationsVerticalLineLabelOptions LabelOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for annotation's shapes. Each shape inherits optionsfrom the shapeOptions object. An option from the shapeOptionscan be overwritten by config for a specific shape.
		/// </summary>
		public AnnotationsVerticalLineShapeOptions ShapeOptions { get; set; }
		private AnnotationsVerticalLineShapeOptions ShapeOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsVerticalLineTypeOptions TypeOptions { get; set; }
		private AnnotationsVerticalLineTypeOptions TypeOptions_DefaultValue { get; set; }
		 

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