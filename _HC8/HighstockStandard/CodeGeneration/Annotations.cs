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
	public partial class Annotations  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Annotations()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			AnimationBool = AnimationBool_DefaultValue = null;
			ControlPointOptions = ControlPointOptions_DefaultValue = new AnnotationsControlPointOptions();
			CrookedLine = CrookedLine_DefaultValue = new AnnotationsCrookedLine();
			Crop = Crop_DefaultValue = true;
			Draggable = Draggable_DefaultValue = "xy";
			ElliottWave = ElliottWave_DefaultValue = new AnnotationsElliottWave();
			Events = Events_DefaultValue = new AnnotationsEvents();
			Fibonacci = Fibonacci_DefaultValue = new AnnotationsFibonacci();
			FibonacciTimeZones = FibonacciTimeZones_DefaultValue = new AnnotationsFibonacciTimeZones();
			Id = Id_DefaultValue = "";
			IdNumber = IdNumber_DefaultValue = null;
			InfinityLine = InfinityLine_DefaultValue = new AnnotationsInfinityLine();
			LabelOptions = LabelOptions_DefaultValue = new AnnotationsLabelOptions();
			Labels = Labels_DefaultValue = new List<AnnotationsLabels>();
			Measure = Measure_DefaultValue = new AnnotationsMeasure();
			Pitchfork = Pitchfork_DefaultValue = new AnnotationsPitchfork();
			ShapeOptions = ShapeOptions_DefaultValue = new AnnotationsShapeOptions();
			Shapes = Shapes_DefaultValue = new List<AnnotationsShapes>();
			TimeCycles = TimeCycles_DefaultValue = new AnnotationsTimeCycles();
			Tunnel = Tunnel_DefaultValue = new AnnotationsTunnel();
			VerticalLine = VerticalLine_DefaultValue = new AnnotationsVerticalLine();
			Visible = Visible_DefaultValue = true;
			ZIndex = ZIndex_DefaultValue = 6;
			
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
		public AnnotationsControlPointOptions ControlPointOptions { get; set; }
		private AnnotationsControlPointOptions ControlPointOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// A crooked line annotation.
		/// </summary>
		public AnnotationsCrookedLine CrookedLine { get; set; }
		private AnnotationsCrookedLine CrookedLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to hide the part of the annotationthat is outside the plot area.
		/// </summary>
		public bool? Crop { get; set; }
		private bool? Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow an annotation to be draggable by a user. Possiblevalues are `'x'`, `'xy'`, `'y'` and `''` (disabled).
		/// </summary>
		public string Draggable { get; set; }
		private string Draggable_DefaultValue { get; set; }
		 

		/// <summary>
		/// An elliott wave annotation.
		/// </summary>
		public AnnotationsElliottWave ElliottWave { get; set; }
		private AnnotationsElliottWave ElliottWave_DefaultValue { get; set; }
		 

		/// <summary>
		/// Events available in annotations.
		/// </summary>
		public AnnotationsEvents Events { get; set; }
		private AnnotationsEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// A fibonacci annotation.
		/// </summary>
		public AnnotationsFibonacci Fibonacci { get; set; }
		private AnnotationsFibonacci Fibonacci_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Fibonacci Time Zones annotation.
		/// </summary>
		public AnnotationsFibonacciTimeZones FibonacciTimeZones { get; set; }
		private AnnotationsFibonacciTimeZones FibonacciTimeZones_DefaultValue { get; set; }
		 

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
		/// An infinity line annotation.
		/// </summary>
		public AnnotationsInfinityLine InfinityLine { get; set; }
		private AnnotationsInfinityLine InfinityLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for annotation's labels. Each label inherits optionsfrom the labelOptions object. An option from the labelOptionscan be overwritten by config for a specific label.
		/// </summary>
		public AnnotationsLabelOptions LabelOptions { get; set; }
		private AnnotationsLabelOptions LabelOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of labels for the annotation. For options that applyto multiple labels, they can be added to the[labelOptions](annotations.labelOptions.html).
		/// </summary>
		public List<AnnotationsLabels> Labels { get; set; }
		private List<AnnotationsLabels> Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// A measure annotation.
		/// </summary>
		public AnnotationsMeasure Measure { get; set; }
		private AnnotationsMeasure Measure_DefaultValue { get; set; }
		 

		/// <summary>
		/// A pitchfork annotation.
		/// </summary>
		public AnnotationsPitchfork Pitchfork { get; set; }
		private AnnotationsPitchfork Pitchfork_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for annotation's shapes. Each shape inherits optionsfrom the shapeOptions object. An option from the shapeOptionscan be overwritten by config for a specific shape.
		/// </summary>
		public AnnotationsShapeOptions ShapeOptions { get; set; }
		private AnnotationsShapeOptions ShapeOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of shapes for the annotation. For options that applyto multiple shapes, then can be added to the[shapeOptions](annotations.shapeOptions.html).
		/// </summary>
		public List<AnnotationsShapes> Shapes { get; set; }
		private List<AnnotationsShapes> Shapes_DefaultValue { get; set; }
		 

		/// <summary>
		/// The TimeCycles Annotation
		/// </summary>
		public AnnotationsTimeCycles TimeCycles { get; set; }
		private AnnotationsTimeCycles TimeCycles_DefaultValue { get; set; }
		 

		/// <summary>
		/// A tunnel annotation.
		/// </summary>
		public AnnotationsTunnel Tunnel { get; set; }
		private AnnotationsTunnel Tunnel_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vertical line annotation.
		/// </summary>
		public AnnotationsVerticalLine VerticalLine { get; set; }
		private AnnotationsVerticalLine VerticalLine_DefaultValue { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Animation.IsDirty(ref highstock)) h.Add("animation",Animation.ToJSON(ref highstock));
			if (AnimationBool != AnimationBool_DefaultValue) h.Add("animation",AnimationBool);
			if (ControlPointOptions.IsDirty(ref highstock)) h.Add("controlPointOptions",ControlPointOptions.ToHashtable(ref highstock));
			if (CrookedLine.IsDirty(ref highstock)) h.Add("crookedLine",CrookedLine.ToHashtable(ref highstock));
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Draggable != Draggable_DefaultValue) h.Add("draggable",Draggable);
			if (ElliottWave.IsDirty(ref highstock)) h.Add("elliottWave",ElliottWave.ToHashtable(ref highstock));
			if (Events.IsDirty(ref highstock)) h.Add("events",Events.ToHashtable(ref highstock));
			if (Fibonacci.IsDirty(ref highstock)) h.Add("fibonacci",Fibonacci.ToHashtable(ref highstock));
			if (FibonacciTimeZones.IsDirty(ref highstock)) h.Add("fibonacciTimeZones",FibonacciTimeZones.ToHashtable(ref highstock));
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (IdNumber != IdNumber_DefaultValue) h.Add("id",IdNumber);
			if (InfinityLine.IsDirty(ref highstock)) h.Add("infinityLine",InfinityLine.ToHashtable(ref highstock));
			if (LabelOptions.IsDirty(ref highstock)) h.Add("labelOptions",LabelOptions.ToHashtable(ref highstock));
			if (Labels != Labels_DefaultValue) h.Add("labels", HashifyList(ref highstock,Labels));
			if (Measure.IsDirty(ref highstock)) h.Add("measure",Measure.ToHashtable(ref highstock));
			if (Pitchfork.IsDirty(ref highstock)) h.Add("pitchfork",Pitchfork.ToHashtable(ref highstock));
			if (ShapeOptions.IsDirty(ref highstock)) h.Add("shapeOptions",ShapeOptions.ToHashtable(ref highstock));
			if (Shapes != Shapes_DefaultValue) h.Add("shapes", HashifyList(ref highstock,Shapes));
			if (TimeCycles.IsDirty(ref highstock)) h.Add("timeCycles",TimeCycles.ToHashtable(ref highstock));
			if (Tunnel.IsDirty(ref highstock)) h.Add("tunnel",Tunnel.ToHashtable(ref highstock));
			if (VerticalLine.IsDirty(ref highstock)) h.Add("verticalLine",VerticalLine.ToHashtable(ref highstock));
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			

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