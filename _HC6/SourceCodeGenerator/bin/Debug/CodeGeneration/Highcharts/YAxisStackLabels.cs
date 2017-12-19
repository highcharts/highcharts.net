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
	public partial class YAxisStackLabels  : BaseObject
	{
		public YAxisStackLabels()
		{
			AllowOverlap = AllowOverlap_DefaultValue = False;
			Enabled = Enabled_DefaultValue = False;
			Formatter = Formatter_DefaultValue = "";
			Style = Style_DefaultValue = "";
			Align = Align_DefaultValue = YAxisStackLabelsAlign.Left;
			Format = Format_DefaultValue = "{total}";
			Rotation = Rotation_DefaultValue = 0;
			TextAlign = TextAlign_DefaultValue = YAxisStackLabelsTextAlign.Left;
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = YAxisStackLabelsVerticalAlign.Top;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Allow the stack labels to overlap.
		/// </summary>
		public YAxisStackLabelsAllowOverlap AllowOverlap { get; set; }
		private YAxisStackLabelsAllowOverlap AllowOverlap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the stack total labels.
		/// </summary>
		public YAxisStackLabelsEnabled Enabled { get; set; }
		private YAxisStackLabelsEnabled Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to format the label. The value isgiven by `this.total`.
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the label.In styled mode, the styles are set in the`.highcharts-stack-label` class.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the horizontal alignment of the stack total label. Can beone of `"left"`, `"center"` or `"right"`. The default value is calculatedat runtime and depends on orientation and whether the stack is positiveor negative.
		/// </summary>
		public YAxisStackLabelsAlign Align { get; set; }
		private YAxisStackLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// A [format string](http://docs.highcharts.com/#formatting) for thedata label. Available variables are the same as for `formatter`.
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// Rotation of the labels in degrees.
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text alignment for the label. While `align` determines wherethe texts anchor point is placed with regards to the stack, `textAlign`determines how the text is aligned against its anchor point. Possiblevalues are `"left"`, `"center"` and `"right"`. The default valueis calculated at runtime and depends on orientation and whether thestack is positive or negative.
		/// </summary>
		public YAxisStackLabelsTextAlign TextAlign { get; set; }
		private YAxisStackLabelsTextAlign TextAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the labels.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the vertical alignment of the stack total label. Can be oneof `"top"`, `"middle"` or `"bottom"`. The default value is calculatedat runtime and depends on orientation and whether the stack is positiveor negative.
		/// </summary>
		public YAxisStackLabelsVerticalAlign VerticalAlign { get; set; }
		private YAxisStackLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to the left of the stackedbar. The default value is calculated at runtime and depends on orientationand whether the stack is positive or negative.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the tick positionon the axis. The default value is calculated at runtime and dependson orientation and whether the stack is positive or negative.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
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