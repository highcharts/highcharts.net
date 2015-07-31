using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
	public partial class YAxisLabels  : BaseObject
	{
		public YAxisLabels()
		{
			Align = Align_DefaultValue = "right";
			Distance = Distance_DefaultValue = 15;
			Enabled = Enabled_DefaultValue = true;
			Format = Format_DefaultValue = "{value}";
			Formatter = Formatter_DefaultValue = "";
			MaxStaggerLines = MaxStaggerLines_DefaultValue = 5;
			Overflow = Overflow_DefaultValue = YAxisLabelsOverflow.Null;
			Rotation = Rotation_DefaultValue = 0;
			StaggerLines = StaggerLines_DefaultValue = null;
			Step = Step_DefaultValue = null;
			Style = Style_DefaultValue = new NameValueCollection{{"color","#6D869F"},{"fontWeight","bold"}};
			UseHTML = UseHTML_DefaultValue = false;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = 3;
			ZIndex = ZIndex_DefaultValue = 7;
			
		}	
		

		/// <summary>
		/// What part of the string the given position is anchored to. Can be one of <code>"left"</code>, <code>"center"</code> or <code>"right"</code>.
		/// </summary>
		public string Align { get; set; }
		private string Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Angular gauges and solid gauges only. The label's pixel distance from the perimeter of the plot area.
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the axis labels.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// A <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting">format string</a> for the axis label. 
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to format the label. The value is  given by <code>this.value</code>. Additional properties for <code>this</code> are <code>axis</code>, <code>chart</code>, <code>isFirst</code> and <code>isLast</code>. Defaults to: <pre>function() {return this.value;}</pre>
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal axis only. When <code>staggerLines</code> is not set, <code>maxStaggerLines</code> defines how many lines the axis is allowed to add to automatically avoid overlapping X labels. Set to <code>1</code> to disable overlap detection. 
		/// </summary>
		public double? MaxStaggerLines { get; set; }
		private double? MaxStaggerLines_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to handle overflowing labels on horizontal axis. Can be undefined, <code>false</code> or <code>"justify"</code>. By default it aligns inside the chart area. If "justify", labels will not render outside the plot area. If <code>false</code>, it will not be aligned at all. If there is room to move it, it will be aligned to the edge, else it will be removed.
		/// </summary>
		public YAxisLabelsOverflow Overflow { get; set; }
		private YAxisLabelsOverflow Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Rotation of the labels in degrees.
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal axes only. The number of lines to spread the labels over to make room or tighter labels.  .
		/// </summary>
		public double? StaggerLines { get; set; }
		private double? StaggerLines_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>To show only every <em>n</em>'th label on the axis, set the step to <em>n</em>. Setting the step to 2 shows every other label.</p><p>By default, the step is calculated automatically to avoid overlap. To prevent this, set it to 1. This usually only happens on a category axis, and is often a sign that you have chosen the wrong axis type. Read more at <a href="http://www.highcharts.com/docs/chart-concepts/axes">Axis docs</a> => What axis should I use?</p> 
		/// </summary>
		public double? Step { get; set; }
		private double? Step_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the label. Use <code>whiteSpace: 'nowrap'</code> to prevent wrapping of category labels. Defaults to:<pre>style: {color: '#6D869F',fontWeight: 'bold'}</pre>
		/// </summary>
		public NameValueCollection Style { get; set; }
		private NameValueCollection Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html">use HTML</a> to render the labels.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to the tick position on the axis. Defaults to -15 for left axis, 15 for right axis.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the tick position on the axis.
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

			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highstock.AddFunction("YAxisLabelsFormatter.formatter", Formatter); }  
			if (MaxStaggerLines != MaxStaggerLines_DefaultValue) h.Add("maxStaggerLines",MaxStaggerLines);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow", Highstock.FirstCharacterToLower(Overflow.ToString()));
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
				return new JavaScriptSerializer().Serialize(ToHashtable());
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