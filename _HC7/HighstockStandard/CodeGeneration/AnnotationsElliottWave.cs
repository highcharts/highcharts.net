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
	public partial class AnnotationsElliottWave  : BaseObject
	{
		public AnnotationsElliottWave()
		{
			ControlPointOptions = ControlPointOptions_DefaultValue = new AnnotationsElliottWaveControlPointOptions();
			Draggable = Draggable_DefaultValue = AnnotationsElliottWaveDraggable.Xy;
			Events = Events_DefaultValue = new AnnotationsElliottWaveEvents();
			LabelOptions = LabelOptions_DefaultValue = new AnnotationsElliottWaveLabelOptions();
			ShapeOptions = ShapeOptions_DefaultValue = new AnnotationsElliottWaveShapeOptions();
			TypeOptions = TypeOptions_DefaultValue = new AnnotationsElliottWaveTypeOptions();
			Visible = Visible_DefaultValue = true;
			ZIndex = ZIndex_DefaultValue = 6;
			
		}	
		

		/// <summary>
		/// Options for annotation's control points. Each control pointinherits options from controlPointOptions object.Options from the controlPointOptions can be overwrittenby options in a specific control point.
		/// </summary>
		public AnnotationsElliottWaveControlPointOptions ControlPointOptions { get; set; }
		private AnnotationsElliottWaveControlPointOptions ControlPointOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow an annotation to be draggable by a user. Possiblevalues are `"x"`, `"xy"`, `"y"` and `""` (disabled).
		/// </summary>
		public AnnotationsElliottWaveDraggable Draggable { get; set; }
		private AnnotationsElliottWaveDraggable Draggable_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsElliottWaveEvents Events { get; set; }
		private AnnotationsElliottWaveEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsElliottWaveLabelOptions LabelOptions { get; set; }
		private AnnotationsElliottWaveLabelOptions LabelOptions_DefaultValue { get; set; }
		 
		/// <summary>
		/// Options for annotation's shapes. Each shape inherits optionsfrom the shapeOptions object. An option from the shapeOptionscan be overwritten by config for a specific shape.
		/// </summary>
		public AnnotationsElliottWaveShapeOptions ShapeOptions { get; set; }
		private AnnotationsElliottWaveShapeOptions ShapeOptions_DefaultValue { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsElliottWaveTypeOptions TypeOptions { get; set; }
		private AnnotationsElliottWaveTypeOptions TypeOptions_DefaultValue { get; set; }
		 

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