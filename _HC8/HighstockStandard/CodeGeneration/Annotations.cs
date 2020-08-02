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
			ControlPointOptions = ControlPointOptions_DefaultValue = new AnnotationsControlPointOptions();
			CrookedLine = CrookedLine_DefaultValue = new AnnotationsCrookedLine();
			Draggable = Draggable_DefaultValue = "xy";
			ElliottWave = ElliottWave_DefaultValue = new AnnotationsElliottWave();
			Events = Events_DefaultValue = new AnnotationsEvents();
			Fibonacci = Fibonacci_DefaultValue = new AnnotationsFibonacci();
			Id = Id_DefaultValue = "";
			IdNumber = IdNumber_DefaultValue = null;
			InfinityLine = InfinityLine_DefaultValue = new AnnotationsInfinityLine();
			LabelOptions = LabelOptions_DefaultValue = new AnnotationsLabelOptions();
			Labels = Labels_DefaultValue = new List<AnnotationsLabels>();
			Measure = Measure_DefaultValue = new AnnotationsMeasure();
			Pitchfork = Pitchfork_DefaultValue = new AnnotationsPitchfork();
			ShapeOptions = ShapeOptions_DefaultValue = new AnnotationsShapeOptions();
			Shapes = Shapes_DefaultValue = new List<AnnotationsShapes>();
			Tunnel = Tunnel_DefaultValue = new AnnotationsTunnel();
			VerticalLine = VerticalLine_DefaultValue = new AnnotationsVerticalLine();
			Visible = Visible_DefaultValue = true;
			ZIndex = ZIndex_DefaultValue = 6;
			
		}	
		

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
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (ControlPointOptions.IsDirty()) h.Add("controlPointOptions",ControlPointOptions.ToHashtable());
			if (CrookedLine.IsDirty()) h.Add("crookedLine",CrookedLine.ToHashtable());
			if (Draggable != Draggable_DefaultValue) h.Add("draggable",Draggable);
			if (ElliottWave.IsDirty()) h.Add("elliottWave",ElliottWave.ToHashtable());
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Fibonacci.IsDirty()) h.Add("fibonacci",Fibonacci.ToHashtable());
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (IdNumber != IdNumber_DefaultValue) h.Add("id",IdNumber);
			if (InfinityLine.IsDirty()) h.Add("infinityLine",InfinityLine.ToHashtable());
			if (LabelOptions.IsDirty()) h.Add("labelOptions",LabelOptions.ToHashtable());
			if (Labels != Labels_DefaultValue) h.Add("labels", HashifyList(Labels));
			if (Measure.IsDirty()) h.Add("measure",Measure.ToHashtable());
			if (Pitchfork.IsDirty()) h.Add("pitchfork",Pitchfork.ToHashtable());
			if (ShapeOptions.IsDirty()) h.Add("shapeOptions",ShapeOptions.ToHashtable());
			if (Shapes != Shapes_DefaultValue) h.Add("shapes", HashifyList(Shapes));
			if (Tunnel.IsDirty()) h.Add("tunnel",Tunnel.ToHashtable());
			if (VerticalLine.IsDirty()) h.Add("verticalLine",VerticalLine.ToHashtable());
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			

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