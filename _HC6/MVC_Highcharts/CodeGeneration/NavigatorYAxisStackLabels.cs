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
	public partial class NavigatorYAxisStackLabels  : BaseObject
	{
		public NavigatorYAxisStackLabels()
		{
			AllowOverlap = AllowOverlap_DefaultValue = null;
			Enabled = Enabled_DefaultValue = null;
			Formatter = Formatter_DefaultValue = "";
			Style = Style_DefaultValue = new NavigatorYAxisStackLabelsStyle();
			Align = Align_DefaultValue = NavigatorYAxisStackLabelsAlign.Null;
			Format = Format_DefaultValue = "{total}";
			Rotation = Rotation_DefaultValue = 0;
			TextAlign = TextAlign_DefaultValue = NavigatorYAxisStackLabelsTextAlign.Null;
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = NavigatorYAxisStackLabelsVerticalAlign.Null;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Allow the stack labels to overlap.</p>
		/// </summary>
		public bool? AllowOverlap { get; set; }
		private bool? AllowOverlap_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable the stack total labels.</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Callback JavaScript function to format the label. The value isgiven by <code>this.total</code>. Defaults to:</p><pre>function() {    return this.total;}</pre>
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS styles for the label.</p><p>In styled mode, the styles are set in the<code>.highcharts-stack-label</code> class.</p>
		/// </summary>
		public NavigatorYAxisStackLabelsStyle Style { get; set; }
		private NavigatorYAxisStackLabelsStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Defines the horizontal alignment of the stack total label. Can beone of <code>&quot;left&quot;</code>, <code>&quot;center&quot;</code> or <code>&quot;right&quot;</code>. The default value is calculatedat runtime and depends on orientation and whether the stack is positiveor negative.</p>
		/// </summary>
		public NavigatorYAxisStackLabelsAlign Align { get; set; }
		private NavigatorYAxisStackLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <a href="http://docs.highcharts.com/#formatting">format string</a> for thedata label. Available variables are the same as for <code>formatter</code>.</p>
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Rotation of the labels in degrees.</p>
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The text alignment for the label. While <code>align</code> determines wherethe texts anchor point is placed with regards to the stack, <code>textAlign</code>determines how the text is aligned against its anchor point. Possiblevalues are <code>&quot;left&quot;</code>, <code>&quot;center&quot;</code> and <code>&quot;right&quot;</code>. The default valueis calculated at runtime and depends on orientation and whether thestack is positive or negative.</p>
		/// </summary>
		public NavigatorYAxisStackLabelsTextAlign TextAlign { get; set; }
		private NavigatorYAxisStackLabelsTextAlign TextAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html">use HTML</a>to render the labels.</p>
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Defines the vertical alignment of the stack total label. Can be oneof <code>&quot;top&quot;</code>, <code>&quot;middle&quot;</code> or <code>&quot;bottom&quot;</code>. The default value is calculatedat runtime and depends on orientation and whether the stack is positiveor negative.</p>
		/// </summary>
		public NavigatorYAxisStackLabelsVerticalAlign VerticalAlign { get; set; }
		private NavigatorYAxisStackLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The x position offset of the label relative to the left of the stackedbar. The default value is calculated at runtime and depends on orientationand whether the stack is positive or negative.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The y position offset of the label relative to the tick positionon the axis. The default value is calculated at runtime and dependson orientation and whether the stack is positive or negative.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highcharts.AddFunction("NavigatorYAxisStackLabelsFormatter.formatter", Formatter); }  
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (TextAlign != TextAlign_DefaultValue) h.Add("textAlign", Highcharts.FirstCharacterToLower(TextAlign.ToString()));
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

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