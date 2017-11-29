using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class ChartparallelAxeslabels  : BaseObject
	{
		public ChartparallelAxeslabels()
		{
			Enabled = Enabled_DefaultValue = True;
			Style = Style_DefaultValue = "";
			X = X_DefaultValue = 0;
			Position3d = Position3d_DefaultValue = offset;
			Skew3d = Skew3d_DefaultValue = False;
			Align = Align_DefaultValue = "";
			AutoRotation = AutoRotation_DefaultValue = new List<double> {-45};
			AutoRotationLimit = AutoRotationLimit_DefaultValue = 80;
			Distance = Distance_DefaultValue = 15;
			Format = Format_DefaultValue = "{value}";
			Formatter = Formatter_DefaultValue = "";
			Overflow = Overflow_DefaultValue = "";
			Padding = Padding_DefaultValue = 5;
			ReserveSpace = ReserveSpace_DefaultValue = true;
			Rotation = Rotation_DefaultValue = 0;
			StaggerLines = StaggerLines_DefaultValue = null;
			Step = Step_DefaultValue = null;
			UseHTML = UseHTML_DefaultValue = false;
			Y = Y_DefaultValue = null;
			ZIndex = ZIndex_DefaultValue = 7;
			
		}	
		

		/// <summary>
		/// Enable or disable the axis labels.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the label. Use `whiteSpace: 'nowrap'` to preventwrapping of category labels. Use `textOverflow: 'none'` toprevent ellipsis (dots).In styled mode, the labels are styled with the`.highcharts-axis-labels` class.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to the tick positionon the axis.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines how the labels are be repositioned according to the 3D chartorientation.- `'offset'`: Maintain a fixed horizontal/vertical distance from the tick marks, despite the chart orientation. This is the backwards compatible behavior, and causes skewing of X and Z axes.- `'chart'`: Preserve 3D position relative to the chart.  This looks nice, but hard to read if the text isn't  forward-facing.- `'flap'`: Rotated text along the axis to compensate for the chart orientation. This tries to maintain text as legible as possible on all orientations.- `'ortho'`: Rotated text along the axis direction so that the labels are orthogonal to the axis. This is very similar to `'flap'`, but prevents skewing the labels (X and Y scaling are still present).
		/// </summary>
		public ChartparallelAxeslabelsposition3d Position3d { get; set; }
		private ChartparallelAxeslabelsposition3d Position3d_DefaultValue { get; set; }
		 

		/// <summary>
		/// If enabled, the axis labels will skewed to follow the perspective. This will fix overlapping labels and titles, but texts become lesslegible due to the distortion.The final appearance depends heavily on `labels.position3d`.
		/// </summary>
		public ChartparallelAxeslabelsskew3d Skew3d { get; set; }
		private ChartparallelAxeslabelsskew3d Skew3d_DefaultValue { get; set; }
		 

		/// <summary>
		/// What part of the string the given position is anchored to. If `left`,the left side of the string is at the axis position. Can be oneof `"left"`, `"center"` or `"right"`. Defaults to an intelligentguess based on which side of the chart the axis is on and the rotationof the label.
		/// </summary>
		public string Align { get; set; }
		private string Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// For horizontal axes, the allowed degrees of label rotation to preventoverlapping labels. If there is enough space, labels are not rotated.As the chart gets narrower, it will start rotating the labels -45degrees, then remove every second label and try again with rotations0 and -45 etc. Set it to `false` to disable rotation, which willcause the labels to word-wrap if possible.
		/// </summary>
		public List<double> AutoRotation { get; set; }
		private List<double> AutoRotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// When each category width is more than this many pixels, we don'tapply auto rotation. Instead, we lay out the axis label with wordwrap. A lower limit makes sense when the label contains multipleshort words that don't extend the available horizontal space foreach label.
		/// </summary>
		public double? AutoRotationLimit { get; set; }
		private double? AutoRotationLimit_DefaultValue { get; set; }
		 

		/// <summary>
		/// Polar charts only. The label's pixel distance from the perimeterof the plot area.
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// A [format string](http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting) for the axis label.
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to format the label. The value is givenby `this.value`. Additional properties for `this` are `axis`, `chart`,`isFirst` and `isLast`. The value of the default label formattercan be retrieved by calling `this.axis.defaultLabelFormatter.call(this)`within the function.Defaults to:<pre>function() {    return this.value;}</pre>
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to handle overflowing labels on horizontal axis. Can be undefined,`false` or `"justify"`. By default it aligns inside the chart area.If "justify", labels will not render outside the plot area. If `false`,it will not be aligned at all. If there is room to move it, it willbe aligned to the edge, else it will be removed.
		/// </summary>
		public string Overflow { get; set; }
		private string Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel padding for axis labels, to ensure white space betweenthem.
		/// </summary>
		public double? Padding { get; set; }
		private double? Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to reserve space for the labels. This can be turned off whenfor example the labels are rendered inside the plot area insteadof outside.
		/// </summary>
		public bool? ReserveSpace { get; set; }
		private bool? ReserveSpace_DefaultValue { get; set; }
		 

		/// <summary>
		/// Rotation of the labels in degrees.
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal axes only. The number of lines to spread the labels overto make room or tighter labels. .
		/// </summary>
		public double? StaggerLines { get; set; }
		private double? StaggerLines_DefaultValue { get; set; }
		 

		/// <summary>
		/// To show only every _n_'th label on the axis, set the step to _n_.Setting the step to 2 shows every other label.By default, the step is calculated automatically to avoid overlap.To prevent this, set it to 1\. This usually only happens on a categoryaxis, and is often a sign that you have chosen the wrong axis type.Read more at [Axis docs](http://www.highcharts.com/docs/chart-concepts/axes)=> What axis should I use?
		/// </summary>
		public double? Step { get; set; }
		private double? Step_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html) to render the labels.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the tick positionon the axis. The default makes it adapt to the font size on bottomaxis.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index for the axis labels.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (X != X_DefaultValue) h.Add("x",X);
			if (Position3d != Position3d_DefaultValue) h.Add("position3d",Position3d);
			if (Skew3d != Skew3d_DefaultValue) h.Add("skew3d",Skew3d);
			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (AutoRotation != AutoRotation_DefaultValue) h.Add("autoRotation",AutoRotation);
			if (AutoRotationLimit != AutoRotationLimit_DefaultValue) h.Add("autoRotationLimit",AutoRotationLimit);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow",Overflow);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (ReserveSpace != ReserveSpace_DefaultValue) h.Add("reserveSpace",ReserveSpace);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (StaggerLines != StaggerLines_DefaultValue) h.Add("staggerLines",StaggerLines);
			if (Step != Step_DefaultValue) h.Add("step",Step);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (Y != Y_DefaultValue) h.Add("y",Y);
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