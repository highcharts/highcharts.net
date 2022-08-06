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
	public partial class ChartParallelAxesLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartParallelAxesLabels()
		{
			Align = Align_DefaultValue = ChartParallelAxesLabelsAlign.Center;
			AllowOverlap = AllowOverlap_DefaultValue = false;
			AutoRotation = AutoRotation_DefaultValue = new List<double> {-45};
			AutoRotationLimit = AutoRotationLimit_DefaultValue = 80;
			Distance = Distance_DefaultValue = null;
			Enabled = Enabled_DefaultValue = true;
			Format = Format_DefaultValue = "";
			Formatter = Formatter_DefaultValue = "";
			MaxStaggerLines = MaxStaggerLines_DefaultValue = 5;
			Overflow = Overflow_DefaultValue = ChartParallelAxesLabelsOverflow.Justify;
			Padding = Padding_DefaultValue = 5;
			Position3d = Position3d_DefaultValue = ChartParallelAxesLabelsPosition3d.Offset;
			ReserveSpace = ReserveSpace_DefaultValue = false;
			Rotation = Rotation_DefaultValue = 0;
			Skew3d = Skew3d_DefaultValue = false;
			StaggerLines = StaggerLines_DefaultValue = 0;
			Step = Step_DefaultValue = 0;
			Style = Style_DefaultValue = new Hashtable();
			UseHTML = UseHTML_DefaultValue = false;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = 4;
			ZIndex = ZIndex_DefaultValue = 7;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesLabelsAlign Align { get; set; }
		private ChartParallelAxesLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to allow the axis labels to overlap.When false, overlapping labels are hidden.
		/// </summary>
		public bool? AllowOverlap { get; set; }
		private bool? AllowOverlap_DefaultValue { get; set; }
		 

		/// <summary>
		/// For horizontal axes, the allowed degrees of label rotationto prevent overlapping labels. If there is enough space,labels are not rotated. As the chart gets narrower, itwill start rotating the labels -45 degrees, then removeevery second label and try again with rotations 0 and -45 etc.Set it to `undefined` to disable rotation, which willcause the labels to word-wrap if possible. Defaults to `[-45]``on bottom and top axes, `undefined` on left and right axes.
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
		/// Enable or disable the axis labels.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// A format string for the axis label. The context is available asformat string variables. For example, you can use `{text}` toinsert the default formatted text. The recommended way of addingunits for the label is using `text`, for example `{text} km`.To add custom numeric or datetime formatting, use `{value}` withformatting, for example `{value:.1f}` or `{value:%Y-%m-%d}`.See[format string](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting)for more examples of formatting.The default value is not specified due to the dynamicnature of the default implementation.
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to format the label. The valueis given by `this.value`. Additional properties for `this` are`axis`, `chart`, `isFirst`, `isLast` and `text` which holds thevalue of the default formatter.Defaults to a built in function returning a formatted stringdepending on whether the axis is `category`, `datetime`,`numeric` or other.
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal axis only. When `staggerLines` is not set,`maxStaggerLines` defines how many lines the axis is allowed toadd to automatically avoid overlapping X labels. Set to `1` todisable overlap detection.
		/// </summary>
		public double? MaxStaggerLines { get; set; }
		private double? MaxStaggerLines_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to handle overflowing labels on horizontal axis. If set to`"allow"`, it will not be aligned at all. By default it`"justify"` labels inside the chart area. If there is room tomove it, it will be aligned to the edge, else it will be removed.
		/// </summary>
		public ChartParallelAxesLabelsOverflow Overflow { get; set; }
		private ChartParallelAxesLabelsOverflow Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel padding for axis labels, to ensure white space betweenthem.
		/// </summary>
		public double? Padding { get; set; }
		private double? Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines how the labels are be repositioned according to the 3Dchart orientation.- `'offset'`: Maintain a fixed horizontal/vertical distance from  the tick marks, despite the chart orientation. This is the  backwards compatible behavior, and causes skewing of X and Z  axes.- `'chart'`: Preserve 3D position relative to the chart. This  looks nice, but hard to read if the text isn't forward-facing.- `'flap'`: Rotated text along the axis to compensate for the  chart orientation. This tries to maintain text as legible as  possible on all orientations.- `'ortho'`: Rotated text along the axis direction so that the  labels are orthogonal to the axis. This is very similar to  `'flap'`, but prevents skewing the labels (X and Y scaling are  still present).
		/// </summary>
		public ChartParallelAxesLabelsPosition3d Position3d { get; set; }
		private ChartParallelAxesLabelsPosition3d Position3d_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? ReserveSpace { get; set; }
		private bool? ReserveSpace_DefaultValue { get; set; }
		 

		/// <summary>
		/// Rotation of the labels in degrees. When `undefined`, the`autoRotation` option takes precedence.
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// If enabled, the axis labels will skewed to follow theperspective.This will fix overlapping labels and titles, but texts becomeless legible due to the distortion.The final appearance depends heavily on `labels.position3d`.
		/// </summary>
		public bool? Skew3d { get; set; }
		private bool? Skew3d_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal axes only. The number of lines to spread the labelsover to make room or tighter labels. 0 disables staggering.
		/// </summary>
		public double? StaggerLines { get; set; }
		private double? StaggerLines_DefaultValue { get; set; }
		 

		/// <summary>
		/// To show only every _n_'th label on the axis, set the step to _n_.Setting the step to 2 shows every other label.By default, when 0, the step is calculated automatically to avoidoverlap. To prevent this, set it to 1\. This usually onlyhappens on a category axis, and is often a sign that you havechosen the wrong axis type.Read more at[Axis docs](https://www.highcharts.com/docs/chart-concepts/axes)=> What axis should I use?
		/// </summary>
		public double? Step { get; set; }
		private double? Step_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the label. Use `whiteSpace: 'nowrap'` to preventwrapping of category labels. Use `textOverflow: 'none'` toprevent ellipsis (dots).In styled mode, the labels are styled with the`.highcharts-axis-labels` class.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the labels.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index for the axis labels.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Align != Align_DefaultValue) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (AutoRotation != AutoRotation_DefaultValue) h.Add("autoRotation",AutoRotation);
			if (AutoRotationLimit != AutoRotationLimit_DefaultValue) h.Add("autoRotationLimit",AutoRotationLimit);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); highcharts.AddFunction("formatter", Formatter); }  
			if (MaxStaggerLines != MaxStaggerLines_DefaultValue) h.Add("maxStaggerLines",MaxStaggerLines);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow", highcharts.FirstCharacterToLower(Overflow.ToString()));
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Position3d != Position3d_DefaultValue) h.Add("position3d",Position3d);
			if (ReserveSpace != ReserveSpace_DefaultValue) h.Add("reserveSpace",ReserveSpace);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (Skew3d != Skew3d_DefaultValue) h.Add("skew3d",Skew3d);
			if (StaggerLines != StaggerLines_DefaultValue) h.Add("staggerLines",StaggerLines);
			if (Step != Step_DefaultValue) h.Add("step",Step);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
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

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}