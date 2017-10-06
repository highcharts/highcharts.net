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
	public partial class ChartParallelAxesLabels  : BaseObject
	{
		public ChartParallelAxesLabels()
		{
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			Align = Align_DefaultValue = ChartParallelAxesLabelsAlign.Center;
			ReserveSpace = ReserveSpace_DefaultValue = null;
			Distance = Distance_DefaultValue = -25;
			Enabled = Enabled_DefaultValue = null;
			Style = Style_DefaultValue = new ChartParallelAxesLabelsStyle();
			Position3d = Position3d_DefaultValue = ChartParallelAxesLabelsPosition3d.Offset;
			Skew3d = Skew3d_DefaultValue = null;
			AutoRotation = AutoRotation_DefaultValue = new List<double> {-45};
			AutoRotationLimit = AutoRotationLimit_DefaultValue = 80;
			Format = Format_DefaultValue = "{value}";
			Formatter = Formatter_DefaultValue = "";
			Overflow = Overflow_DefaultValue = ChartParallelAxesLabelsOverflow.Null;
			Padding = Padding_DefaultValue = 5;
			Rotation = Rotation_DefaultValue = 0;
			StaggerLines = StaggerLines_DefaultValue = null;
			Step = Step_DefaultValue = null;
			UseHTML = UseHTML_DefaultValue = false;
			ZIndex = ZIndex_DefaultValue = 7;
			
		}	
		

		/// <summary>
		/// <p>The x position offset of the label relative to the tick positionon the axis. Defaults to -15 for left axis, 15 for right axis.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The y position offset of the label relative to the tick positionon the axis.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>What part of the string the given position is anchored to. Can beone of <code>&quot;left&quot;</code>, <code>&quot;center&quot;</code> or <code>&quot;right&quot;</code>. The exact position alsodepends on the <code>labels.x</code> setting. Angular gauges and solid gaugesdefaults to <code>center</code>.</p>
		/// </summary>
		public ChartParallelAxesLabelsAlign Align { get; set; }
		private ChartParallelAxesLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to reserve space for the labels. This can be turned off whenfor example the labels are rendered inside the plot area insteadof outside.</p>
		/// </summary>
		public bool? ReserveSpace { get; set; }
		private bool? ReserveSpace_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Angular gauges and solid gauges only. The label&#39;s pixel distancefrom the perimeter of the plot area.</p>
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable the axis labels.</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS styles for the label. Use <code>whiteSpace: &#39;nowrap&#39;</code> to preventwrapping of category labels. Use <code>textOverflow: &#39;none&#39;</code> toprevent ellipsis (dots).</p><p>In styled mode, the labels are styled with the<code>.highcharts-axis-labels</code> class.</p>
		/// </summary>
		public ChartParallelAxesLabelsStyle Style { get; set; }
		private ChartParallelAxesLabelsStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Defines how the labels are be repositioned according to the 3D chartorientation.</p><ul><li><code>&#39;offset&#39;</code>: Maintain a fixed horizontal/vertical distance from the   tick marks, despite the chart orientation. This is the backwards   compatible behavior, and causes skewing of X and Z axes.</li><li><code>&#39;chart&#39;</code>: Preserve 3D position relative to the chart.This looks nice, but hard to read if the text isn&#39;tforward-facing.</li><li><code>&#39;flap&#39;</code>: Rotated text along the axis to compensate for the chart   orientation. This tries to maintain text as legible as possible on   all orientations.</li><li><code>&#39;ortho&#39;</code>: Rotated text along the axis direction so that the labels   are orthogonal to the axis. This is very similar to <code>&#39;flap&#39;</code>, but   prevents skewing the labels (X and Y scaling are still present).</li></ul>
		/// </summary>
		public ChartParallelAxesLabelsPosition3d Position3d { get; set; }
		private ChartParallelAxesLabelsPosition3d Position3d_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If enabled, the axis labels will skewed to follow the perspective. </p><p>This will fix overlapping labels and titles, but texts become lesslegible due to the distortion.</p><p>The final appearance depends heavily on <code>labels.position3d</code>.</p>
		/// </summary>
		public bool? Skew3d { get; set; }
		private bool? Skew3d_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>For horizontal axes, the allowed degrees of label rotation to preventoverlapping labels. If there is enough space, labels are not rotated.As the chart gets narrower, it will start rotating the labels -45degrees, then remove every second label and try again with rotations0 and -45 etc. Set it to <code>false</code> to disable rotation, which willcause the labels to word-wrap if possible.</p>
		/// </summary>
		public List<double> AutoRotation { get; set; }
		private List<double> AutoRotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When each category width is more than this many pixels, we don&#39;tapply auto rotation. Instead, we lay out the axis label with wordwrap. A lower limit makes sense when the label contains multipleshort words that don&#39;t extend the available horizontal space foreach label.</p>
		/// </summary>
		public double? AutoRotationLimit { get; set; }
		private double? AutoRotationLimit_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting">format string</a> for the axis label.</p>
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Callback JavaScript function to format the label. The value is givenby <code>this.value</code>. Additional properties for <code>this</code> are <code>axis</code>, <code>chart</code>,<code>isFirst</code> and <code>isLast</code>. The value of the default label formattercan be retrieved by calling <code>this.axis.defaultLabelFormatter.call(this)</code>within the function.</p><p>Defaults to:</p><pre>function() {    return this.value;}</pre>
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>How to handle overflowing labels on horizontal axis. Can be undefined,<code>false</code> or <code>&quot;justify&quot;</code>. By default it aligns inside the chart area.If &quot;justify&quot;, labels will not render outside the plot area. If <code>false</code>,it will not be aligned at all. If there is room to move it, it willbe aligned to the edge, else it will be removed.</p>
		/// </summary>
		public ChartParallelAxesLabelsOverflow Overflow { get; set; }
		private ChartParallelAxesLabelsOverflow Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel padding for axis labels, to ensure white space betweenthem.</p>
		/// </summary>
		public double? Padding { get; set; }
		private double? Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Rotation of the labels in degrees.</p>
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Horizontal axes only. The number of lines to spread the labels overto make room or tighter labels. .</p>
		/// </summary>
		public double? StaggerLines { get; set; }
		private double? StaggerLines_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>To show only every <em>n</em>&#39;th label on the axis, set the step to <em>n</em>.Setting the step to 2 shows every other label.</p><p>By default, the step is calculated automatically to avoid overlap.To prevent this, set it to 1. This usually only happens on a categoryaxis, and is often a sign that you have chosen the wrong axis type.Read more at <a href="http://www.highcharts.com/docs/chart-concepts/axes">Axis docs</a>=&gt; What axis should I use?</p>
		/// </summary>
		public double? Step { get; set; }
		private double? Step_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html">use HTML</a> to render the labels.</p>
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The Z index for the axis labels.</p>
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (ReserveSpace != ReserveSpace_DefaultValue) h.Add("reserveSpace",ReserveSpace);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (Position3d != Position3d_DefaultValue) h.Add("position3d", Highcharts.FirstCharacterToLower(Position3d.ToString()));
			if (Skew3d != Skew3d_DefaultValue) h.Add("skew3d",Skew3d);
			if (AutoRotation != AutoRotation_DefaultValue) h.Add("autoRotation",AutoRotation);
			if (AutoRotationLimit != AutoRotationLimit_DefaultValue) h.Add("autoRotationLimit",AutoRotationLimit);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highcharts.AddFunction("ChartParallelAxesLabelsFormatter.formatter", Formatter); }  
			if (Overflow != Overflow_DefaultValue) h.Add("overflow", Highcharts.FirstCharacterToLower(Overflow.ToString()));
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (StaggerLines != StaggerLines_DefaultValue) h.Add("staggerLines",StaggerLines);
			if (Step != Step_DefaultValue) h.Add("step",Step);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
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