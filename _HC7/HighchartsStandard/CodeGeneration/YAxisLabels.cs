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
	public partial class YAxisLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public YAxisLabels()
		{
		}	
		

		/// <summary>
		/// What part of the string the given position is anchored to. Canbe one of `"left"`, `"center"` or `"right"`. The exact positionalso depends on the `labels.x` setting.Angular gauges and solid gauges defaults to `"center"`.Solid gauges with two labels have additional option `"auto"`for automatic horizontal and vertical alignment.
		/// </summary>
		public YAxisLabelsAlign Align { get; set; }
		 

		/// <summary>
		/// Whether to allow the axis labels to overlap. When false,overlapping labels are hidden.
		/// </summary>
		public bool? AllowOverlap { get; set; }
		 

		/// <summary>
		/// For horizontal axes, the allowed degrees of label rotationto prevent overlapping labels. If there is enough space,labels are not rotated. As the chart gets narrower, itwill start rotating the labels -45 degrees, then removeevery second label and try again with rotations 0 and -45 etc.Set it to `undefined` to disable rotation, which willcause the labels to word-wrap if possible. Defaults to `[-45]``on bottom and top axes, `undefined` on left and right axes.
		/// </summary>
		public List<double> AutoRotation { get; set; }
		 

		/// <summary>
		/// When each category width is more than this many pixels, we don'tapply auto rotation. Instead, we lay out the axis label with wordwrap. A lower limit makes sense when the label contains multipleshort words that don't extend the available horizontal space foreach label.
		/// </summary>
		public double? AutoRotationLimit { get; set; }
		 

		/// <summary>
		/// The label's pixel distance from the perimeter of the plot area.On cartesian charts, this is overridden if the `labels.y` settingis set.On polar charts, if it's a percentage string, it is interpretedthe same as [series.radius](#plotOptions.gauge.radius), so thelabel can be aligned under the gauge's shape.
		/// </summary>
		public string Distance { get; set; }
		 

		/// <summary>
		/// The label's pixel distance from the perimeter of the plot area.On cartesian charts, this is overridden if the `labels.y` settingis set.On polar charts, if it's a percentage string, it is interpretedthe same as [series.radius](#plotOptions.gauge.radius), so thelabel can be aligned under the gauge's shape.
		/// </summary>
		public double? DistanceNumber { get; set; }
		 

		/// <summary>
		/// Enable or disable the axis labels.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// A format string for the axis label. The context is available asformat string variables. For example, you can use `{text}` toinsert the default formatted text. The recommended way of addingunits for the label is using `text`, for example `{text} km`.To add custom numeric or datetime formatting, use `{value}` withformatting, for example `{value:.1f}` or `{value:%Y-%m-%d}`.See[format string](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting)for more examples of formatting.The default value is not specified due to the dynamicnature of the default implementation.
		/// </summary>
		public string Format { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to format the label. The valueis given by `this.value`. Additional properties for `this` are`axis`, `chart`, `isFirst`, `isLast` and `text` which holds thevalue of the default formatter.Defaults to a built in function returning a formatted stringdepending on whether the axis is `category`, `datetime`,`numeric` or other.
		/// </summary>
		public string Formatter { get; set; }
		 

		/// <summary>
		/// Horizontal axis only. When `staggerLines` is not set,`maxStaggerLines` defines how many lines the axis is allowed toadd to automatically avoid overlapping X labels. Set to `1` todisable overlap detection.
		/// </summary>
		public double? MaxStaggerLines { get; set; }
		 

		/// <summary>
		/// How to handle overflowing labels on horizontal axis. If set to`"allow"`, it will not be aligned at all. By default it`"justify"` labels inside the chart area. If there is room tomove it, it will be aligned to the edge, else it will be removed.
		/// </summary>
		public YAxisLabelsOverflow Overflow { get; set; }
		 

		/// <summary>
		/// The pixel padding for axis labels, to ensure white space betweenthem. Defaults to 4 for horizontal axes, 1 for vertical.
		/// </summary>
		public double? Padding { get; set; }
		 

		/// <summary>
		/// Defines how the labels are be repositioned according to the 3Dchart orientation.- `'offset'`: Maintain a fixed horizontal/vertical distance from  the tick marks, despite the chart orientation. This is the  backwards compatible behavior, and causes skewing of X and Z  axes.- `'chart'`: Preserve 3D position relative to the chart. This  looks nice, but hard to read if the text isn't forward-facing.- `'flap'`: Rotated text along the axis to compensate for the  chart orientation. This tries to maintain text as legible as  possible on all orientations.- `'ortho'`: Rotated text along the axis direction so that the  labels are orthogonal to the axis. This is very similar to  `'flap'`, but prevents skewing the labels (X and Y scaling are  still present).
		/// </summary>
		public YAxisLabelsPosition3d Position3d { get; set; }
		 

		/// <summary>
		/// Whether to reserve space for the labels. By default, space isreserved for the labels in these cases:* On all horizontal axes.* On vertical axes if `label.align` is `right` on a left-sideaxis or `left` on a right-side axis.* On vertical axes if `label.align` is `center`.This can be turned off when for example the labels are renderedinside the plot area instead of outside.
		/// </summary>
		public bool? ReserveSpace { get; set; }
		 

		/// <summary>
		/// Rotation of the labels in degrees. When `undefined`, the`autoRotation` option takes precedence.
		/// </summary>
		public double? Rotation { get; set; }
		 

		/// <summary>
		/// If enabled, the axis labels will skewed to follow theperspective.This will fix overlapping labels and titles, but texts becomeless legible due to the distortion.The final appearance depends heavily on `labels.position3d`.
		/// </summary>
		public bool? Skew3d { get; set; }
		 

		/// <summary>
		/// Horizontal axes only. The number of lines to spread the labelsover to make room or tighter labels. 0 disables staggering.
		/// </summary>
		public double? StaggerLines { get; set; }
		 

		/// <summary>
		/// To show only every _n_'th label on the axis, set the step to _n_.Setting the step to 2 shows every other label.By default, when 0, the step is calculated automatically to avoidoverlap. To prevent this, set it to 1\. This usually onlyhappens on a category axis, and is often a sign that you havechosen the wrong axis type.Read more at[Axis docs](https://www.highcharts.com/docs/chart-concepts/axes)=> What axis should I use?
		/// </summary>
		public double? Step { get; set; }
		 

		/// <summary>
		/// CSS styles for the label. Use `whiteSpace: 'nowrap'` to preventwrapping of category labels. Use `textOverflow: 'none'` toprevent ellipsis (dots).In styled mode, the labels are styled with the`.highcharts-axis-labels` class.
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the labels.
		/// </summary>
		public bool? UseHTML { get; set; }
		 

		/// <summary>
		/// The x position offset of all labels relative to the tickpositions on the axis. Defaults to -15 for left axis, 15 forright axis.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// The y position offset of all labels relative to the tickpositions on the axis. For polar and radial axis consider the useof the [distance](#yAxis.labels.distance) option.
		/// </summary>
		public double? Y { get; set; }
		 

		/// <summary>
		/// The Z index for the axis labels.
		/// </summary>
		public double? ZIndex { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Align != YAxisLabelsAlign.Null) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (AllowOverlap != null) h.Add("allowOverlap",AllowOverlap);
			if (AutoRotation != null) h.Add("autoRotation",AutoRotation);
			if (AutoRotationLimit != null) h.Add("autoRotationLimit",AutoRotationLimit);
			if (Distance != null) h.Add("distance",Distance);
			if (DistanceNumber != null) h.Add("distance",DistanceNumber);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Format != null) h.Add("format",Format);
			if (Formatter != null) { h.Add("formatter",Formatter); highcharts.AddFunction("formatter", Formatter); }  
			if (MaxStaggerLines != null) h.Add("maxStaggerLines",MaxStaggerLines);
			if (Overflow != YAxisLabelsOverflow.Null) h.Add("overflow", highcharts.FirstCharacterToLower(Overflow.ToString()));
			if (Padding != null) h.Add("padding",Padding);
			if (Position3d != YAxisLabelsPosition3d.Null) h.Add("position3d", highcharts.FirstCharacterToLower(Position3d.ToString()));
			if (ReserveSpace != null) h.Add("reserveSpace",ReserveSpace);
			if (Rotation != null) h.Add("rotation",Rotation);
			if (Skew3d != null) h.Add("skew3d",Skew3d);
			if (StaggerLines != null) h.Add("staggerLines",StaggerLines);
			if (Step != null) h.Add("step",Step);
			if (Style != null) h.Add("style",Style);
			if (UseHTML != null) h.Add("useHTML",UseHTML);
			if (X != null) h.Add("x",X);
			if (Y != null) h.Add("y",Y);
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