using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class NavigatorXAxisLabels  : BaseObject
	{
		public NavigatorXAxisLabels()
		{
			Align = Align_DefaultValue = NavigatorXAxisLabelsAlign.Left;
			Style = Style_DefaultValue = new NavigatorXAxisLabelsStyle();
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			Enabled = Enabled_DefaultValue = null;
			AutoRotation = AutoRotation_DefaultValue = new List<double> {-45};
			Format = Format_DefaultValue = "{value}";
			Formatter = Formatter_DefaultValue = "";
			Overflow = Overflow_DefaultValue = NavigatorXAxisLabelsOverflow.Null;
			Rotation = Rotation_DefaultValue = 0;
			StaggerLines = StaggerLines_DefaultValue = null;
			Step = Step_DefaultValue = null;
			UseHTML = UseHTML_DefaultValue = false;
			ZIndex = ZIndex_DefaultValue = 7;
			MaxStaggerLines = MaxStaggerLines_DefaultValue = 5;
			
		}	
		

		/// <summary>
		/// <p>What part of the string the given position is anchored to. If <code>left</code>,the left side of the string is at the axis position. Can be oneof <code>&quot;left&quot;</code>, <code>&quot;center&quot;</code> or <code>&quot;right&quot;</code>. Defaults to an intelligentguess based on which side of the chart the axis is on and the rotationof the label.</p>
		/// </summary>
		public NavigatorXAxisLabelsAlign Align { get; set; }
		private NavigatorXAxisLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS styles for the label. Use <code>whiteSpace: &#39;nowrap&#39;</code> to preventwrapping of category labels. Use <code>textOverflow: &#39;none&#39;</code> toprevent ellipsis (dots).</p><p>In styled mode, the labels are styled with the<code>.highcharts-axis-labels</code> class.</p>
		/// </summary>
		public NavigatorXAxisLabelsStyle Style { get; set; }
		private NavigatorXAxisLabelsStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The x position offset of the label relative to the tick positionon the axis.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The y position offset of the label relative to the tick positionon the axis. The default makes it adapt to the font size on bottomaxis.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable the axis labels.</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>For horizontal axes, the allowed degrees of label rotation to preventoverlapping labels. If there is enough space, labels are not rotated.As the chart gets narrower, it will start rotating the labels -45degrees, then remove every second label and try again with rotations0 and -45 etc. Set it to <code>false</code> to disable rotation, which willcause the labels to word-wrap if possible.</p>
		/// </summary>
		public List<double> AutoRotation { get; set; }
		private List<double> AutoRotation_DefaultValue { get; set; }
		 

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
		public NavigatorXAxisLabelsOverflow Overflow { get; set; }
		private NavigatorXAxisLabelsOverflow Overflow_DefaultValue { get; set; }
		 

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
		 

		/// <summary>
		/// <p>Horizontal axis only. When <code>staggerLines</code> is not set, <code>maxStaggerLines</code>defines how many lines the axis is allowed to add to automaticallyavoid overlapping X labels. Set to <code>1</code> to disable overlap detection.</p>
		/// </summary>
		public double? MaxStaggerLines { get; set; }
		private double? MaxStaggerLines_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (AutoRotation != AutoRotation_DefaultValue) h.Add("autoRotation",AutoRotation);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highstock.AddFunction("NavigatorXAxisLabelsFormatter.formatter", Formatter); }  
			if (Overflow != Overflow_DefaultValue) h.Add("overflow", Highstock.FirstCharacterToLower(Overflow.ToString()));
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (StaggerLines != StaggerLines_DefaultValue) h.Add("staggerLines",StaggerLines);
			if (Step != Step_DefaultValue) h.Add("step",Step);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (MaxStaggerLines != MaxStaggerLines_DefaultValue) h.Add("maxStaggerLines",MaxStaggerLines);
			

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