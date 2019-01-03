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
	public partial class ZAxisPlotLinesLabel  : BaseObject
	{
		public ZAxisPlotLinesLabel()
		{
			Align = Align_DefaultValue = ZAxisPlotLinesLabelAlign.Left;
			Rotation = Rotation_DefaultValue = null;
			Style = Style_DefaultValue = new Hashtable();
			Text = Text_DefaultValue = "";
			TextAlign = TextAlign_DefaultValue = "";
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = ZAxisPlotLinesLabelVerticalAlign.Null;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Horizontal alignment of the label. Can be one of "left", "center" or"right".
		/// </summary>
		public ZAxisPlotLinesLabelAlign Align { get; set; }
		private ZAxisPlotLinesLabelAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Rotation of the text label in degrees. Defaults to 0 for horizontal plotlines and 90 for vertical lines.
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the text label.In styled mode, the labels are styled by the`.highcharts-plot-line-label` class.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text itself. A subset of HTML is supported.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text alignment for the label. While `align` determines where thetexts anchor point is placed within the plot band, `textAlign` determineshow the text is aligned against its anchor point. Possible values are"left", "center" and "right". Defaults to the same as the `align` option.
		/// </summary>
		public string TextAlign { get; set; }
		private string TextAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html) to render the labels.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical alignment of the label relative to the plot line. Can beone of "top", "middle" or "bottom".
		/// </summary>
		public ZAxisPlotLinesLabelVerticalAlign VerticalAlign { get; set; }
		private ZAxisPlotLinesLabelVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal position relative the alignment. Default varies byorientation.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical position of the text baseline relative to the alignment. Defaultvaries by orientation.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (TextAlign != TextAlign_DefaultValue) h.Add("textAlign",TextAlign);
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