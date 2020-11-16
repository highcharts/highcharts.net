using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class NavigationAnnotationsOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationAnnotationsOptions()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			AnimationBool = AnimationBool_DefaultValue = null;
			ControlPointOptions = ControlPointOptions_DefaultValue = new NavigationAnnotationsOptionsControlPointOptions();
			Draggable = Draggable_DefaultValue = "xy";
			Events = Events_DefaultValue = new NavigationAnnotationsOptionsEvents();
			Id = Id_DefaultValue = "";
			IdNumber = IdNumber_DefaultValue = null;
			LabelOptions = LabelOptions_DefaultValue = new NavigationAnnotationsOptionsLabelOptions();
			Labels = Labels_DefaultValue = new NavigationAnnotationsOptionsLabels();
			ShapeOptions = ShapeOptions_DefaultValue = new NavigationAnnotationsOptionsShapeOptions();
			Shapes = Shapes_DefaultValue = new NavigationAnnotationsOptionsShapes();
			Visible = Visible_DefaultValue = true;
			ZIndex = ZIndex_DefaultValue = 6;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Enable or disable the initial animation when a series isdisplayed for the `annotation`. The animation can also be setas a configuration object. Please note that this option onlyapplies to the initial animation.For other animations, see [chart.animation](#chart.animation)and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series isdisplayed for the `annotation`. The animation can also be setas a configuration object. Please note that this option onlyapplies to the initial animation.For other animations, see [chart.animation](#chart.animation)and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.
		/// </summary>
		public bool? AnimationBool { get; set; }
		private bool? AnimationBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for annotation's control points. Each control pointinherits options from controlPointOptions object.Options from the controlPointOptions can be overwrittenby options in a specific control point.
		/// </summary>
		public NavigationAnnotationsOptionsControlPointOptions ControlPointOptions { get; set; }
		private NavigationAnnotationsOptionsControlPointOptions ControlPointOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow an annotation to be draggable by a user. Possiblevalues are `'x'`, `'xy'`, `'y'` and `''` (disabled).
		/// </summary>
		public string Draggable { get; set; }
		private string Draggable_DefaultValue { get; set; }
		 

		/// <summary>
		/// Events available in annotations.
		/// </summary>
		public NavigationAnnotationsOptionsEvents Events { get; set; }
		private NavigationAnnotationsOptionsEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sets an ID for an annotation. Can be user later whenremoving an annotation in [Chart#removeAnnotation(id)](/class-reference/Highcharts.Chart#removeAnnotation) method.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sets an ID for an annotation. Can be user later whenremoving an annotation in [Chart#removeAnnotation(id)](/class-reference/Highcharts.Chart#removeAnnotation) method.
		/// </summary>
		public double? IdNumber { get; set; }
		private double? IdNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for annotation's labels. Each label inherits optionsfrom the labelOptions object. An option from the labelOptionscan be overwritten by config for a specific label.
		/// </summary>
		public NavigationAnnotationsOptionsLabelOptions LabelOptions { get; set; }
		private NavigationAnnotationsOptionsLabelOptions LabelOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of labels for the annotation. For options that applyto multiple labels, they can be added to the[labelOptions](annotations.labelOptions.html).
		/// </summary>
		public NavigationAnnotationsOptionsLabels Labels { get; set; }
		private NavigationAnnotationsOptionsLabels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for annotation's shapes. Each shape inherits optionsfrom the shapeOptions object. An option from the shapeOptionscan be overwritten by config for a specific shape.
		/// </summary>
		public NavigationAnnotationsOptionsShapeOptions ShapeOptions { get; set; }
		private NavigationAnnotationsOptionsShapeOptions ShapeOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of shapes for the annotation. For options that applyto multiple shapes, then can be added to the[shapeOptions](annotations.shapeOptions.html).
		/// </summary>
		public NavigationAnnotationsOptionsShapes Shapes { get; set; }
		private NavigationAnnotationsOptionsShapes Shapes_DefaultValue { get; set; }
		 

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
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (AnimationBool != AnimationBool_DefaultValue) h.Add("animation",AnimationBool);
			if (ControlPointOptions.IsDirty()) h.Add("controlPointOptions",ControlPointOptions.ToHashtable());
			if (Draggable != Draggable_DefaultValue) h.Add("draggable",Draggable);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (IdNumber != IdNumber_DefaultValue) h.Add("id",IdNumber);
			if (LabelOptions.IsDirty()) h.Add("labelOptions",LabelOptions.ToHashtable());
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (ShapeOptions.IsDirty()) h.Add("shapeOptions",ShapeOptions.ToHashtable());
			if (Shapes.IsDirty()) h.Add("shapes",Shapes.ToHashtable());
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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