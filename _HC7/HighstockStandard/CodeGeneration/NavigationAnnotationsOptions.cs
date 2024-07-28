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
	public partial class NavigationAnnotationsOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationAnnotationsOptions()
		{
		}	
		

		/// <summary>
		/// Enable or disable the initial animation when a series isdisplayed for the `annotation`. The animation can also be setas a configuration object. Please note that this option onlyapplies to the initial animation.For other animations, see [chart.animation](#chart.animation)and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series isdisplayed for the `annotation`. The animation can also be setas a configuration object. Please note that this option onlyapplies to the initial animation.For other animations, see [chart.animation](#chart.animation)and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.
		/// </summary>
		public bool? AnimationBool { get; set; }
		 

		/// <summary>
		/// Options for annotation's control points. Each control pointinherits options from controlPointOptions object.Options from the controlPointOptions can be overwrittenby options in a specific control point.
		/// </summary>
		public NavigationAnnotationsOptionsControlPointOptions ControlPointOptions { get; set; }
		 

		/// <summary>
		/// Whether to hide the part of the annotationthat is outside the plot area.
		/// </summary>
		public bool? Crop { get; set; }
		 

		/// <summary>
		/// Allow an annotation to be draggable by a user. Possiblevalues are `'x'`, `'xy'`, `'y'` and `''` (disabled).
		/// </summary>
		public string Draggable { get; set; }
		 

		/// <summary>
		/// Events available in annotations.
		/// </summary>
		public NavigationAnnotationsOptionsEvents Events { get; set; }
		 

		/// <summary>
		/// The Fibonacci Time Zones annotation.
		/// </summary>
		public NavigationAnnotationsOptionsFibonacciTimeZones FibonacciTimeZones { get; set; }
		 

		/// <summary>
		/// Sets an ID for an annotation. Can be user later whenremoving an annotation in [Chart#removeAnnotation(id)](/class-reference/Highcharts.Chart#removeAnnotation) method.
		/// </summary>
		public string Id { get; set; }
		 

		/// <summary>
		/// Sets an ID for an annotation. Can be user later whenremoving an annotation in [Chart#removeAnnotation(id)](/class-reference/Highcharts.Chart#removeAnnotation) method.
		/// </summary>
		public double? IdNumber { get; set; }
		 

		/// <summary>
		/// Options for annotation's labels. Each label inherits optionsfrom the labelOptions object. An option from the labelOptionscan be overwritten by config for a specific label.
		/// </summary>
		public NavigationAnnotationsOptionsLabelOptions LabelOptions { get; set; }
		 

		/// <summary>
		/// An array of labels for the annotation. For options that applyto multiple labels, they can be added to the[labelOptions](annotations.labelOptions.html).
		/// </summary>
		public NavigationAnnotationsOptionsLabels Labels { get; set; }
		 

		/// <summary>
		/// Options for annotation's shapes. Each shape inherits optionsfrom the shapeOptions object. An option from the shapeOptionscan be overwritten by config for a specific shape.
		/// </summary>
		public NavigationAnnotationsOptionsShapeOptions ShapeOptions { get; set; }
		 

		/// <summary>
		/// An array of shapes for the annotation. For options that applyto multiple shapes, then can be added to the[shapeOptions](annotations.shapeOptions.html).
		/// </summary>
		public NavigationAnnotationsOptionsShapes Shapes { get; set; }
		 

		/// <summary>
		/// The TimeCycles Annotation
		/// </summary>
		public NavigationAnnotationsOptionsTimeCycles TimeCycles { get; set; }
		 

		/// <summary>
		/// Whether the annotation is visible.
		/// </summary>
		public bool? Visible { get; set; }
		 

		/// <summary>
		/// The Z index of the annotation.
		/// </summary>
		public double? ZIndex { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Animation != null) h.Add("animation",Animation);
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (ControlPointOptions != null) h.Add("controlPointOptions",ControlPointOptions.ToHashtable(highstock));
			if (Crop != null) h.Add("crop",Crop);
			if (Draggable != null) h.Add("draggable",Draggable);
			if (Events != null) h.Add("events",Events.ToHashtable(highstock));
			if (FibonacciTimeZones != null) h.Add("fibonacciTimeZones",FibonacciTimeZones.ToHashtable(highstock));
			if (Id != null) h.Add("id",Id);
			if (IdNumber != null) h.Add("id",IdNumber);
			if (LabelOptions != null) h.Add("labelOptions",LabelOptions.ToHashtable(highstock));
			if (Labels != null) h.Add("labels",Labels.ToHashtable(highstock));
			if (ShapeOptions != null) h.Add("shapeOptions",ShapeOptions.ToHashtable(highstock));
			if (Shapes != null) h.Add("shapes",Shapes.ToHashtable(highstock));
			if (TimeCycles != null) h.Add("timeCycles",TimeCycles.ToHashtable(highstock));
			if (Visible != null) h.Add("visible",Visible);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}