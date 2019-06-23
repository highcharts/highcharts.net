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
	public partial class YAxisLabels  : BaseObject
	{
		public YAxisLabels()
		{
			Align = Align_DefaultValue = YAxisLabelsAlign.Null;
			AutoRotation = AutoRotation_DefaultValue = new List<double> {-45};
			Enabled = Enabled_DefaultValue = true;
			Format = Format_DefaultValue = "{value}";
			Formatter = Formatter_DefaultValue = "";
			MaxStaggerLines = MaxStaggerLines_DefaultValue = 5;
			Overflow = Overflow_DefaultValue = YAxisLabelsOverflow.Justify;
			OverflowBool = OverflowBool_DefaultValue = null;
			Rotation = Rotation_DefaultValue = 0;
			StaggerLines = StaggerLines_DefaultValue = null;
			Step = Step_DefaultValue = null;
			Style = Style_DefaultValue = new Hashtable();
			UseHTML = UseHTML_DefaultValue = false;
			X = X_DefaultValue = -8;
			Y = Y_DefaultValue = null;
			ZIndex = ZIndex_DefaultValue = 7;
			
		}	
		

		/// <summary>
		/// What part of the string the given position is anchored to. Canbe one of `"left"`, `"center"` or `"right"`. The exact positionalso depends on the `labels.x` setting.Angular gauges and solid gauges defaults to `"center"`.
		/// </summary>
		public YAxisLabelsAlign Align { get; set; }
		private YAxisLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// For horizontal axes, the allowed degrees of label rotationto prevent overlapping labels. If there is enough space,labels are not rotated. As the chart gets narrower, itwill start rotating the labels -45 degrees, then removeevery second label and try again with rotations 0 and -45 etc.Set it to `false` to disable rotation, which willcause the labels to word-wrap if possible.
		/// </summary>
		public List<double> AutoRotation { get; set; }
		private List<double> AutoRotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the axis labels.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// A [format string](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting)for the axis label.
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to format the label. The valueis given by `this.value`. Additional properties for `this` are`axis`, `chart`, `isFirst` and `isLast`. The value of the defaultlabel formatter can be retrieved by calling`this.axis.defaultLabelFormatter.call(this)` within the function.Defaults to:<pre>function() {    return this.value;}</pre>
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
		public YAxisLabelsOverflow Overflow { get; set; }
		private YAxisLabelsOverflow Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to handle overflowing labels on horizontal axis. If set to`"allow"`, it will not be aligned at all. By default it`"justify"` labels inside the chart area. If there is room tomove it, it will be aligned to the edge, else it will be removed.
		/// </summary>
		public bool? OverflowBool { get; set; }
		private bool? OverflowBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// Rotation of the labels in degrees.
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal axes only. The number of lines to spread the labelsover to make room or tighter labels.
		/// </summary>
		public double? StaggerLines { get; set; }
		private double? StaggerLines_DefaultValue { get; set; }
		 

		/// <summary>
		/// To show only every _n_'th label on the axis, set the step to _n_.Setting the step to 2 shows every other label.By default, the step is calculated automatically to avoidoverlap. To prevent this, set it to 1\. This usually onlyhappens on a category axis, and is often a sign that you havechosen the wrong axis type.Read more at[Axis docs](https://www.highcharts.com/docs/chart-concepts/axes)=> What axis should I use?
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
		/// The x position offset of the label relative to the tick positionon the axis. Defaults to -15 for left axis, 15 for right axis.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the tick positionon the axis.
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

			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (AutoRotation != AutoRotation_DefaultValue) h.Add("autoRotation",AutoRotation);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highstock.AddFunction("YAxisLabelsFormatter.formatter", Formatter); }  
			if (MaxStaggerLines != MaxStaggerLines_DefaultValue) h.Add("maxStaggerLines",MaxStaggerLines);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow", Highstock.FirstCharacterToLower(Overflow.ToString()));
			if (OverflowBool != OverflowBool_DefaultValue) h.Add("overflow", Highstock.FirstCharacterToLower(OverflowBool.ToString()));
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (StaggerLines != StaggerLines_DefaultValue) h.Add("staggerLines",StaggerLines);
			if (Step != Step_DefaultValue) h.Add("step",Step);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
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