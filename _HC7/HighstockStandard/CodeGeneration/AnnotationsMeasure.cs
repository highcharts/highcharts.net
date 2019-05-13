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
	public partial class AnnotationsMeasure  : BaseObject
	{
		public AnnotationsMeasure()
		{
			ControlPointOptions = ControlPointOptions_DefaultValue = new AnnotationsMeasureControlPointOptions();
			Draggable = Draggable_DefaultValue = AnnotationsMeasureDraggable.Xy;
			Events = Events_DefaultValue = new AnnotationsMeasureEvents();
			TypeOptions = TypeOptions_DefaultValue = new AnnotationsMeasureTypeOptions();
			Visible = Visible_DefaultValue = true;
			ZIndex = ZIndex_DefaultValue = 6;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsMeasureControlPointOptions ControlPointOptions { get; set; }
		private AnnotationsMeasureControlPointOptions ControlPointOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow an annotation to be draggable by a user. Possiblevalues are `"x"`, `"xy"`, `"y"` and `""` (disabled).
		/// </summary>
		public AnnotationsMeasureDraggable Draggable { get; set; }
		private AnnotationsMeasureDraggable Draggable_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsMeasureEvents Events { get; set; }
		private AnnotationsMeasureEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsMeasureTypeOptions TypeOptions { get; set; }
		private AnnotationsMeasureTypeOptions TypeOptions_DefaultValue { get; set; }
		 

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