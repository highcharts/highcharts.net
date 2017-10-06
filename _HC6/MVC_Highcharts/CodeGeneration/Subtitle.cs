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
	public partial class Subtitle  : BaseObject
	{
		public Subtitle()
		{
			Text = Text_DefaultValue = "";
			Align = Align_DefaultValue = SubtitleAlign.Center;
			WidthAdjust = WidthAdjust_DefaultValue = -44;
			Floating = Floating_DefaultValue = false;
			Style = Style_DefaultValue = new Hashtable{{ "color", "#666666" }};
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = SubtitleVerticalAlign.Null;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The subtitle of the chart.</p>
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The horizontal alignment of the subtitle. Can be one of &quot;left&quot;, &quot;center&quot; and &quot;right&quot;.</p>
		/// </summary>
		public SubtitleAlign Align { get; set; }
		private SubtitleAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Adjustment made to the subtitle width, normally to reserve spacefor the exporting burger menu.</p>
		/// </summary>
		public double? WidthAdjust { get; set; }
		private double? WidthAdjust_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When the subtitle is floating, the plot area will not move to makespace for it.</p>
		/// </summary>
		public bool? Floating { get; set; }
		private bool? Floating_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS styles for the title.</p><p>In styled mode, the subtitle style is given in the <code>.highcharts-subtitle</code> class.</p>
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html">use HTML</a> to render the text.</p>
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The vertical alignment of the title. Can be one of &quot;top&quot;, &quot;middle&quot;and &quot;bottom&quot;. When a value is given, the title behaves as floating.</p>
		/// </summary>
		public SubtitleVerticalAlign VerticalAlign { get; set; }
		private SubtitleVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The x position of the subtitle relative to the alignment within chart.spacingLeft and chart.spacingRight.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The y position of the subtitle relative to the alignment within chart.spacingTop and chart.spacingBottom. By default the subtitle is laidout below the title unless the title is floating.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (WidthAdjust != WidthAdjust_DefaultValue) h.Add("widthAdjust",WidthAdjust);
			if (Floating != Floating_DefaultValue) h.Add("floating",Floating);
			if (Style != Style_DefaultValue) h.Add("style",Style);
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