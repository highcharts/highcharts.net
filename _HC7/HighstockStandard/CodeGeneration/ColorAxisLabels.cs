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
	public partial class ColorAxisLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColorAxisLabels()
		{
		}	
		

		/// <summary>
		/// What part of the string the given position is anchored to.If `left`, the left side of the string is at the axis position.Can be one of `"left"`, `"center"` or `"right"`. Defaults toan intelligent guess based on which side of the chart the axisis on and the rotation of the label.
		/// </summary>
		public ColorAxisLabelsAlign Align { get; set; }
		 

		/// <summary>
		/// Whether to allow the axis labels to overlap. When false,overlapping labels are hidden.
		/// </summary>
		public bool? AllowOverlap { get; set; }
		 

		/// <summary>
		/// For horizontal axes, the allowed degrees of label rotationto prevent overlapping labels. If there is enough space,labels are not rotated. As the chart gets narrower, itwill start rotating the labels -45 degrees, then removeevery second label and try again with rotations 0 and -45 etc.Set it to `undefined` to disable rotation, which willcause the labels to word-wrap if possible. Defaults to `[-45]``on bottom and top axes, `undefined` on left and right axes.
		/// </summary>
		public List<double> AutoRotation { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Distance { get; set; }
		 

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
		/// How to handle overflowing labels on horizontal color axis. If setto `"allow"`, it will not be aligned at all. By default it`"justify"` labels inside the chart area. If there is room tomove it, it will be aligned to the edge, else it will be removed.
		/// </summary>
		public ColorAxisLabelsOverflow Overflow { get; set; }
		 

		/// <summary>
		/// Whether to reserve space for the labels. By default, space isreserved for the labels in these cases:* On all horizontal axes.* On vertical axes if `label.align` is `right` on a left-sideaxis or `left` on a right-side axis.* On vertical axes if `label.align` is `center`.This can be turned off when for example the labels are renderedinside the plot area instead of outside.
		/// </summary>
		public bool? ReserveSpace { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Rotation { get; set; }
		 

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
		/// The x position offset of all labels relative to the tickpositions on the axis. Overrides the `labels.distance` option.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// The y position offset of all labels relative to the tickpositions on the axis. Overrides the `labels.distance` option.
		/// </summary>
		public double? Y { get; set; }
		 

		/// <summary>
		/// The Z index for the axis labels.
		/// </summary>
		public double? ZIndex { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Align != ColorAxisLabelsAlign.Null) h.Add("align", highstock.FirstCharacterToLower(Align.ToString()));
			if (AllowOverlap != null) h.Add("allowOverlap",AllowOverlap);
			if (AutoRotation != null) h.Add("autoRotation",AutoRotation);
			if (Distance != null) h.Add("distance",Distance);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Format != null) h.Add("format",Format);
			if (Formatter != null) { h.Add("formatter",Formatter); highstock.AddFunction("formatter", Formatter); }  
			if (MaxStaggerLines != null) h.Add("maxStaggerLines",MaxStaggerLines);
			if (Overflow != ColorAxisLabelsOverflow.Null) h.Add("overflow", highstock.FirstCharacterToLower(Overflow.ToString()));
			if (ReserveSpace != null) h.Add("reserveSpace",ReserveSpace);
			if (Rotation != null) h.Add("rotation",Rotation);
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