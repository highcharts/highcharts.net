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
	public partial class YAxisPlotLinesLabel  : BaseObject
	{
		public YAxisPlotLinesLabel()
		{
			Align = Align_DefaultValue = "left";
			Rotation = Rotation_DefaultValue = null;
			Style = Style_DefaultValue = null;
			Text = Text_DefaultValue = null;
			TextAlign = TextAlign_DefaultValue = null;
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = YAxisPlotLinesLabelVerticalAlign.Null;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Horizontal alignment of the label. Can be one of &quot;left&quot;, &quot;center&quot;or &quot;right&quot;.</p>
		/// </summary>
		public string Align { get; set; }
		private string Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Rotation of the text label in degrees. Defaults to 0 for horizontalplot lines and 90 for vertical lines.</p>
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS styles for the text label.</p><p>In styled mode, the labels are styled by the<code>.highcharts-plot-line-label</code> class.</p>
		/// </summary>
		public Object Style { get; set; }
		private Object Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The text itself. A subset of HTML is supported.</p>
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The text alignment for the label. While <code>align</code> determines wherethe texts anchor point is placed within the plot band, <code>textAlign</code>determines how the text is aligned against its anchor point. Possiblevalues are &quot;left&quot;, &quot;center&quot; and &quot;right&quot;. Defaults to the same asthe <code>align</code> option.</p>
		/// </summary>
		public string TextAlign { get; set; }
		private string TextAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html">use HTML</a> to render the labels.</p>
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Vertical alignment of the label relative to the plot line. Can beone of &quot;top&quot;, &quot;middle&quot; or &quot;bottom&quot;.</p>
		/// </summary>
		public YAxisPlotLinesLabelVerticalAlign VerticalAlign { get; set; }
		private YAxisPlotLinesLabelVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Horizontal position relative the alignment. Default varies by orientation.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Vertical position of the text baseline relative to the alignment. Default varies by orientation.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align",Align);
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